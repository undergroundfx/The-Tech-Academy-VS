using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Branching
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight");
            string package = Console.ReadLine();
            byte weight = Convert.ToByte(package);

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            } else
            {
                Console.WriteLine("Please enter the package width:");
                string _width = Console.ReadLine();
                byte width = Convert.ToByte(_width);

                Console.WriteLine("Please enter the package heigth:");
                string _height = Console.ReadLine();
                byte heigth = Convert.ToByte(_height);

                Console.WriteLine("Please enter the package length:");
                string _length = Console.ReadLine();
                byte length = Convert.ToByte(_length);

                if (width + heigth + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                } else
                {
                    decimal quote = (width + heigth + length) * weight / 100m;
                    string final = quote.ToString();
                    Console.WriteLine("Your estimated total for shipping this package is: $" + final);
                }
            }
    
            Console.Read();
        }

    }
}
