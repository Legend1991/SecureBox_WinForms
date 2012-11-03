using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SecureBox.BL;

namespace SecureBox.UIL
{
    public partial class PasswordChange : Form
    {
        private const string errorMatch = "This field must match New Password field!";
        private const string errorWrongPass = "Entered password is invalid!";
        private const string errorEmpty = "This field can't be empty!";
        private const int empty = 0;
        private SecureBox.BL.SecureBox secBox;
        private DriveInfo drive;

        public PasswordChange(SecureBox.BL.SecureBox secBox, DriveInfo drive)
        {
            InitializeComponent();
            this.secBox = secBox;
            this.drive = drive;
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                textBoxCurrPass.UseSystemPasswordChar = false;
                textBoxNewPass.UseSystemPasswordChar = false;
                textBoxConf.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxCurrPass.UseSystemPasswordChar = true;
                textBoxNewPass.UseSystemPasswordChar = true;
                textBoxConf.UseSystemPasswordChar = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool error = false;

            textBoxNewPass.Text = textBoxNewPass.Text.TrimEnd();
            textBoxNewPass.Text = textBoxNewPass.Text.TrimStart();
            textBoxCurrPass.Text = textBoxCurrPass.Text.TrimEnd();
            textBoxCurrPass.Text = textBoxCurrPass.Text.TrimStart();
            textBoxConf.Text = textBoxConf.Text.TrimEnd();
            textBoxConf.Text = textBoxConf.Text.TrimStart();

            if (textBoxNewPass.Text != textBoxConf.Text)
            {
                errorProvider.SetError(textBoxConf, errorMatch);
                error = true;
            }

            if (textBoxNewPass.Text.Length == empty)
            {
                errorProvider.SetError(textBoxNewPass, errorEmpty);
                error = true;
            }

            bool success = secBox.ChangePassword(drive, textBoxCurrPass.Text,
                textBoxNewPass.Text);

            if (!success)
            {
                errorProvider.SetError(textBoxCurrPass, errorWrongPass);
                error = true;
            }

            if (error)
            {
                return;
            }

            this.Close();
        }

        private void textBoxConf_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxConf.Text.Length == textBoxNewPass.Text.Length
                && textBoxConf.Text != textBoxNewPass.Text) ||
                textBoxConf.Text.Length > textBoxNewPass.Text.Length)
            {
                errorProvider.SetError(textBoxConf, errorMatch);
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void textBoxCurrPass_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}
