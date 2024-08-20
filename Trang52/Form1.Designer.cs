namespace Trang52
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
            this.lbDanhsach = new System.Windows.Forms.ListBox();
            this.lbDanhsachChon = new System.Windows.Forms.ListBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.FormattingEnabled = true;
            this.lbDanhsach.Items.AddRange(new object[] {
            "Phan Ngọc Vỹ",
            "Nguyễn Tiến Đạt",
            "Đoàn Minh Đức",
            "Nguyễn Thùy Dương"});
            this.lbDanhsach.Location = new System.Drawing.Point(12, 38);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsach.Size = new System.Drawing.Size(285, 368);
            this.lbDanhsach.TabIndex = 0;
            // 
            // lbDanhsachChon
            // 
            this.lbDanhsachChon.FormattingEnabled = true;
            this.lbDanhsachChon.Items.AddRange(new object[] {
            "NakCafRot"});
            this.lbDanhsachChon.Location = new System.Drawing.Point(455, 38);
            this.lbDanhsachChon.Name = "lbDanhsachChon";
            this.lbDanhsachChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsachChon.Size = new System.Drawing.Size(311, 368);
            this.lbDanhsachChon.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Blue;
            this.lb1.Location = new System.Drawing.Point(12, 17);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(199, 20);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Danh sách sinh viên lớp";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Blue;
            this.lb2.Location = new System.Drawing.Point(451, 17);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(314, 20);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(333, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Chọn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(334, 303);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 42);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbDanhsachChon);
            this.Controls.Add(this.lbDanhsach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhsach;
        private System.Windows.Forms.ListBox lbDanhsachChon;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
    }
}

