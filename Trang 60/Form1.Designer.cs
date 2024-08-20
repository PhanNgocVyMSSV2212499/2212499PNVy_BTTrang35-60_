namespace Trang_60
{
    partial class DemoCheck
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
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "CC và MT LT 1",
            "Cơ sở dữ liệu",
            "Tiếng Anh 2",
            "Quảng trị Mạng",
            "Photoshop",
            "Đồ ăn",
            "Tin học Cơ sở"});
            this.clbMonHoc.Location = new System.Drawing.Point(29, 37);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(237, 94);
            this.clbMonHoc.TabIndex = 0;
            this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // DemoCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 190);
            this.Controls.Add(this.clbMonHoc);
            this.Name = "DemoCheck";
            this.Text = "Demo CheckListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMonHoc;
    }
}

