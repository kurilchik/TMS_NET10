namespace RegistrationWindowPL
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this._emailAddressLabel = new System.Windows.Forms.Label();
            this._emailAddressTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._dateLabel = new System.Windows.Forms.Label();
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._genderLabel = new System.Windows.Forms.Label();
            this._maleCheckBox = new System.Windows.Forms.CheckBox();
            this._femaleCheckBox = new System.Windows.Forms.CheckBox();
            this._avatarLabel = new System.Windows.Forms.Label();
            this._avatarPictureBox = new System.Windows.Forms.PictureBox();
            this._avatarButton = new System.Windows.Forms.Button();
            this._singUpButton = new System.Windows.Forms.Button();
            this._notificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _emailAddressLabel
            // 
            this._emailAddressLabel.AutoSize = true;
            this._emailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._emailAddressLabel.Location = new System.Drawing.Point(12, 26);
            this._emailAddressLabel.Name = "_emailAddressLabel";
            this._emailAddressLabel.Size = new System.Drawing.Size(177, 31);
            this._emailAddressLabel.TabIndex = 0;
            this._emailAddressLabel.Text = "Email address: *";
            // 
            // _emailAddressTextBox
            // 
            this._emailAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._emailAddressTextBox.Location = new System.Drawing.Point(196, 23);
            this._emailAddressTextBox.Name = "_emailAddressTextBox";
            this._emailAddressTextBox.Size = new System.Drawing.Size(388, 38);
            this._emailAddressTextBox.TabIndex = 1;
            this._emailAddressTextBox.Leave += new System.EventHandler(this._emailAddressTextBox_Leave);
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._passwordTextBox.Location = new System.Drawing.Point(196, 91);
            this._passwordTextBox.MaxLength = 10;
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(388, 38);
            this._passwordTextBox.TabIndex = 3;
            this._passwordTextBox.TextChanged += new System.EventHandler(this._passwordTextBox_TextChanged);
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._passwordLabel.Location = new System.Drawing.Point(12, 94);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(131, 31);
            this._passwordLabel.TabIndex = 2;
            this._passwordLabel.Text = "Password: *";
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._nameTextBox.Location = new System.Drawing.Point(196, 162);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(388, 38);
            this._nameTextBox.TabIndex = 5;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._nameLabel.Location = new System.Drawing.Point(12, 165);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(80, 31);
            this._nameLabel.TabIndex = 4;
            this._nameLabel.Text = "Name:";
            // 
            // _dateLabel
            // 
            this._dateLabel.AutoSize = true;
            this._dateLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._dateLabel.Location = new System.Drawing.Point(12, 233);
            this._dateLabel.Name = "_dateLabel";
            this._dateLabel.Size = new System.Drawing.Size(148, 31);
            this._dateLabel.TabIndex = 6;
            this._dateLabel.Text = "Date of birth:";
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dateTimePicker.Location = new System.Drawing.Point(196, 229);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(202, 38);
            this._dateTimePicker.TabIndex = 7;
            // 
            // _genderLabel
            // 
            this._genderLabel.AutoSize = true;
            this._genderLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._genderLabel.Location = new System.Drawing.Point(12, 303);
            this._genderLabel.Name = "_genderLabel";
            this._genderLabel.Size = new System.Drawing.Size(94, 31);
            this._genderLabel.TabIndex = 8;
            this._genderLabel.Text = "Gender:";
            // 
            // _maleCheckBox
            // 
            this._maleCheckBox.AutoSize = true;
            this._maleCheckBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._maleCheckBox.Location = new System.Drawing.Point(196, 299);
            this._maleCheckBox.Name = "_maleCheckBox";
            this._maleCheckBox.Size = new System.Drawing.Size(87, 35);
            this._maleCheckBox.TabIndex = 9;
            this._maleCheckBox.Text = "Male";
            this._maleCheckBox.UseVisualStyleBackColor = true;
            this._maleCheckBox.CheckedChanged += new System.EventHandler(this._maleCheckBox_CheckedChanged);
            // 
            // _femaleCheckBox
            // 
            this._femaleCheckBox.AutoSize = true;
            this._femaleCheckBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._femaleCheckBox.Location = new System.Drawing.Point(289, 299);
            this._femaleCheckBox.Name = "_femaleCheckBox";
            this._femaleCheckBox.Size = new System.Drawing.Size(109, 35);
            this._femaleCheckBox.TabIndex = 10;
            this._femaleCheckBox.Text = "Female";
            this._femaleCheckBox.UseVisualStyleBackColor = true;
            this._femaleCheckBox.CheckedChanged += new System.EventHandler(this._femaleCheckBox_CheckedChanged);
            // 
            // _avatarLabel
            // 
            this._avatarLabel.AutoSize = true;
            this._avatarLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._avatarLabel.Location = new System.Drawing.Point(12, 368);
            this._avatarLabel.Name = "_avatarLabel";
            this._avatarLabel.Size = new System.Drawing.Size(85, 31);
            this._avatarLabel.TabIndex = 11;
            this._avatarLabel.Text = "Avatar:";
            // 
            // _avatarPictureBox
            // 
            this._avatarPictureBox.Location = new System.Drawing.Point(414, 229);
            this._avatarPictureBox.Name = "_avatarPictureBox";
            this._avatarPictureBox.Size = new System.Drawing.Size(170, 170);
            this._avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._avatarPictureBox.TabIndex = 12;
            this._avatarPictureBox.TabStop = false;
            // 
            // _avatarButton
            // 
            this._avatarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._avatarButton.Location = new System.Drawing.Point(196, 368);
            this._avatarButton.Name = "_avatarButton";
            this._avatarButton.Size = new System.Drawing.Size(94, 29);
            this._avatarButton.TabIndex = 13;
            this._avatarButton.Text = "Select";
            this._avatarButton.UseVisualStyleBackColor = true;
            this._avatarButton.Click += new System.EventHandler(this._avatarButton_Click);
            // 
            // _singUpButton
            // 
            this._singUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._singUpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._singUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._singUpButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._singUpButton.ForeColor = System.Drawing.Color.White;
            this._singUpButton.Location = new System.Drawing.Point(0, 464);
            this._singUpButton.Name = "_singUpButton";
            this._singUpButton.Size = new System.Drawing.Size(607, 60);
            this._singUpButton.TabIndex = 14;
            this._singUpButton.Text = "SIGN UP";
            this._singUpButton.UseVisualStyleBackColor = false;
            this._singUpButton.Click += new System.EventHandler(this._singUpButton_Click);
            // 
            // _notificationLabel
            // 
            this._notificationLabel.AutoSize = true;
            this._notificationLabel.Location = new System.Drawing.Point(34, 421);
            this._notificationLabel.Name = "_notificationLabel";
            this._notificationLabel.Size = new System.Drawing.Size(109, 20);
            this._notificationLabel.TabIndex = 15;
            this._notificationLabel.Text = "* required field";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 524);
            this.Controls.Add(this._notificationLabel);
            this.Controls.Add(this._singUpButton);
            this.Controls.Add(this._avatarButton);
            this.Controls.Add(this._avatarPictureBox);
            this.Controls.Add(this._avatarLabel);
            this.Controls.Add(this._femaleCheckBox);
            this.Controls.Add(this._maleCheckBox);
            this.Controls.Add(this._genderLabel);
            this.Controls.Add(this._dateTimePicker);
            this.Controls.Add(this._dateLabel);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._emailAddressTextBox);
            this.Controls.Add(this._emailAddressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this._avatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _emailAddressLabel;
        private System.Windows.Forms.TextBox _emailAddressTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
        private System.Windows.Forms.Label _genderLabel;
        private System.Windows.Forms.CheckBox _maleCheckBox;
        private System.Windows.Forms.CheckBox _femaleCheckBox;
        private System.Windows.Forms.Label _avatarLabel;
        private System.Windows.Forms.PictureBox _avatarPictureBox;
        private System.Windows.Forms.Button _avatarButton;
        private System.Windows.Forms.Button _singUpButton;
        private System.Windows.Forms.Label _notificationLabel;
    }
}