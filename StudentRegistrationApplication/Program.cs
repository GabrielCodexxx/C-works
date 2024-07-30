using System;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    static class Program
    {
        // Main entry point of the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmStudentRegistration());
        }
    }
}
