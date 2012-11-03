using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SecureBox.UIL
{
    public partial class AddDrive : Form
    {
        private const string errorMatch = "This field must match Password field!";
        private const string errorEmpty = "This field can't be empty!";
        private const string errorPath = "Please enter a valid location!";
        private const string defaultLabel = "SecureBox";
        private const int firstLetter = 0;
        private const int empty = 0;
        private SecureBox.BL.SecureBox secBox;

        public AddDrive(SecureBox.BL.SecureBox secBox)
        {
            InitializeComponent();
            this.secBox = secBox;
            comboBoxLetters.DataSource = new BindingList<char>(secBox.GetFreeDriveLetters());
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                textBoxPass.UseSystemPasswordChar = false;
                textBoxConf.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                textBoxConf.UseSystemPasswordChar = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            textBoxPass.Text = textBoxPass.Text.TrimEnd();
            textBoxPass.Text = textBoxPass.Text.TrimStart();
            textBoxConf.Text = textBoxConf.Text.TrimEnd();
            textBoxConf.Text = textBoxConf.Text.TrimStart();
            textBoxLabel.Text = textBoxLabel.Text.TrimEnd();
            textBoxLabel.Text = textBoxLabel.Text.TrimStart();

            if (CheckFields() == false)
            {
                return;
            }

            char letter = (char)comboBoxLetters.SelectedItem;
            string label = textBoxLabel.Text;
            string root = textBoxFolder.Text;
            string password = textBoxPass.Text;

            SecureBox.BL.DriveInfo drive = new SecureBox.BL.DriveInfo(letter, label, root, true);

            secBox.AddDrive(drive, password);

            this.Close();
        }

        private void textBoxConf_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxConf.Text.Length == textBoxPass.Text.Length
                && textBoxConf.Text != textBoxPass.Text) ||
                textBoxConf.Text.Length > textBoxPass.Text.Length)
            {
                errorProvider.SetError(textBoxConf, errorMatch);
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void textBoxLabel_Leave(object sender, EventArgs e)
        {
            string driveLabel = textBoxLabel.Text.TrimStart();
            driveLabel = textBoxLabel.Text.TrimEnd();
            if (driveLabel.Length == empty)
            {
                textBoxLabel.Text = defaultLabel;
            }
        }

        private bool CheckFields()
        {
            bool result = true;

            if (!Directory.Exists(textBoxFolder.Text))
            {
                errorProvider.SetError(buttonBrowse, errorPath);
                result = false;
            }

            if (textBoxPass.Text != textBoxConf.Text)
            {
                errorProvider.SetError(textBoxConf, errorMatch);
                result = false;
            }

            if (textBoxPass.Text.Length == empty)
            {
                errorProvider.SetError(textBoxPass, errorEmpty);
                result = false;
            }

            return result;
        }
    }
}
