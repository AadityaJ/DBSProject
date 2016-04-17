namespace InterNetMang
{
    partial class user_prev
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
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.emp_tab = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_us = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emp_tab)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(196, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 1;
            // 
            // emp_tab
            // 
            this.emp_tab.AllowUserToAddRows = false;
            this.emp_tab.AllowUserToDeleteRows = false;
            this.emp_tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_tab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Logout,
            this.Data_us});
            this.emp_tab.Location = new System.Drawing.Point(165, 122);
            this.emp_tab.Name = "emp_tab";
            this.emp_tab.ReadOnly = true;
            this.emp_tab.Size = new System.Drawing.Size(344, 150);
            this.emp_tab.TabIndex = 2;
            this.emp_tab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_tab_CellContentClick);
            // 
            // Login
            // 
            this.Login.Frozen = true;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Logout
            // 
            this.Logout.Frozen = true;
            this.Logout.HeaderText = "Logout";
            this.Logout.Name = "Logout";
            this.Logout.ReadOnly = true;
            // 
            // Data_us
            // 
            this.Data_us.Frozen = true;
            this.Data_us.HeaderText = "Data Used";
            this.Data_us.Name = "Data_us";
            this.Data_us.ReadOnly = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(346, 26);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // user_prev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 381);
            this.Controls.Add(this.start);
            this.Controls.Add(this.emp_tab);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "user_prev";
            this.Text = "user_prev";
            this.Load += new System.EventHandler(this.user_prev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emp_tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DataGridView emp_tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_us;
        private System.Windows.Forms.Button start;
    }
}