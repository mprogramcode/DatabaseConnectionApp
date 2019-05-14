using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using databaseconnection.Properties;
using System.Data;

namespace databaseconnection
{
    public class SQLDataConnection
    {
        //is used to set connections settings from txtboxes
        public string SetSQLServerName;
        public string SetSQLServerType;
        public string SetSQLDatabaseName;

        //sets program server settings
        public void SetDataConSettings()
        {
            Settings.Default["SQLSERVERNAME"] = SetSQLServerName;
            Settings.Default["SQLServerType"] = SetSQLDatabaseName;
            Settings.Default["DATABASENAME"] = SetSQLServerType;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        //Checks to make sure connections settings are saved and are not the default null
        public bool DataConnectionSettingsCheck()
        {

            if (Settings.Default["SQLSERVERNAME"].ToString() == "NULL")
            {

                MessageBox.Show("Please Configure A Server Name In Program Settings");
                return false;

            }

            if (Settings.Default["DATABASENAME"].ToString() == "NULL")
            {

                MessageBox.Show("Please Configure A Database Name In Program Settings");
                return false;

            }

            if (Settings.Default["SQLServerType"].ToString() == "NULL")
            {

                MessageBox.Show("Please Configure A Database TYPE In Program Settings");
                return false;

            }

            return true;

        }

        //Puts SQL Results in a dataset
        public DataSet dataresults = new DataSet();

        //connects program to database
        public void ConnectToDatabase(string QueryType, string SQLQuery, string[] SQLQueryVales)
        {
            //get connections string to SQL Server
            string SQLServerName = "Data Source=" + Settings.Default["SQLSERVERNAME"].ToString();
            string SQLServerType = @"\" + Settings.Default["DATABASENAME"].ToString() + ";";
            string SQLDatabaseName = "Initial Catalog=" + Settings.Default["SQLServerType"].ToString() + ";";
            string SQLDatabaseSecurity = "integrated security = SSPI";

            //Create Database Connection and check programs settings are not null
            if (DataConnectionSettingsCheck() == true)
            {
                //create connection string from saved program settings
                string ConnStr = SQLServerName + SQLServerType + SQLDatabaseName + SQLDatabaseSecurity;

                //Create Database Connection
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnStr))
                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = SQLQuery;

                        foreach (string item in SQLQueryVales)
                        {

                            string[] SQLParm = item.Split(new char[] { ',' });
                            string flightcode = SQLParm[0] + SQLParm[1];

                            cmd.Parameters.AddWithValue(SQLParm[0], SQLParm[1]);

                        }

                        if (QueryType == "query")
                        {

                            conn.Open();

                            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                            sqlDataAdap.Fill(dataresults);

                            conn.Close();
                            sqlDataAdap.Dispose();
                        }
                        else if (QueryType == "insert")
                        {
                            conn.Open();
                            int modified = cmd.ExecuteNonQuery();

                            if (modified == 0)
                            {

                                MessageBox.Show("Error Insert Contact System Administrator");

                            }
                            else
                            {
                                MessageBox.Show("Insert Successfully");
                            }
                            conn.Close();
                        }
                        else if (QueryType == "update")
                        {
                            conn.Open();
                            int modified = cmd.ExecuteNonQuery();

                            if (modified == 0)
                            {

                                MessageBox.Show("Error Updating Contact System Administrator");

                            }
                            else
                            {
                                MessageBox.Show("Update Successfully");
                            }
                            conn.Close();
                        }
                        else if (QueryType == "delete")
                        {
                            conn.Open();
                            int modified = cmd.ExecuteNonQuery();

                            if (modified == 0)
                            {

                                MessageBox.Show("Error Deleting Contact System Administrator");

                            }
                            else
                            {

                                MessageBox.Show("Deleted Successfully");

                            }
                            conn.Close();
                        }
                        else
                        {

                            MessageBox.Show("Incorrect SQL Paramter Specified In Code Contact System Administrator");

                        }
                    }
                }
                catch (SqlException e) when (e.Number == 53)
                {

                    MessageBox.Show("Unable To Connect To SQL Server Please Check Connection Settings");

                }
                catch (SqlException e) when (e.Number == -1)
                {

                    MessageBox.Show("SQL Server Type Inncorrectly Set Please Check Connection Settings");

                }
                catch (SqlException e) when (e.Number == 4060)
                {

                    MessageBox.Show("Unable To Find Database Instance On SQL Server Please Check Connection Settings");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }

            }
            else
            {

                return;

            }

        }

    }
}
