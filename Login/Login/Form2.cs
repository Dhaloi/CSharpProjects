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

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string user = Environment.UserName;
            label1.Text = user;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start("taskkill", "/F /IM Login.exe");
        }
    }
}
