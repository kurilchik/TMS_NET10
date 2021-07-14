using System;
using System.Windows.Forms;
using DriverLicense.BusinessLogicLayer;

namespace DriverLicense.PresentationLayer
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void _bCategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_bCategoryCheckBox.Checked)
            {
                _aCategoryCheckBox.Checked = true;
            }
        }

        private void _signUpButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.FirstName = _firstNameTextBox.Text;
            user.LastName = _lastNameTextBox.Text;
            user.MiddleName = _middelNameTextBox.Text;

            Category category = new Category();

            if (_aCategoryCheckBox.Checked)
            {
                category |= Category.A;
            }
            if (_bCategoryCheckBox.Checked)
            {
                category |= Category.B;
            }
            if (_cCategoryCheckBox.Checked)
            {
                category |= Category.C;
            }
            if (_dCategoryCheckBox.Checked)
            {
                category |= Category.D;
            }
            if (_eCategoryCheckBox.Checked)
            {
                category |= Category.E;
            }

            user.DriverLicense = category;

            MessageBox.Show("Excellent!", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
