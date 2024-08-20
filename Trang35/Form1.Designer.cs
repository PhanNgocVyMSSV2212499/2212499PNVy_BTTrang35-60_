namespace Deadline
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
            this.txtDiachi = new System.Windows.Forms.Label();
            this.txtTWEB = new System.Windows.Forms.Label();
            this.llbDiaChi = new System.Windows.Forms.LinkLabel();
            this.llbWEB = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtDiachi
            // 
            this.txtDiachi.AutoSize = true;
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.ForeColor = System.Drawing.Color.Maroon;
            this.txtDiachi.Location = new System.Drawing.Point(160, 88);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(122, 20);
            this.txtDiachi.TabIndex = 0;
            this.txtDiachi.Text = "Địa chỉ liên hệ";
            this.txtDiachi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTWEB
            // 
            this.txtTWEB.AutoSize = true;
            this.txtTWEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTWEB.ForeColor = System.Drawing.Color.Maroon;
            this.txtTWEB.Location = new System.Drawing.Point(160, 173);
            this.txtTWEB.Name = "txtTWEB";
            this.txtTWEB.Size = new System.Drawing.Size(92, 20);
            this.txtTWEB.TabIndex = 1;
            this.txtTWEB.Text = "Trang web";
            // 
            // llbDiaChi
            // 
            this.llbDiaChi.AutoSize = true;
            this.llbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbDiaChi.Location = new System.Drawing.Point(306, 88);
            this.llbDiaChi.Name = "llbDiaChi";
            this.llbDiaChi.Size = new System.Drawing.Size(114, 16);
            this.llbDiaChi.TabIndex = 2;
            this.llbDiaChi.TabStop = true;
            this.llbDiaChi.Text = "ctk31@gmail.com";
            this.llbDiaChi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDiaChi_LinkClicked);
            // 
            // llbWEB
            // 
            this.llbWEB.AutoSize = true;
            this.llbWEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbWEB.Location = new System.Drawing.Point(306, 173);
            this.llbWEB.Name = "llbWEB";
            this.llbWEB.Size = new System.Drawing.Size(99, 16);
            this.llbWEB.TabIndex = 3;
            this.llbWEB.TabStop = true;
            this.llbWEB.Text = "www.cnttk31.net";
            this.llbWEB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbWEB_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llbWEB);
            this.Controls.Add(this.llbDiaChi);
            this.Controls.Add(this.txtTWEB);
            this.Controls.Add(this.txtDiachi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDiachi;
        private System.Windows.Forms.Label txtTWEB;
        private System.Windows.Forms.LinkLabel llbDiaChi;
        private System.Windows.Forms.LinkLabel llbWEB;
    }
}

