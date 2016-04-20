namespace InterNetMang
{
    partial class Ban
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.u_id = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(104, 187);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Ban";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // u_id
            // 
            this.u_id.Location = new System.Drawing.Point(93, 31);
            this.u_id.Name = "u_id";
            this.u_id.Size = new System.Drawing.Size(230, 20);
            this.u_id.TabIndex = 4;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(93, 71);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(111, 20);
            this.from.TabIndex = 5;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(93, 106);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(111, 20);
            this.to.TabIndex = 6;
            // 
            // Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 298);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.u_id);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ban";
            this.Text = "Ban";
            this.Load += new System.EventHandler(this.Ban_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox u_id;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
    }
}