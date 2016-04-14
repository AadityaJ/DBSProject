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
        string passwordadmin="";
        string passwordadmins = "";
        string usernameuser = "";
        public Form1()
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
          

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();

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
            textBox1.Visible = true;
            textBox2.Visible = true;


            user.BackColor = Color.Blue;
            label6.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
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
            textBox3.Visible = true;
            textBox4.Visible = true;

            admin.BackColor = Color.Green;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passwordadmin = textBox2.Text;



        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            usernameuser = textBox1.Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from user_ where u_id ='"+usernameuser+"' and password ='"+passwordadmin+"'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "user_");
            dt=ds.Tables["user_"];
            int t = dt.Rows.Count;
            







            if(t!=0)
            {
                this.Hide();
                Form3 frm = new Form3();
                frm.Show();
            }
            else 
            MessageBox.Show("Invalid UserID and Password");
            conn.Close();

            if (usernameuser == "" || passwordadmin == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (passwordadmins == passwordadmin)
            {
                this.Hide();
                Form3 frm = new Form3();
                frm.Show();
            }
            else
                MessageBox.Show("Invalid UserID and Password");


        }

        
    }
}
