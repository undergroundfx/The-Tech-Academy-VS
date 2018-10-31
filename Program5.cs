using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean Logic

            // person 1
            Console.WriteLine("What is your age?");
            string _age = Console.ReadLine();
            byte age = Convert.ToByte(_age);

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool hadDUI;
            if (dui == "yes")
            {
                hadDUI = true;
            } else
            {
                hadDUI = false;
            }

            Console.WriteLine("How many speeding tickets do you have?");
            string _tickets = Console.ReadLine();
            byte tickets = Convert.ToByte(_tickets);

            Console.WriteLine("Qualified?");

            if (age > 15 && hadDUI == false && tickets < 3)
            {
                Console.WriteLine("YES!");
            } else  {
                Console.WriteLine("NO!");
            }

            Console.Read();
        }
    }
}
