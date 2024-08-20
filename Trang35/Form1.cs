using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void llbDiaChi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=hello");
        }

        private void llbWEB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("http://www."))
                Process.Start(strURL); //Process.Start("IExplore", strURL)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:ctk31@gmail.com";
            this.llbDiaChi.Links.Add(0, strURL.Length, strURL);
            strURL = "http://www.cnttk31.net";
            this.llbWEB.Links.Add(0, strURL.Length, strURL);
        }
    }
}
