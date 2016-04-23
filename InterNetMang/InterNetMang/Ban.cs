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
    public partial class Ban : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public String a_id;
        public Ban()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=xe;Persist Security Info=True;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void Ban_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into banned_ values('" +this.u_id.Text+ "','" +this.a_id+ "')" ;
            comm.CommandType = CommandType.Text;
            
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("User Banned from ");
        }

       

        private void tab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void unb_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "delete from banned_ where u_id='"+u_id+"'";
            comm.CommandType = CommandType.Text;

            comm.ExecuteNonQuery();
            MessageBox.Show("Dona");
            conn.Close();
        }
    }
}
