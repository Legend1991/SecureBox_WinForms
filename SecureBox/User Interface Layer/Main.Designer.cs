namespace SecureBox.UIL
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addDrive = new System.Windows.Forms.ToolStripButton();
            this.removeDrive = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mountDrive = new System.Windows.Forms.ToolStripButton();
            this.unmountDrive = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changePassword = new System.Windows.Forms.ToolStripButton();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.drivesList = new System.Windows.Forms.DataGridView();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuItemRecover = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mountedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rootDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivesList)).BeginInit();
            this.trayMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDrive,
            this.removeDrive,
            this.toolStripSeparator1,
            this.mountDrive,
            this.unmountDrive,
            this.toolStripSeparator2,
            this.changePassword,
            this.aboutButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(534, 77);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // addDrive
            // 
            this.addDrive.Image = ((System.Drawing.Image)(resources.GetObject("addDrive.Image")));
            this.addDrive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDrive.Margin = new System.Windows.Forms.Padding(5);
            this.addDrive.Name = "addDrive";
            this.addDrive.Size = new System.Drawing.Size(52, 67);
            this.addDrive.Text = "Add";
            this.addDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addDrive.Click += new System.EventHandler(this.addDrive_Click);
            // 
            // removeDrive
            // 
            this.removeDrive.Image = ((System.Drawing.Image)(resources.GetObject("removeDrive.Image")));
            this.removeDrive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeDrive.Margin = new System.Windows.Forms.Padding(5);
            this.removeDrive.Name = "removeDrive";
            this.removeDrive.Size = new System.Drawing.Size(54, 67);
            this.removeDrive.Text = "Remove";
            this.removeDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removeDrive.Click += new System.EventHandler(this.removeDrive_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 77);
            // 
            // mountDrive
            // 
            this.mountDrive.Image = ((System.Drawing.Image)(resources.GetObject("mountDrive.Image")));
            this.mountDrive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mountDrive.Margin = new System.Windows.Forms.Padding(5);
            this.mountDrive.Name = "mountDrive";
            this.mountDrive.Size = new System.Drawing.Size(52, 67);
            this.mountDrive.Text = "Mount";
            this.mountDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mountDrive.Click += new System.EventHandler(this.mountDrive_Click);
            // 
            // unmountDrive
            // 
            this.unmountDrive.Image = ((System.Drawing.Image)(resources.GetObject("unmountDrive.Image")));
            this.unmountDrive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unmountDrive.Margin = new System.Windows.Forms.Padding(5);
            this.unmountDrive.Name = "unmountDrive";
            this.unmountDrive.Size = new System.Drawing.Size(62, 67);
            this.unmountDrive.Text = "Unmount";
            this.unmountDrive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.unmountDrive.Click += new System.EventHandler(this.unmountDrive_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 77);
            // 
            // changePassword
            // 
            this.changePassword.Image = ((System.Drawing.Image)(resources.GetObject("changePassword.Image")));
            this.changePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changePassword.Margin = new System.Windows.Forms.Padding(5);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(105, 67);
            this.changePassword.Text = "Change Password";
            this.changePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Margin = new System.Windows.Forms.Padding(5);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 67);
            this.aboutButton.Text = "About";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // drivesList
            // 
            this.drivesList.AllowUserToAddRows = false;
            this.drivesList.AllowUserToDeleteRows = false;
            this.drivesList.AllowUserToResizeColumns = false;
            this.drivesList.AllowUserToResizeRows = false;
            this.drivesList.AutoGenerateColumns = false;
            this.drivesList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.drivesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drivesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.drivesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.drivesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drivesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labelDataGridViewTextBoxColumn,
            this.letterDataGridViewTextBoxColumn,
            this.mountedDataGridViewCheckBoxColumn,
            this.rootDataGridViewTextBoxColumn});
            this.drivesList.DataSource = this.driveInfoBindingSource;
            this.drivesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drivesList.GridColor = System.Drawing.SystemColors.Window;
            this.drivesList.Location = new System.Drawing.Point(0, 77);
            this.drivesList.Margin = new System.Windows.Forms.Padding(0);
            this.drivesList.MultiSelect = false;
            this.drivesList.Name = "drivesList";
            this.drivesList.ReadOnly = true;
            this.drivesList.RowHeadersVisible = false;
            this.drivesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.drivesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drivesList.ShowCellErrors = false;
            this.drivesList.ShowCellToolTips = false;
            this.drivesList.ShowEditingIcon = false;
            this.drivesList.ShowRowErrors = false;
            this.drivesList.Size = new System.Drawing.Size(534, 285);
            this.drivesList.TabIndex = 2;
            this.drivesList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.drivesList_RowEnter);
            this.drivesList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.drivesList_RowsAdded);
            this.drivesList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.drivesList_RowsRemoved);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SecureBox";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuItemRecover,
            this.trayMenuItemExit});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(161, 48);
            // 
            // trayMenuItemRecover
            // 
            this.trayMenuItemRecover.Name = "trayMenuItemRecover";
            this.trayMenuItemRecover.Size = new System.Drawing.Size(160, 22);
            this.trayMenuItemRecover.Text = "Show SecureBox";
            this.trayMenuItemRecover.Click += new System.EventHandler(this.trayMenuItemRecover_Click);
            // 
            // trayMenuItemExit
            // 
            this.trayMenuItemExit.Name = "trayMenuItemExit";
            this.trayMenuItemExit.Size = new System.Drawing.Size(160, 22);
            this.trayMenuItemExit.Text = "Exit";
            this.trayMenuItemExit.Click += new System.EventHandler(this.trayMenuItemExit_Click);
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "Label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "Label";
            this.labelDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            this.labelDataGridViewTextBoxColumn.ReadOnly = true;
            this.labelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // letterDataGridViewTextBoxColumn
            // 
            this.letterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.letterDataGridViewTextBoxColumn.DataPropertyName = "Letter";
            this.letterDataGridViewTextBoxColumn.HeaderText = "Letter";
            this.letterDataGridViewTextBoxColumn.MinimumWidth = 59;
            this.letterDataGridViewTextBoxColumn.Name = "letterDataGridViewTextBoxColumn";
            this.letterDataGridViewTextBoxColumn.ReadOnly = true;
            this.letterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.letterDataGridViewTextBoxColumn.Width = 59;
            // 
            // mountedDataGridViewCheckBoxColumn
            // 
            this.mountedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mountedDataGridViewCheckBoxColumn.DataPropertyName = "Mounted";
            this.mountedDataGridViewCheckBoxColumn.HeaderText = "Mounted";
            this.mountedDataGridViewCheckBoxColumn.MinimumWidth = 55;
            this.mountedDataGridViewCheckBoxColumn.Name = "mountedDataGridViewCheckBoxColumn";
            this.mountedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.mountedDataGridViewCheckBoxColumn.Width = 55;
            // 
            // rootDataGridViewTextBoxColumn
            // 
            this.rootDataGridViewTextBoxColumn.DataPropertyName = "Root";
            this.rootDataGridViewTextBoxColumn.HeaderText = "Root";
            this.rootDataGridViewTextBoxColumn.MinimumWidth = 318;
            this.rootDataGridViewTextBoxColumn.Name = "rootDataGridViewTextBoxColumn";
            this.rootDataGridViewTextBoxColumn.ReadOnly = true;
            this.rootDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rootDataGridViewTextBoxColumn.Width = 318;
            // 
            // driveInfoBindingSource
            // 
            this.driveInfoBindingSource.DataSource = typeof(SecureBox.BL.DriveInfo);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.drivesList);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecureBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivesList)).EndInit();
            this.trayMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driveInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addDrive;
        private System.Windows.Forms.ToolStripButton removeDrive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mountDrive;
        private System.Windows.Forms.ToolStripButton unmountDrive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton changePassword;
        private System.Windows.Forms.DataGridView drivesList;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem trayMenuItemExit;
        private System.Windows.Forms.BindingSource driveInfoBindingSource;
        private System.Windows.Forms.ToolStripButton aboutButton;
        private System.Windows.Forms.ToolStripMenuItem trayMenuItemRecover;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn letterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mountedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rootDataGridViewTextBoxColumn;
    }
}