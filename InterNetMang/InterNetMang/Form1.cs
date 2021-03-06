﻿using System;
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
using System.IO;

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
        DateTime dtm2;
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
            comm.CommandText = "select * from admin_pass_ where admin_id='" + this.admin_id.Text + "' and password='" + this.admin_pass.Text + "'";
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
                connect1();
                dtm2 = DateTime.Now;
                OracleCommand c = new OracleCommand("logger", conn);
                c.CommandText = "logger";
                c.Parameters.Add("admin_id", OracleDbType.Varchar2, admin_id.Text, ParameterDirection.Input);
                c.Parameters.Add("date", OracleDbType.Varchar2, dtm2.ToString(), ParameterDirection.Input);
                //execute logger(txt,dtm2
                c.CommandType = CommandType.StoredProcedure;
                c.ExecuteNonQuery();
            }
        }

        private void user_login_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            String u_id = user_id.Text;
            comm.CommandText = "select * from user_ where u_id='" + u_id + "' and password='" + user_pass.Text + "'";// and u_id not in (select u_id from banned_)";
            comm.CommandType = CommandType.Text;
            //textBox1.Text= "select * from user_ where u_id='" + user_id.Text + "' and password='" + user_pass.Text + "' and u_id not in (select u_id from banned_)";
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
                //connect1();
                //check again
                bool res = checktwice(u_id);
                if (res)
                { 
                    Loggedin lg = new Loggedin();
                    lg.Show();
                    lg.u_id = user_id.Text;
                    
                }
                else {
                    MessageBox.Show("User ID is Banned.Please Contact Admin");
                }
            }
        }
        private Boolean checktwice(String u_id)
        {
            OracleCommand com = new OracleCommand();
            com.CommandText = "select * from banned_ where u_id='" + u_id + "'";
            com.CommandType = CommandType.Text;
            //  textBox1.Text=(com).ToString();
            DataSet ds_1 = new DataSet();
            OracleDataAdapter da_1 = new OracleDataAdapter(com.CommandText, conn);
            da_1.Fill(ds_1, "banned_");
            DataTable dt_1;
            dt_1 = ds_1.Tables["banned_"];
            int j = dt_1.Rows.Count;
            if (j == 0) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fillform f = new Fillform();
//            this.SetVisibleCore(false);
            f.Show();
        }

        private void prt_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from admin_log_";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "admin_log_");
            dt = ds.Tables["admin_log_"];
            int t = dt.Rows.Count;
            int i = 0;
            dr = dt.Rows[i];
            var csv = new StringBuilder();
            String filePath = @"C:\Users\aaditya\Desktop\DBSProject\logs\logs.csv";
            while (i != t)
            {
                dr = dt.Rows[i];
                var first = dr["admin_id"].ToString();
                var second = dr["dt"].ToString();
                var newLine = string.Format("{0},{1}", first, second);
                csv.AppendLine(newLine);


                i++;
            }
            File.WriteAllText(filePath, csv.ToString());
            conn.Close();
            Application.Exit();
        }

        private void user_pass_TextChanged(object sender, EventArgs e)
        {
            user_pass.PasswordChar = '*';
        }

        private void admin_pass_TextChanged(object sender, EventArgs e)
        {
            admin_pass.PasswordChar = '*';
        }



        private void User_MouseClick(object sender, MouseEventArgs e)
        {
            User.Visible = false;
        }

        private void User_MouseLeave(object sender, EventArgs e)
        {
            User.Visible = false;
        }

        private void Admin_MouseClick(object sender, MouseEventArgs e)
        {
            Admin.Visible = false;
        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        private void abtus_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible=(false);
        }
    }
}
