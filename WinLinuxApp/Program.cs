using WinLinuxApp.Classes;

namespace WinLinuxApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeFolder fh = new("Loke.txt");

            try
            {
                fh.CreateFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}