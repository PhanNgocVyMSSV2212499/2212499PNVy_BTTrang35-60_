using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNam.Checked)
            {
                MessageBox.Show("Giới Tính Của BẠn Là:" + rbNam.Text);
            
            }
        }

        private void rbNU_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNU.Checked)
            {
                MessageBox.Show("Giới Tính Của BẠn Là:" + rbNU.Text);

            }
        }
    }
}
