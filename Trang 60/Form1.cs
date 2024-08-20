using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang_60
{
    public partial class DemoCheck : Form
    {
        public DemoCheck()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items=this.clbMonHoc.CheckedItems;
            string s = "";
            foreach (object ob in items)
            {
                s += ob.ToString() + ",";
            }
            MessageBox.Show("Danh Sach mon Hoc "+s);
        }
    }
}
