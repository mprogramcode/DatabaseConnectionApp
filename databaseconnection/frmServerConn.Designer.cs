namespace databaseconnection
{
    partial class frmServerConn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtservername = new System.Windows.Forms.TextBox();
            this.BtnSaveServerSets = new System.Windows.Forms.Button();
            this.txtservertype = new System.Windows.Forms.TextBox();
            this.txtdatabasename = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfoward = new System.Windows.Forms.Button();
            this.TxtQuery2Box = new System.Windows.Forms.TextBox();
            this.txtQuery1Box = new System.Windows.Forms.TextBox();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btndatagridquery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtservername
            // 
            this.txtservername.Location = new System.Drawing.Point(191, 16);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(100, 20);
            this.txtservername.TabIndex = 0;
            // 
            // BtnSaveServerSets
            // 
            this.BtnSaveServerSets.Location = new System.Drawing.Point(191, 154);
            this.BtnSaveServerSets.Name = "BtnSaveServerSets";
            this.BtnSaveServerSets.Size = new System.Drawing.Size(130, 23);
            this.BtnSaveServerSets.TabIndex = 1;
            this.BtnSaveServerSets.Text = "Save Server Settings";
            this.BtnSaveServerSets.UseVisualStyleBackColor = true;
            this.BtnSaveServerSets.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtservertype
            // 
            this.txtservertype.Location = new System.Drawing.Point(191, 65);
            this.txtservertype.Name = "txtservertype";
            this.txtservertype.Size = new System.Drawing.Size(100, 20);
            this.txtservertype.TabIndex = 2;
            // 
            // txtdatabasename
            // 
            this.txtdatabasename.Location = new System.Drawing.Point(191, 117);
            this.txtdatabasename.Name = "txtdatabasename";
            this.txtdatabasename.Size = new System.Drawing.Size(100, 20);
            this.txtdatabasename.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 218);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnback);
            this.tabPage1.Controls.Add(this.btnfoward);
            this.tabPage1.Controls.Add(this.TxtQuery2Box);
            this.tabPage1.Controls.Add(this.txtQuery1Box);
            this.tabPage1.Controls.Add(this.btnRunQuery);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(34, 153);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "BackButton";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfoward
            // 
            this.btnfoward.Location = new System.Drawing.Point(132, 153);
            this.btnfoward.Name = "btnfoward";
            this.btnfoward.Size = new System.Drawing.Size(85, 23);
            this.btnfoward.TabIndex = 3;
            this.btnfoward.Text = "FowardButton";
            this.btnfoward.UseVisualStyleBackColor = true;
            this.btnfoward.Click += new System.EventHandler(this.btnfoward_Click);
            // 
            // TxtQuery2Box
            // 
            this.TxtQuery2Box.Location = new System.Drawing.Point(34, 69);
            this.TxtQuery2Box.Name = "TxtQuery2Box";
            this.TxtQuery2Box.Size = new System.Drawing.Size(183, 20);
            this.TxtQuery2Box.TabIndex = 2;
            // 
            // txtQuery1Box
            // 
            this.txtQuery1Box.Location = new System.Drawing.Point(34, 23);
            this.txtQuery1Box.Name = "txtQuery1Box";
            this.txtQuery1Box.Size = new System.Drawing.Size(183, 20);
            this.txtQuery1Box.TabIndex = 1;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(376, 153);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(75, 23);
            this.btnRunQuery.TabIndex = 0;
            this.btnRunQuery.Text = "Run Query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnSaveServerSets);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtservername);
            this.tabPage2.Controls.Add(this.txtdatabasename);
            this.tabPage2.Controls.Add(this.txtservertype);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server Connection Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataBase Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btndatagridquery);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(468, 192);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DataGrid";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btndatagridquery
            // 
            this.btndatagridquery.Location = new System.Drawing.Point(390, 159);
            this.btndatagridquery.Name = "btndatagridquery";
            this.btndatagridquery.Size = new System.Drawing.Size(75, 23);
            this.btndatagridquery.TabIndex = 0;
            this.btndatagridquery.Text = "Run Query";
            this.btndatagridquery.UseVisualStyleBackColor = true;
            this.btndatagridquery.Click += new System.EventHandler(this.btndatagridquery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmServerConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmServerConn";
            this.Text = "SQL Server Test Con Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.Button BtnSaveServerSets;
        private System.Windows.Forms.TextBox txtservertype;
        private System.Windows.Forms.TextBox txtdatabasename;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.TextBox TxtQuery2Box;
        private System.Windows.Forms.TextBox txtQuery1Box;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnfoward;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndatagridquery;
    }
}

