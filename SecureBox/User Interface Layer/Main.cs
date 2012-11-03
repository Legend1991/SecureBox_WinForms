using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SecureBox.BL;

namespace SecureBox.UIL
{
    public partial class MainWindow : Form
    {
        private SecureBox.BL.SecureBox secBox;
        private const int labelCellNum = 0;
        private const int letterCellNum = 1;
        private const int mountedCellNum = 2;
        private const int rootCellNum = 3;
        private const int firstRow = 0;
        private const int empty = 0;

        public MainWindow(SecureBox.BL.SecureBox secBox)
        {
            InitializeComponent();
            Application.ApplicationExit += new System.EventHandler(this.applicationExit);
            this.secBox = secBox;
            UpdateList();
            if (drivesList.SelectedRows.Count == empty)
            {
                mountDrive.Enabled = false;
                unmountDrive.Enabled = false;
                removeDrive.Enabled = false;
                changePassword.Enabled = false;
            }
        }

        private void applicationExit(object sender, EventArgs e)
        {
            secBox.UnmountAllDrives();
        }

        private void addDrive_Click(object sender, EventArgs e)
        {
            AddDrive addDrv = new AddDrive(secBox);
            addDrv.ShowDialog();
            UpdateList();
        }

        private void removeDrive_Click(object sender, EventArgs e)
        {
            DriveInfo drive = GetSelectedDrive();
            secBox.RemoveDrive(drive);
            UpdateList();
        }

        private void trayMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mountDrive_Click(object sender, EventArgs e)
        {
            DriveInfo drive = GetSelectedDrive();
            secBox.MountDrive(drive);
            UpdateList();
        }

        private DriveInfo GetSelectedDrive()
        {
            char letter = (char)drivesList.SelectedRows[firstRow].Cells[letterCellNum].Value;
            string label = (string)drivesList.SelectedRows[firstRow].Cells[labelCellNum].Value;
            bool mounted = (bool)drivesList.SelectedRows[firstRow].Cells[mountedCellNum].Value;
            string root = (string)drivesList.SelectedRows[firstRow].Cells[rootCellNum].Value;
            return new DriveInfo(letter, label, root, mounted);
        }

        private void unmountDrive_Click(object sender, EventArgs e)
        {
            DriveInfo drive = GetSelectedDrive();
            secBox.UnmountDrive(drive);
            UpdateList();
        }

        private void drivesList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (drivesList.SelectedRows.Count == empty)
            {
                mountDrive.Enabled = false;
                unmountDrive.Enabled = false;
                removeDrive.Enabled = false;
                changePassword.Enabled = false;
            }
        }

        private void drivesList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            mountDrive.Enabled = true;
            unmountDrive.Enabled = true;
            removeDrive.Enabled = true;
            changePassword.Enabled = true;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            DriveInfo drive = GetSelectedDrive();
            PasswordChange passChange = new PasswordChange(secBox, drive);
            passChange.ShowDialog();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            e.Cancel = true;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            recoverWin();
        }

        private void recoverWin()
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void trayMenuItemRecover_Click(object sender, EventArgs e)
        {
            recoverWin();
        }

        private void drivesList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SwitchUnMountEnable();
        }

        private void SwitchUnMountEnable()
        {
            if (drivesList.SelectedRows.Count != empty)
            {
                DriveInfo drive = GetSelectedDrive();
                if (drive.Mounted)
                {
                    mountDrive.Enabled = false;
                    unmountDrive.Enabled = true;
                }
                else
                {
                    mountDrive.Enabled = true;
                    unmountDrive.Enabled = false;
                }
            }
        }

        private void UpdateList()
        {
            driveInfoBindingSource.DataSource = new BindingList<DriveInfo>(secBox.DrivesList);
            drivesList.Update();
            SwitchUnMountEnable();
        }
    }
}
