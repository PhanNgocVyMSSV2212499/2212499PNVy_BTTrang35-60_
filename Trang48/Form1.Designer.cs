namespace Trang48
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
            this.ccbNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ccbNgoaiNgu
            // 
            this.ccbNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbNgoaiNgu.FormattingEnabled = true;
            this.ccbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật"});
            this.ccbNgoaiNgu.Location = new System.Drawing.Point(131, 58);
            this.ccbNgoaiNgu.Name = "ccbNgoaiNgu";
            this.ccbNgoaiNgu.Size = new System.Drawing.Size(206, 21);
            this.ccbNgoaiNgu.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(41, 61);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(84, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Chọn ngoại Ngữ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 256);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.ccbNgoaiNgu);
            this.Name = "Form1";
            this.Text = "DemoComBoBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ccbNgoaiNgu;
        private System.Windows.Forms.Label lb1;
    }
}

