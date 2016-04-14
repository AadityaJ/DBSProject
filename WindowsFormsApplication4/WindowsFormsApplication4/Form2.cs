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

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;

        string name = "";
        string phoneno = "";
        string u_id = "";
        string password = "";
        string dob = "";
        string address = "";
        


        public Form2()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            string oradb = "Data Source=localhost;User ID=system;Password=1234";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            int v = int.Parse(textBox1.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection=conn;
            cm.CommandText = "insert into user_ values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "')";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Inserted! ");
            conn.Close();




            this.Hide();
            Form1 frm = new Form1();
            frm.Show();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }


      

    }
}
