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
    public partial class CompleteSession : Form
    {
        public String hate;
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public CompleteSession()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }
        private void start_Click(object sender, EventArgs e)
        {
            int i = 0;
            connect1();
            comm = new OracleCommand();
            // MessageBox.Show(hate);
            comm.CommandText = "select * from user_session_";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "user_session_");
            dt = ds.Tables["user_session_"];
            dr = dt.Rows[i];
            int t = dt.Rows.Count;
            for (i = 0; i < t; i++)
            {
                dr = dt.Rows[i];
                this.tot_table.Rows.Insert(i, dr["session_id"].ToString(), dr["u_id"].ToString(), dr["Login"].ToString(), dr["Logout"].ToString(), dr["Data_used"].ToString());

            }
            conn.Close();
        }

        private void id_strt_Click(object sender, EventArgs e)
        {
        }
    }
}
