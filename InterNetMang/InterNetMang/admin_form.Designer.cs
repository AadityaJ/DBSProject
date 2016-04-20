namespace InterNetMang
{
    partial class admin_form
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
            this.sd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.admin_id = new System.Windows.Forms.TextBox();
            this.phno = new System.Windows.Forms.TextBox();
            this.ban_users = new System.Windows.Forms.Button();
            this.renew = new System.Windows.Forms.Button();
            this.session = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sd
            // 
            this.sd.Location = new System.Drawing.Point(67, 13);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(94, 23);
            this.sd.TabIndex = 0;
            this.sd.Text = "Show Details";
            this.sd.UseVisualStyleBackColor = true;
            this.sd.Click += new System.EventHandler(this.sd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Nos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(154, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 4;
            // 
            // admin_id
            // 
            this.admin_id.Location = new System.Drawing.Point(154, 86);
            this.admin_id.Name = "admin_id";
            this.admin_id.Size = new System.Drawing.Size(100, 20);
            this.admin_id.TabIndex = 5;
            // 
            // phno
            // 
            this.phno.Location = new System.Drawing.Point(154, 115);
            this.phno.Name = "phno";
            this.phno.Size = new System.Drawing.Size(100, 20);
            this.phno.TabIndex = 6;
            // 
            // ban_users
            // 
            this.ban_users.Location = new System.Drawing.Point(37, 196);
            this.ban_users.Name = "ban_users";
            this.ban_users.Size = new System.Drawing.Size(75, 23);
            this.ban_users.TabIndex = 7;
            this.ban_users.Text = "Ban Users";
            this.ban_users.UseVisualStyleBackColor = true;
            // 
            // renew
            // 
            this.renew.Location = new System.Drawing.Point(392, 195);
            this.renew.Name = "renew";
            this.renew.Size = new System.Drawing.Size(75, 23);
            this.renew.TabIndex = 8;
            this.renew.Text = "Renew";
            this.renew.UseVisualStyleBackColor = true;
            // 
            // session
            // 
            this.session.Location = new System.Drawing.Point(362, 12);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(105, 23);
            this.session.TabIndex = 9;
            this.session.Text = "Show Session";
            this.session.UseVisualStyleBackColor = true;
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 331);
            this.Controls.Add(this.session);
            this.Controls.Add(this.renew);
            this.Controls.Add(this.ban_users);
            this.Controls.Add(this.phno);
            this.Controls.Add(this.admin_id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sd);
            this.Name = "admin_form";
            this.Text = "admin_form";
            this.Load += new System.EventHandler(this.admin_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox admin_id;
        private System.Windows.Forms.TextBox phno;
        private System.Windows.Forms.Button ban_users;
        private System.Windows.Forms.Button renew;
        private System.Windows.Forms.Button session;
    }
}