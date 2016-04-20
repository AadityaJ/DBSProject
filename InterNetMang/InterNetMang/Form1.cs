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
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Form1()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from admin_ where admin_id='" + this.admin_id.Text + "' and password='" + this.admin_pass.Text + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "admin_");
            dt = ds.Tables["admin_"];
            int t = dt.Rows.Count;
            if (t == 0)
            {
                MessageBox.Show("Invalid id and password combo");
            }
            else
            {
                // new form
                admin_form af = new admin_form();
                af.Show();
                af.a_id = this.admin_id.Text;

            }
        }

        private void user_login_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from user_ where u_id='" + user_id.Text + "' and password='" + user_pass.Text + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "user_");
            dt = ds.Tables["user_"];
            int t = dt.Rows.Count;
            if (t == 0)
            {
                MessageBox.Show("Invalid id and password combo");
            }
            else
            {
                // new form
                Loggedin lg = new Loggedin();
                lg.Show();
                lg.u_id=user_id.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fillform f = new Fillform();
//            this.SetVisibleCore(false);
            f.Show();
        }
    }
}
