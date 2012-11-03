namespace SecureBox.UIL
{
    partial class AddDrive
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
            this.comboBoxLetters = new System.Windows.Forms.ComboBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelDrive = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.textBoxConf = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelConf = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.groupBoxSec = new System.Windows.Forms.GroupBox();
            this.groupBoxDrv = new System.Windows.Forms.GroupBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.labelDrv = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxSec.SuspendLayout();
            this.groupBoxDrv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLetters
            // 
            this.comboBoxLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLetters.FormattingEnabled = true;
            this.comboBoxLetters.Location = new System.Drawing.Point(248, 97);
            this.comboBoxLetters.Name = "comboBoxLetters";
            this.comboBoxLetters.Size = new System.Drawing.Size(57, 21);
            this.comboBoxLetters.TabIndex = 0;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(6, 25);
            this.labelFolder.Margin = new System.Windows.Forms.Padding(3);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(236, 13);
            this.labelFolder.TabIndex = 1;
            this.labelFolder.Text = "Choose the location of the new encrypted folder:";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(9, 44);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(233, 20);
            this.textBoxFolder.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(248, 42);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelDrive
            // 
            this.labelDrive.AutoSize = true;
            this.labelDrive.Location = new System.Drawing.Point(6, 100);
            this.labelDrive.Margin = new System.Windows.Forms.Padding(3);
            this.labelDrive.Name = "labelDrive";
            this.labelDrive.Size = new System.Drawing.Size(183, 13);
            this.labelDrive.TabIndex = 4;
            this.labelDrive.Text = "Choose the drive letter of SecureBox:";
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Location = new System.Drawing.Point(9, 125);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowPass.TabIndex = 11;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // textBoxConf
            // 
            this.textBoxConf.Location = new System.Drawing.Point(9, 93);
            this.textBoxConf.Name = "textBoxConf";
            this.textBoxConf.Size = new System.Drawing.Size(376, 20);
            this.textBoxConf.TabIndex = 10;
            this.textBoxConf.UseSystemPasswordChar = true;
            this.textBoxConf.TextChanged += new System.EventHandler(this.textBoxConf_TextChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(9, 41);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(376, 20);
            this.textBoxPass.TabIndex = 9;
            this.textBoxPass.UseSystemPasswordChar = true;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // labelConf
            // 
            this.labelConf.AutoSize = true;
            this.labelConf.Location = new System.Drawing.Point(6, 77);
            this.labelConf.Name = "labelConf";
            this.labelConf.Size = new System.Drawing.Size(45, 13);
            this.labelConf.TabIndex = 8;
            this.labelConf.Text = "Confirm:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(6, 25);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(56, 13);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Password:";
            // 
            // groupBoxSec
            // 
            this.groupBoxSec.Controls.Add(this.labelPass);
            this.groupBoxSec.Controls.Add(this.checkBoxShowPass);
            this.groupBoxSec.Controls.Add(this.labelConf);
            this.groupBoxSec.Controls.Add(this.textBoxConf);
            this.groupBoxSec.Controls.Add(this.textBoxPass);
            this.groupBoxSec.Location = new System.Drawing.Point(12, 151);
            this.groupBoxSec.Name = "groupBoxSec";
            this.groupBoxSec.Size = new System.Drawing.Size(408, 152);
            this.groupBoxSec.TabIndex = 12;
            this.groupBoxSec.TabStop = false;
            this.groupBoxSec.Text = "Security Settings";
            // 
            // groupBoxDrv
            // 
            this.groupBoxDrv.Controls.Add(this.textBoxLabel);
            this.groupBoxDrv.Controls.Add(this.labelDrv);
            this.groupBoxDrv.Controls.Add(this.labelFolder);
            this.groupBoxDrv.Controls.Add(this.comboBoxLetters);
            this.groupBoxDrv.Controls.Add(this.labelDrive);
            this.groupBoxDrv.Controls.Add(this.textBoxFolder);
            this.groupBoxDrv.Controls.Add(this.buttonBrowse);
            this.groupBoxDrv.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDrv.Name = "groupBoxDrv";
            this.groupBoxDrv.Size = new System.Drawing.Size(408, 133);
            this.groupBoxDrv.TabIndex = 13;
            this.groupBoxDrv.TabStop = false;
            this.groupBoxDrv.Text = "Drive Settings";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(248, 71);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(137, 20);
            this.textBoxLabel.TabIndex = 6;
            this.textBoxLabel.Text = "SecureBox";
            this.textBoxLabel.Leave += new System.EventHandler(this.textBoxLabel_Leave);
            // 
            // labelDrv
            // 
            this.labelDrv.AutoSize = true;
            this.labelDrv.Location = new System.Drawing.Point(6, 74);
            this.labelDrv.Name = "labelDrv";
            this.labelDrv.Size = new System.Drawing.Size(150, 13);
            this.labelDrv.TabIndex = 5;
            this.labelDrv.Text = "Label for the SecureBox drive:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(345, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(264, 309);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Choose the location of the new encrypted folder";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // AddDrive
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(431, 347);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxDrv);
            this.Controls.Add(this.groupBoxSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDrive";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drive Adding";
            this.groupBoxSec.ResumeLayout(false);
            this.groupBoxSec.PerformLayout();
            this.groupBoxDrv.ResumeLayout(false);
            this.groupBoxDrv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLetters;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelDrive;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.TextBox textBoxConf;
        public System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelConf;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.GroupBox groupBoxSec;
        private System.Windows.Forms.GroupBox groupBoxDrv;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label labelDrv;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}