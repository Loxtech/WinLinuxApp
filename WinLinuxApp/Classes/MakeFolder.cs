using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinLinuxApp.Classes
{
    public class MakeFolder
    {
        public string FileName{get; set;}
        public string MyUserDir{
            get => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), FileName);
        }
        public MakeFolder(string fileName) => FileName = fileName;
        public void CreateFile(string text) => File.WriteAllText(MyUserDir, text);
        
    }
}
