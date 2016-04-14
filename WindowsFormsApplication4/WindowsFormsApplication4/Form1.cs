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
            string oradb ="Data Source=localhost;Persist Security Info=True;User ID=system;Password=1234;Unicode=True";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_MouseHover(object sender, EventArgs e)
        {
            admin.BackColor = Color.White;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            admin_id.Visible = true;
            admin_pass.Visible = true;


            user.BackColor = Color.Blue;
            label6.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            user_id.Visible = false;
            user_pass.Visible = false;
        }

        private void admin_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void user_MouseHover(object sender, EventArgs e)
        {
            user.BackColor = Color.White;
            label6.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            user_id.Visible = true;
            user_pass.Visible = true;

            admin.BackColor = Color.Green;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            admin_id.Visible = false;
            admin_pass.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            connect1();
            comm = new OracleCommand();
            if (this.user_id.Text.Equals(""))  // do for admin
            {
                comm.CommandText = "select password from admin_ where admin_id ='"+admin_id+"' and password='"+admin_pass.Text+"';";
            }
            else
            {
                comm.CommandText="select password from user_ where u_id ='"+user_id.Text+"' and password='"+user_pass.Text+"';";
            }
            //comm.CommandText = "select * from user_ where u_id ='"+usernameuser+"' and password ='"+passwordadmin+"'";
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
                Form2 f = new Form2();
                f.Show();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
