using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiplies by 50
            Console.WriteLine("Please enter a number");
            string entered1 = Console.ReadLine();
            double num1 = Convert.ToDouble(entered1);
            Console.WriteLine(num1 * 50);

            // adds 25
            Console.WriteLine("Please enter a number");
            string entered2 = Console.ReadLine();
            double num2 = Convert.ToDouble(entered2);
            Console.WriteLine(num1 + 25);

            // divides by 12.5
            Console.WriteLine("Please enter a number");
            string entered3 = Console.ReadLine();
            double num3 = Convert.ToDouble(entered3);
            Console.WriteLine(num1 / 12.5);

            // greater than 50
            Console.WriteLine("Please enter a number");
            string entered4 = Console.ReadLine();
            double num4 = Convert.ToDouble(entered4);
            if (num4 > 50)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }

            // returns the remainder
            Console.WriteLine("Please enter a number");
            string entered5 = Console.ReadLine();
            double num5 = Convert.ToDouble(entered3);
            Console.WriteLine(num1 % 7);

            Console.Read();

        }
    }
}
