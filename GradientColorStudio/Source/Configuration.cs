using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GradientColorStudio
{
    class Configuration
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        public bool Write(string sectionName, string keyName, string stringToWrite)
        {
            bool Return;
            Return = WritePrivateProfileString(sectionName, keyName, stringToWrite, Statics.configurationFile);
            return Return;
        }

        [DllImport("kernel32.dll")]
        static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        public string Read(string mainTitle, string subTitile)
        {
            try
            {
                StringBuilder sb = new StringBuilder(1000);
                GetPrivateProfileString(mainTitle, subTitile, "", sb, sb.Capacity, Statics.configurationFile);
                string received = sb.ToString();
                sb.Clear();
                return received;
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
}
