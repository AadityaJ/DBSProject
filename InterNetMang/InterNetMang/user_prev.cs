using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace InterNetMang
{
    public partial class user_prev : Form
    {
        public String hate;
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public user_prev()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }
        private void filltable()
        {
            //this.emp_tab.Rows.Insert(0,"her", "lkdhnf", "ljhskdj");
            int i = 0;
            connect1();
            comm = new OracleCommand();
           // MessageBox.Show(hate);
            comm.CommandText = "select Login,Logout,Data_used from user_session_ where u_id='"+hate+"'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "user_session_");
            dt = ds.Tables["user_session_"];
            dr = dt.Rows[i];
            int t = dt.Rows.Count;
            for(i=0;i< t; i++)
            {
                dr = dt.Rows[i];
                this.emp_tab.Rows.Insert(i, dr["Login"].ToString(),dr["Logout"].ToString(),dr["Data_used"].ToString());

            }
           // conn.Close();
        }
        private void user_prev_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emp_tab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            filltable();
            id.Text = hate;
            this.id.ReadOnly = true;
        }
    }
}
