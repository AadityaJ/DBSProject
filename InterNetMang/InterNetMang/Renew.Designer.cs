namespace InterNetMang
{
    partial class Renew
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sr = new System.Windows.Forms.Button();
            this.renew_table = new System.Windows.Forms.DataGridView();
            this.r_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_id_renewal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.renew_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Internet Management Portal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(288, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "L-ION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Amount";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(621, 379);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(459, 137);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 14;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // sr
            // 
            this.sr.Location = new System.Drawing.Point(79, 171);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(110, 23);
            this.sr.TabIndex = 16;
            this.sr.Text = "Show Reciepts";
            this.sr.UseVisualStyleBackColor = true;
            this.sr.Click += new System.EventHandler(this.sr_Click);
            // 
            // renew_table
            // 
            this.renew_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.renew_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.r_id,
            this.a_id_renewal,
            this.Amount});
            this.renew_table.Location = new System.Drawing.Point(79, 214);
            this.renew_table.Name = "renew_table";
            this.renew_table.Size = new System.Drawing.Size(344, 150);
            this.renew_table.TabIndex = 17;
            // 
            // r_id
            // 
            this.r_id.HeaderText = "Renewal ID";
            this.r_id.Name = "r_id";
            this.r_id.ReadOnly = true;
            // 
            // a_id_renewal
            // 
            this.a_id_renewal.HeaderText = "Admin ID";
            this.a_id_renewal.Name = "a_id_renewal";
            this.a_id_renewal.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "amt";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Renew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 414);
            this.Controls.Add(this.renew_table);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Renew";
            this.Text = "Renew";
            ((System.ComponentModel.ISupportInitialize)(this.renew_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sr;
        private System.Windows.Forms.DataGridView renew_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_id_renewal;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_id;
    }
}