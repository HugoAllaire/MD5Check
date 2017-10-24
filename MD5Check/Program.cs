using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Check
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            byte[] hash = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            if (args.Length > 0)
            {
                try
                {
                    FileStream fs = new FileStream(args[0], FileMode.Open, FileAccess.Read);
                    hash = MD5.Create().ComputeHash(fs);
                    fs.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MD5CheckForm(hash));
        }
    }
}
