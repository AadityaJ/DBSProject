namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.admin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_id = new System.Windows.Forms.TextBox();
            this.admin_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.user_pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Green;
            this.admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(74, 256);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(347, 126);
            this.admin.TabIndex = 0;
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.button1_Click);
            this.admin.MouseLeave += new System.EventHandler(this.admin_MouseLeave);
            this.admin.MouseHover += new System.EventHandler(this.admin_MouseHover);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Blue;
            this.user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(569, 256);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(341, 126);
            this.user.TabIndex = 1;
            this.user.UseVisualStyleBackColor = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            this.user.MouseHover += new System.EventHandler(this.user_MouseHover);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Crimson;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(755, 550);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(155, 22);
            this.Register.TabIndex = 2;
            this.Register.Text = "Not an existing user?";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(108, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "User id:";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(108, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            this.label3.Visible = false;
            // 
            // admin_id
            // 
            this.admin_id.Location = new System.Drawing.Point(231, 276);
            this.admin_id.Name = "admin_id";
            this.admin_id.Size = new System.Drawing.Size(180, 20);
            this.admin_id.TabIndex = 6;
            this.admin_id.Visible = false;
            this.admin_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.admin_id.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // admin_pass
            // 
            this.admin_pass.Location = new System.Drawing.Point(231, 349);
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.PasswordChar = '*';
            this.admin_pass.Size = new System.Drawing.Size(180, 20);
            this.admin_pass.TabIndex = 7;
            this.admin_pass.Visible = false;
            this.admin_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.admin_pass.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(600, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "User id:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(599, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            this.label5.Visible = false;
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(720, 276);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(180, 20);
            this.user_id.TabIndex = 10;
            this.user_id.Visible = false;
            this.user_id.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // user_pass
            // 
            this.user_pass.Location = new System.Drawing.Point(720, 349);
            this.user_pass.Name = "user_pass";
            this.user_pass.PasswordChar = '*';
            this.user_pass.Size = new System.Drawing.Size(180, 20);
            this.user_pass.TabIndex = 11;
            this.user_pass.Visible = false;
            this.user_pass.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(701, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "User";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Sienna;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(453, 451);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 13;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 584);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.admin_pass);
            this.Controls.Add(this.admin_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.user);
            this.Controls.Add(this.admin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox admin_id;
        private System.Windows.Forms.TextBox admin_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox user_pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button login;
    }
}

