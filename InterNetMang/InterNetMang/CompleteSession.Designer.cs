namespace InterNetMang
{
    partial class CompleteSession
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
            this.start = new System.Windows.Forms.Button();
            this.tot_table = new System.Windows.Forms.DataGridView();
            this.Session_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tot_table)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(95, 13);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tot_table
            // 
            this.tot_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tot_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Session_ID,
            this.User_ID,
            this.Login,
            this.Logout,
            this.Data_used});
            this.tot_table.Location = new System.Drawing.Point(95, 83);
            this.tot_table.Name = "tot_table";
            this.tot_table.Size = new System.Drawing.Size(544, 200);
            this.tot_table.TabIndex = 1;
            // 
            // Session_ID
            // 
            this.Session_ID.HeaderText = "Session_id";
            this.Session_ID.Name = "Session_ID";
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "User ID";
            this.User_ID.Name = "User_ID";
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Logout
            // 
            this.Logout.HeaderText = "Logout";
            this.Logout.Name = "Logout";
            this.Logout.ReadOnly = true;
            // 
            // Data_used
            // 
            this.Data_used.HeaderText = "Data Used";
            this.Data_used.Name = "Data_used";
            this.Data_used.ReadOnly = true;
            // 
            // CompleteSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 462);
            this.Controls.Add(this.tot_table);
            this.Controls.Add(this.start);
            this.Name = "CompleteSession";
            this.Text = "CompleteSession";
            ((System.ComponentModel.ISupportInitialize)(this.tot_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataGridView tot_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_used;
    }
}