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
    public partial class Loggedin : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        DateTime dtm ;
        DateTime dtm2;
        public String u_id;
        public Loggedin()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }
        private void strt_Click(object sender, EventArgs e)
        {
            

        }

        private void rnw_Click(object sender, EventArgs e)
        {
            Renew rn = new Renew();
            rn.Show();
            rn.u_id_r = this.u_id;
        }
        private int getSessionId()
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select max(id) from last_ where table_name='user_session_'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "user_");
            dt = ds.Tables["user_"];
            dr = dt.Rows[0];
            int id = Int32.Parse(dr["max(id)"].ToString());
            id++;
            comm.Connection = conn;
            comm.CommandText = "insert into last_ values('" + id.ToString() + "','user_session_')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            return id;
        }
        private void logout_Click(object sender, EventArgs e)
        {
            // add table
            // insert to user_session_
            Random rnd = new Random();
            int data = rnd.Next(1, 100);
            dtm2 = DateTime.Now;
            int id = getSessionId();
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into user_session_ values ('" +id+"','"+u_id+"','"+dtm.ToString()+"','"+dtm2.ToString()+"',"+data+")";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_prev up = new user_prev();
            MessageBox.Show(u_id);
            MessageBox.Show(u_id);
            up.u_id_up = this.u_id;
            up.Show();
        }


        private void prev_Click_1(object sender, EventArgs e)
        {
            //user_prev up = new user_prev();
            MessageBox.Show("aaaaaaaaaaaaaaa");
            MessageBox.Show(u_id);
            user_prev up = new user_prev();
            up.u_id_up = u_id;
            up.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            dtm = DateTime.Now;
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from user_ where u_id='" + u_id + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "user_");
            dt = ds.Tables["user_"];
            dr = dt.Rows[0];
            this.nm.Text = dr["name"].ToString();
            this.id.Text = dr["u_id"].ToString();
            this.dob.Text = dr["dob"].ToString();
            this.age.Text = dr["age"].ToString();
            this.phno.Text = dr["ph_no"].ToString();
            conn.Close();
        }
    }
}
