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
    public partial class Renew : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        DateTime dtm;
        DateTime dtm2;
        public String u_id_r;
        public Renew()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int get_inter_id()
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select max(id) from last_ where table_name='interleaved_'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "last_");
            dt = ds.Tables["last_"];
            dr = dt.Rows[0];
            int id = Int32.Parse(dr["max(id)"].ToString());
            id++;
            comm.Connection = conn;
            comm.CommandText = "insert into last_ values('" + id.ToString() + "','interleaved_')";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            return id;

        }
        private void Enter_Click(object sender, EventArgs e)
        {
            int id = get_inter_id();
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            int amt = int.Parse(textBox1.Text);
            comm.CommandText = "insert into interleaved_ values ('" + id + "','" + u_id_r + "'," +amt+")";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thanks You . Your Renewal request is now undergoing processing.");
            this.Close();
        }

        private void sr_Click(object sender, EventArgs e)
        {
            int i = 0;
            connect1();
            comm = new OracleCommand();
            // MessageBox.Show(hate);
            comm.CommandText = "select * from renew_ where u_id='"+u_id_r+"'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "renew_");
            dt = ds.Tables["renew_"];
            dr = dt.Rows[i];
            int t = dt.Rows.Count;
            for (i = 0; i < t; i++)
            {
                dr = dt.Rows[i];
                this.renew_table.Rows.Insert(i, dr["renew_id"].ToString(),dr["admin_id"].ToString(),dr["curr_date"].ToString(), dr["amount"].ToString());

            }
            conn.Close();
        }
    }
}
