using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert country: ");
            string country = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insert weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert height:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert length:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert width:");
            double width = double.Parse(Console.ReadLine());

            double packageSize = height * length * width;

            Price(country, weight, packageSize);
        }

        static void Price(string country, double weight, double packageSize)
        {
            double price = 0;
            if (country.ToLower() == "danmark")
            {
                if (packageSize <= 90)
                {
                    Console.WriteLine("It's a letter");
                    if (weight <= 50)
                    {
                        price = 11;
                        Console.WriteLine($"Price for letter {price}kr");
                    }
                }
                else
                {
                    Console.WriteLine("It's a package");
                    price = 50;
                    Console.WriteLine($"Price for package {price}kr");
                }
            }
            else
            {
                if (packageSize <= 90)
                {
                    Console.WriteLine("It's a letter");
                    if (weight <= 50)
                    {
                        price = 33;
                        Console.WriteLine($"Price for letter {price}kr");
                    }
                }
                else
                {
                    Console.WriteLine("It's a package");
                    price = 145;
                    Console.WriteLine($"Price for package {price}kr");
                }
            }
            Console.ReadKey();
        }
    }
}
