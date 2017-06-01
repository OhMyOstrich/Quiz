using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Quiz
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
            Application.Run(new Form1());

            //RegistryKey e = Registry.LocalMachine.CreateSubKey("Software");
            //RegistryKey key = Registry.LocalMachine.CreateSubKey("\\Software\\Classes");
            //RegistryKey rk = Registry.LocalMachine.CreateSubKey("\\Software\\Classes\\.quiz");
            //rk.SetValue("DefaultIcon", "C:\\Users\\julien\\Downloads\\Mario.ico");

            //Registry.CurrentUser.CreateSubKey("\\SOFTWARE\\Classes\\Julien");
            //Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Classes\\.quiz", "DefaultIcon", "C:\\Users\\julien\\Downloads\\Mario.ico");
        }
    }
}