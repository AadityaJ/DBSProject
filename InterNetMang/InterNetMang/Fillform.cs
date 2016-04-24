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
    public partial class Fillform : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Fillform()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int id_val()
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select max(id) from last_ where table_name='user_'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "user_");
            dt = ds.Tables["user_"];
            dr = dt.Rows[0];
            int id = int.Parse(dr["max(id)"].ToString());
            id+=1;
            comm.Connection = conn;
            comm.CommandText = "insert into last_ values('" + id.ToString() + "','user_')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            return id;
        }
        private void Done_Click(object sender, EventArgs e)
        {
            if (this.nm.Text.Equals(""))
            {
                MessageBox.Show("Input Not Proper");
                this.Close();
            }
            else {
                int id = id_val();
                connect1();
                comm = new OracleCommand();
                comm.Connection = conn;
                comm.CommandText = "insert into user_ values ('" + nm.Text + "','" + id + "','" + this.ph_no.Text + "','" + this.address.Text + "','" + textBox2.Text.ToString() + "','" + age.Text + "','" + this.pass.Text + "')";
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User created  with user id :" + id.ToString());
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
