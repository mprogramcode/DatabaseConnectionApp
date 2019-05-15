using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using databaseconnection.Properties;

namespace databaseconnection
{
    public partial class frmServerConn : Form
    {
        public frmServerConn()
        {
            InitializeComponent();
        }

        SQLDataConnection SQLDataConn = new SQLDataConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Set SQL Server Name
        private void button1_Click(object sender, EventArgs e)
        {

            SQLDataConn.SetSQLServerName = txtservername.Text;
            SQLDataConn.SetSQLServerType = txtservertype.Text;
            SQLDataConn.SetSQLDatabaseName = txtdatabasename.Text;
            SQLDataConn.SetDataConSettings();

            if (SQLDataConn.DataConnectionSettingsCheck() == false)
            {

                return;

            }

        }

        //row counter
        int rownum;

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            string SQLQuery = "select * from customer where fname = @fname and lname = @lname;";
            string[] SQLParms = new string[] { "@fname,jet", "lname,small" };

            SQLDataConn.ConnectToDatabase("query", SQLQuery, SQLParms);

            //declares a dataset which the results of the SQL data is stored
            DataSet dataresults = new DataSet();
            dataresults = SQLDataConn.dataresults;

            //checks to make sure the query return data
            if (dataresults.Tables.Count > 0)
            {
                //Puts the data from the dataset into text boxes on the GUI
                DataRow Row = dataresults.Tables[0].Rows[0];
                txtQuery1Box.Text = Row["fname"].ToString();
                TxtQuery2Box.Text = Row["lname"].ToString();
                rownum = 0;
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {

            DataSet dataresults = new DataSet();
            dataresults = SQLDataConn.dataresults;
            
            if (rownum > 0)
            {
                rownum -= 1;
                DataRow Row = dataresults.Tables[0].Rows[rownum];
                txtQuery1Box.Text = Row["logintime"].ToString();
                TxtQuery2Box.Text = Row["result"].ToString();
            }
        }

        private void btnfoward_Click(object sender, EventArgs e)
        {

            DataSet dataresults = new DataSet();
            dataresults = SQLDataConn.dataresults;
            rownum += 1;

            if (rownum < dataresults.Tables[0].Rows.Count)
            {  
                DataRow Row = dataresults.Tables[0].Rows[rownum];
                txtQuery1Box.Text = Row["logintime"].ToString();
                TxtQuery2Box.Text = Row["result"].ToString();
            }
            else
            {
                rownum -= 1;

            }

        }
    }
}
