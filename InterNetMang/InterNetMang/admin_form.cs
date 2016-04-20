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
    public partial class admin_form : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public String a_id;
        public admin_form()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }


        private void admin_form_Load(object sender, EventArgs e)
        {

        }

        private void sd_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from admin_ where admin_id='" + a_id + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "admin_");
            dt = ds.Tables["admin_"];
            dr = dt.Rows[0];
            this.name.Text = dr["name"].ToString();
            this.admin_id.Text = dr["admin_id"].ToString();
            this.phno.Text = dr["ph_no"].ToString();
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void session_Click(object sender, EventArgs e)
        {
            CompleteSession cs = new CompleteSession();
            cs.Show();
        }

        private void ban_users_Click(object sender, EventArgs e)
        {
            Ban ba = new Ban();
            ba.Show();
            ba.a_id = this.a_id;
        }

        private void renew_Click(object sender, EventArgs e)
        {
            Admin_Renew ar = new Admin_Renew();
            ar.Show();
            ar.a_id = this.a_id;
        }
    }
}
