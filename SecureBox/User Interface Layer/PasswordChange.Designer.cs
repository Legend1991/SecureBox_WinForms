namespace SecureBox.UIL
{
    partial class PasswordChange
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
            this.labelCurrPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelConf = new System.Windows.Forms.Label();
            this.textBoxCurrPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxConf = new System.Windows.Forms.TextBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrPass
            // 
            this.labelCurrPass.AutoSize = true;
            this.labelCurrPass.Location = new System.Drawing.Point(12, 18);
            this.labelCurrPass.Name = "labelCurrPass";
            this.labelCurrPass.Size = new System.Drawing.Size(93, 13);
            this.labelCurrPass.TabIndex = 0;
            this.labelCurrPass.Text = "Current Password:";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Location = new System.Drawing.Point(12, 68);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(81, 13);
            this.labelNewPass.TabIndex = 1;
            this.labelNewPass.Text = "New Password:";
            // 
            // labelConf
            // 
            this.labelConf.AutoSize = true;
            this.labelConf.Location = new System.Drawing.Point(12, 120);
            this.labelConf.Name = "labelConf";
            this.labelConf.Size = new System.Drawing.Size(45, 13);
            this.labelConf.TabIndex = 2;
            this.labelConf.Text = "Confirm:";
            // 
            // textBoxCurrPass
            // 
            this.textBoxCurrPass.Location = new System.Drawing.Point(15, 34);
            this.textBoxCurrPass.Name = "textBoxCurrPass";
            this.textBoxCurrPass.Size = new System.Drawing.Size(291, 20);
            this.textBoxCurrPass.TabIndex = 3;
            this.textBoxCurrPass.UseSystemPasswordChar = true;
            this.textBoxCurrPass.TextChanged += new System.EventHandler(this.textBoxCurrPass_TextChanged);
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(15, 84);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(291, 20);
            this.textBoxNewPass.TabIndex = 4;
            this.textBoxNewPass.UseSystemPasswordChar = true;
            // 
            // textBoxConf
            // 
            this.textBoxConf.Location = new System.Drawing.Point(15, 136);
            this.textBoxConf.Name = "textBoxConf";
            this.textBoxConf.Size = new System.Drawing.Size(291, 20);
            this.textBoxConf.TabIndex = 5;
            this.textBoxConf.UseSystemPasswordChar = true;
            this.textBoxConf.TextChanged += new System.EventHandler(this.textBoxConf_TextChanged);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Location = new System.Drawing.Point(15, 168);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowPass.TabIndex = 6;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(150, 204);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(231, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PasswordChange
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(333, 239);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.textBoxConf);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.textBoxCurrPass);
            this.Controls.Add(this.labelConf);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelCurrPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordChange";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Change";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelConf;
        private System.Windows.Forms.TextBox textBoxConf;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TextBox textBoxCurrPass;
        public System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}