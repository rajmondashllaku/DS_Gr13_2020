using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds
{
    class Program
    {
        static string plainText;
        static void Main(string[] args)
        {

            Console.Write("Choose cipher:");
            Console.WriteLine("1.Beale Cipher:");
            Console.WriteLine("2.Four-square cipher:");
            Console.WriteLine("3.Case Cipher");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Enter something:");
                    plainText = Console.ReadLine();
                    
                    ;
                    break;
                case "2":
                    Console.WriteLine("Enter something:");
                    plainText = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Enter something:");
                    plainText = Console.ReadLine();
                    break;

            }
            Console.ReadLine();

        }
    }
}
