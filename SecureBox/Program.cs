using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SecureBox.BL;
using SecureBox.UIL;

namespace SecureBox
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SecureBox.BL.SecureBox secBox = new BL.SecureBox();
            Application.Run(new MainWindow(secBox));
        }
    }
}
