using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            kk:
            Console.WriteLine("Enter Your Name : ");
            String Name = Console.ReadLine();
            if (Name == "Mostafa") { Console.WriteLine("Your your password "); int pwd = int.Parse(Console.ReadLine()); if (pwd == 123) { Console.WriteLine("passed"); } }
            else { Console.WriteLine("Your Username is Worng"); }
            


            goto kk;

        }   // Yahia Zakaria C#
    }
}
