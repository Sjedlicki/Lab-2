using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Welcome to the wonderful world of measuring your class room");
                Console.WriteLine("Please Dimentionalize Your Room!");

                try
                {
                    Console.Write("Length: ");
                    double L = double.Parse(Console.ReadLine());

                    Console.Write("Width: ");
                    double W = double.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    double H = double.Parse(Console.ReadLine());

                    Console.WriteLine("Area: " + (L * W));
                    Console.WriteLine("Perimeter: " + ((2 * L) + (2 * W)));
                    Console.WriteLine("Volume: " + (L * W * H));
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
                bool again = true;
                    while (again == true)
                {
                    Console.Write("Would you like to measure another room? Y/N: ");
                    string go = Console.ReadLine();
                    if ((go == "Y") || (go == "y") || (go == "Yes") || (go == "yes"))
                    {
                        again = false;
                        repeat = true;
                        Console.Clear();
                    }
                    else if ((go == "N") || (go == "n") || (go == "No") || (go == "no"))
                    {
                        again = false;
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid response");
                        again = true;
                    }
                }
            }
            Console.WriteLine("Press Any Key To Exit...");
            Console.ReadKey();

        }
    }
}
