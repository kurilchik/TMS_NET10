using System;
using System.Windows.Forms;

namespace EventWindowsForms
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();

            _buttonClick.Click += ClickMethod;
            _buttonEnter.Enter += EnterMethod;
            _buttonLeave.Leave += LeaveMethod;

        }

        private void ClickMethod(object sender, EventArgs e)
        {
            MessageBox.Show("Click!");
        }

        private void EnterMethod(object sender, EventArgs e)
        {
            MessageBox.Show("Enter!");
        }

        private void LeaveMethod(object sender, EventArgs e)
        {
            MessageBox.Show("Leave!");
        }
    }
}
