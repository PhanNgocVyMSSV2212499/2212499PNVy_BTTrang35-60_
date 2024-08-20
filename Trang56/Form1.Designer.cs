namespace Trang56
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
            this.grbGT = new System.Windows.Forms.GroupBox();
            this.rbNU = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.grbGT.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGT
            // 
            this.grbGT.Controls.Add(this.rbNam);
            this.grbGT.Controls.Add(this.rbNU);
            this.grbGT.Location = new System.Drawing.Point(35, 23);
            this.grbGT.Name = "grbGT";
            this.grbGT.Size = new System.Drawing.Size(291, 207);
            this.grbGT.TabIndex = 0;
            this.grbGT.TabStop = false;
            this.grbGT.Text = "Giới tính";
            // 
            // rbNU
            // 
            this.rbNU.AutoSize = true;
            this.rbNU.Location = new System.Drawing.Point(22, 63);
            this.rbNU.Name = "rbNU";
            this.rbNU.Size = new System.Drawing.Size(39, 17);
            this.rbNU.TabIndex = 2;
            this.rbNU.TabStop = true;
            this.rbNU.Text = "Nữ";
            this.rbNU.UseVisualStyleBackColor = true;
            this.rbNU.CheckedChanged += new System.EventHandler(this.rbNU_CheckedChanged);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(22, 40);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 3;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 262);
            this.Controls.Add(this.grbGT);
            this.Name = "Form1";
            this.Text = "Demo RadioButton";
            this.grbGT.ResumeLayout(false);
            this.grbGT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGT;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNU;
    }
}

