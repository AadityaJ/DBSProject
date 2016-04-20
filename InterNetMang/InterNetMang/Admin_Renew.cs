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
    public partial class Admin_Renew : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public String a_id;
        public Admin_Renew()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void Admin_Renew_Load(object sender, EventArgs e)
        {

        }

        private void st_Click(object sender, EventArgs e)
        {
            int i = 0;
            connect1();
            comm = new OracleCommand();
            // MessageBox.Show(hate);
            comm.CommandText = "select * from interleaved_ where renew_id not in (select renew_id from renew_)";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "interleaved_");
            dt = ds.Tables["interleaved_"];
            dr = dt.Rows[i];
            int t = dt.Rows.Count;
            for (i = 0; i < t; i++)
            {
                dr = dt.Rows[i];
                this.interleaved.Rows.Insert(i, dr["renew_id"].ToString(), dr["u_id"].ToString(), dr["amount"].ToString());

            }
            conn.Close();
        }

        private void rnw_Click(object sender, EventArgs e)
        {
            int i = 0;
            connect1();
            comm = new OracleCommand();
            // MessageBox.Show(hate);
            comm.CommandText = "select * from interleaved_ where renew_id='"+this.r_id.Text+"'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "interleaved_");
            dt = ds.Tables["interleaved_"];
            dr = dt.Rows[i];
            int t = dt.Rows.Count;
            if (t == 0)
            {
                MessageBox.Show("Error in ID");
            }
            else
            {
                comm = new OracleCommand();
                comm.Connection = conn;
                comm.CommandText = "insert into renew_ values('" + this.r_id.Text + "','" + dr["u_id"].ToString()+ "','" + this.a_id + "','" + date.Text+"',"+dr["amount"]+ ")";
                comm.CommandType = CommandType.Text;

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Done");
            }
        }
    }
}
