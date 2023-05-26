using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLinuxApp.Classes
{
    public class MakeFolder
    {
        public static bool CreateFile()
        {
            bool success = true;

            try
            {
                string myUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                File.Create(Path.Combine(myUserFolder, "Loke.txt"));
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }
    }
}
