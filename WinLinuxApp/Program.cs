using WinLinuxApp.Classes;

namespace WinLinuxApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Your user folder is: {Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}");
            #region opgave 2
            //Console.WriteLine("Please choose 1 to make a new file or 2 to check path");

            //string? choice = Console.ReadLine();

            //if (choice == "1")
            //{
            //    Console.Write("Input file name: ");
            //    string nameOfFile = Console.ReadLine();
            //    Console.Write("Input text to file:");
            //    string textToFile = Console.ReadLine();
            //    MakeFolder fh = new(nameOfFile + ".txt");
            //    try
            //    {
            //        fh.CreateFile(textToFile);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            //}
            //else if (choice == "2")
            //{
            //    Console.WriteLine($"Your user folder is: {Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect input");
            //}
            #endregion

            int x = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(x);
                System.Threading.Thread.Sleep(1000);
                x++;
            }
        }
    }
}