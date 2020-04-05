using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool infoEntry = false;

            while (infoEntry == false)
            {
                Console.WriteLine("Please select your starting Character:");
                char startChar = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                int startInt = (int)startChar;

                Console.WriteLine("Please select your ending Character:");
                char endChar = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                int endInt = (int)endChar;

                if (endInt > startInt)
                {
                    bool tableCreation = false;

                    while (tableCreation == false)
                    {
                        // It works up to here

                        Console.WriteLine($"{"Letter",-10} {"Decimal",-10} {"Octal",-10} {"Hex",-10}");

                        while (startInt <= endInt)
                        {
                            startChar = (char)startInt;
                            string octal = Convert.ToString(startChar, 8);
                            string hex = Convert.ToString(startChar, 16);

                            Console.WriteLine($"{startChar,-10} {startInt,-10} {octal,-10} {hex,-10}");
                            startInt++;
                        }
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Your second Character must be larger than your first Character");
                    Console.WriteLine();
                }
            }
        }
    }
}
