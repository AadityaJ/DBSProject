namespace InterNetMang
{
    partial class Admin_Renew
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
            this.st = new System.Windows.Forms.Button();
            this.interleaved = new System.Windows.Forms.DataGridView();
            this.renew_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.r_id = new System.Windows.Forms.TextBox();
            this.rnw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.interleaved)).BeginInit();
            this.SuspendLayout();
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(80, 36);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(75, 23);
            this.st.TabIndex = 0;
            this.st.Text = "Show Table";
            this.st.UseVisualStyleBackColor = true;
            this.st.Click += new System.EventHandler(this.st_Click);
            // 
            // interleaved
            // 
            this.interleaved.AllowUserToAddRows = false;
            this.interleaved.AllowUserToDeleteRows = false;
            this.interleaved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interleaved.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.renew_id,
            this.u_id,
            this.amt});
            this.interleaved.Location = new System.Drawing.Point(80, 79);
            this.interleaved.Name = "interleaved";
            this.interleaved.ReadOnly = true;
            this.interleaved.Size = new System.Drawing.Size(343, 150);
            this.interleaved.TabIndex = 1;
            // 
            // renew_id
            // 
            this.renew_id.HeaderText = "Renew ID";
            this.renew_id.Name = "renew_id";
            this.renew_id.ReadOnly = true;
            // 
            // u_id
            // 
            this.u_id.HeaderText = "User ID";
            this.u_id.Name = "u_id";
            this.u_id.ReadOnly = true;
            // 
            // amt
            // 
            this.amt.HeaderText = "Amount";
            this.amt.Name = "amt";
            this.amt.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(80, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew User ID";
            // 
            // r_id
            // 
            this.r_id.Location = new System.Drawing.Point(203, 281);
            this.r_id.Name = "r_id";
            this.r_id.Size = new System.Drawing.Size(100, 20);
            this.r_id.TabIndex = 2;
            // 
            // rnw
            // 
            this.rnw.Location = new System.Drawing.Point(377, 277);
            this.rnw.Name = "rnw";
            this.rnw.Size = new System.Drawing.Size(75, 23);
            this.rnw.TabIndex = 3;
            this.rnw.Text = "Renew";
            this.rnw.UseVisualStyleBackColor = true;
            this.rnw.Click += new System.EventHandler(this.rnw_Click);
            // 
            // Admin_Renew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 364);
            this.Controls.Add(this.rnw);
            this.Controls.Add(this.r_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interleaved);
            this.Controls.Add(this.st);
            this.Name = "Admin_Renew";
            this.Text = "Admin_Renew";
            this.Load += new System.EventHandler(this.Admin_Renew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interleaved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button st;
        private System.Windows.Forms.DataGridView interleaved;
        private System.Windows.Forms.DataGridViewTextBoxColumn renew_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox r_id;
        private System.Windows.Forms.Button rnw;
    }
}