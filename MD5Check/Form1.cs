using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Check
{
    public partial class MD5CheckForm : Form
    {
        private const string MenuName = "*\\shell\\MD5Check";
        private const string Command = "*\\shell\\MD5Check\\command";

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public MD5CheckForm(byte[] hash)
        {
            InitializeComponent();

            if (!IsAdministrator())
            {
                AddContextButton.Enabled = false;
                RemoveContextButton.Enabled = false;
            }

            if (Clipboard.ContainsText() && Clipboard.GetText().Length < 33)
                MD5ToCheckText.Text = Clipboard.GetText();

            MD5FromFileText.Text = hash.Aggregate("", (string s, byte b) => { return s + b.ToString("x2"); } );
            CheckMatch();
        }

        public void CheckMatch()
        {
            if (string.Compare(MD5FromFileText.Text, MD5ToCheckText.Text, true) == 0)
                CheckIcon.Image = IconList.Images[0];
            else
                CheckIcon.Image = IconList.Images[1];
        }

        private void MD5CheckForm_Load(object sender, EventArgs e)
        {

        }

        private void RemoveContextButton_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey reg = Registry.ClassesRoot.OpenSubKey(Command);
                if (reg != null)
                {
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(Command);
                }
                reg = Registry.ClassesRoot.OpenSubKey(MenuName);
                if (reg != null)
                {
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(MenuName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void AddContextButton_Click(object sender, EventArgs e)
        {
            RegistryKey regmenu = null;
            RegistryKey regcmd = null;
            try
            {
                RegistryKey key = Registry.ClassesRoot.OpenSubKey("*\\shell", RegistryKeyPermissionCheck.ReadWriteSubTree);
                regmenu = key.CreateSubKey("MD5Check", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (regmenu != null)
                    regmenu.SetValue("", "MD5Check");
                regcmd = regmenu.CreateSubKey("command");
                if (regcmd != null)
                    regcmd.SetValue("", string.Format("{0} %L", Application.ExecutablePath));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
            finally
            {
                if (regmenu != null)
                    regmenu.Close();
                if (regcmd != null)
                    regcmd.Close();
            }
        }

        private void MD5ToCheckText_TextChanged(object sender, EventArgs e)
        {
            CheckMatch();
        }
    }
}
