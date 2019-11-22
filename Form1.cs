using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPIAwareTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DpiChanged += WhenDpiChanged;
            label3.Text = this.DeviceDpi + " DPI";
        }

        private void WhenDpiChanged(object sender, DpiChangedEventArgs e)
        {
            label3.Text = this.DeviceDpi + " DPI";
        }
    }
}
