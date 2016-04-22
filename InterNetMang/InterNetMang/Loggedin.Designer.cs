namespace InterNetMang
{
    partial class Loggedin
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
            this.strt = new System.Windows.Forms.Button();
            this.rnw = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.phno = new System.Windows.Forms.TextBox();
            this.prev = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strt
            // 
            this.strt.Location = new System.Drawing.Point(58, 30);
            this.strt.Name = "strt";
            this.strt.Size = new System.Drawing.Size(113, 23);
            this.strt.TabIndex = 0;
            this.strt.Text = "Start Session";
            this.strt.UseVisualStyleBackColor = true;
            this.strt.Click += new System.EventHandler(this.strt_Click);
            // 
            // rnw
            // 
            this.rnw.Location = new System.Drawing.Point(62, 365);
            this.rnw.Name = "rnw";
            this.rnw.Size = new System.Drawing.Size(75, 23);
            this.rnw.TabIndex = 1;
            this.rnw.Text = "Renew";
            this.rnw.UseVisualStyleBackColor = true;
            this.rnw.Click += new System.EventHandler(this.rnw_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(415, 365);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show Details";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(59, 169);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 4;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone No";
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(138, 162);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(189, 20);
            this.nm.TabIndex = 10;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(138, 198);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 11;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(138, 228);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(124, 20);
            this.dob.TabIndex = 12;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(138, 265);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(124, 20);
            this.age.TabIndex = 13;
            // 
            // phno
            // 
            this.phno.Location = new System.Drawing.Point(138, 298);
            this.phno.Name = "phno";
            this.phno.Size = new System.Drawing.Size(124, 20);
            this.phno.TabIndex = 14;
            this.phno.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(386, 69);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(104, 23);
            this.prev.TabIndex = 15;
            this.prev.Text = "Show Previous";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click_1);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(79, 69);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 16;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(250, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "L-ION";
            // 
            // Loggedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 415);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.start);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.phno);
            this.Controls.Add(this.age);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.rnw);
            this.Text = "Loggedin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button strt;
        private System.Windows.Forms.Button rnw;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nm;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox phno;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label6;
    }
}