using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW14._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += MyMethod;
        }

        private void MyMethod(object sender, EventArgs e)
        {
            MessageBox.Show("Excellent!");
        }
    }
}
