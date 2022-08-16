
using System;
namespace Luyen_tap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Month:");
            int n = int.Parse(Console.ReadLine());
            if (1 <= n && n <= 12)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Jannuary");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.ReadKey();
        }
    }
}
