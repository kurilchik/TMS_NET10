using System;
using System.Drawing;
using RegistrationWindowDAL;
using RegistrationWindowBLL;
using System.Windows.Forms;

namespace RegistrationWindowPL
{
    public partial class SignUpForm : Form
    {
        private readonly User _user = new User();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void _emailAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (_emailAddressTextBox.Text.Trim() != string.Empty)
            {
                try
                {
                    var mailAddress = new System.Net.Mail.MailAddress(_emailAddressTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("E-mail address format is not correct.", "Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _emailAddressTextBox.Focus();
                }
            }
        }

        private void _passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_passwordTextBox.Text.Length == _passwordTextBox.MaxLength)
            {
                MessageBox.Show($"Max length of password: {_passwordTextBox.MaxLength}", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _avatarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Image Files(.bmp; .jpg; .gif; .png)|*.bmp;*.jpg;*.gif;*.png|All files|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _avatarPictureBox.Image = new Bitmap(openFile.FileName);
                    _user.AvatarPath = openFile.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("It is not possible to open the selected file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _maleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_maleCheckBox.Checked)
            {
                _femaleCheckBox.Checked = false;
                _user.Sex = Gender.Male;
            }
        }

        private void _femaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_femaleCheckBox.Checked)
            {
                _maleCheckBox.Checked = false;
                _user.Sex = Gender.Female;
            }
        }

        private void _singUpButton_Click(object sender, EventArgs e)
        {
            if (_emailAddressTextBox.Text == string.Empty)
            {
                MessageBox.Show("The \"Email Address\" field is empty!", "Email address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _emailAddressTextBox.Focus();
                return;
            }

            if (_passwordTextBox.Text == string.Empty)
            {
                MessageBox.Show("The \"Password\" field is empty!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _passwordTextBox.Focus();
                return;
            }

            _user.EmailAddress = _emailAddressTextBox.Text;
            _user.Password = _passwordTextBox.Text;
            _user.Name = _nameTextBox.Text;
            _user.DateOfBirth = _dateTimePicker.Value;

            UserRepository repository = new UserRepository();
            repository.AddUser(_user);

            MessageBox.Show($"{_user.Name}, congratulations!\nRegistration completed successfully!", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
