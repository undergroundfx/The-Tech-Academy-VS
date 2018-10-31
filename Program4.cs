using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate:");
            string hourly1 = Console.ReadLine();
            decimal rate1 = Convert.ToDecimal(hourly1);

            Console.WriteLine("Hours worked per week?");
            string worked1 = Console.ReadLine();
            decimal weekly1 = Convert.ToDecimal(worked1);

            // person 2
            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate:");
            string hourly2 = Console.ReadLine();
            decimal rate2 = Convert.ToDecimal(hourly2);

            Console.WriteLine("Hours worked per week?");
            string worked2 = Console.ReadLine();
            decimal weekly2 = Convert.ToDecimal(worked2);

            // totals
            Console.WriteLine("Hourly salary of Person 1:");
            decimal person1 = rate1 * weekly1;
            Console.WriteLine(person1);

            Console.WriteLine("Hourly salary of Person 2:");
            decimal person2 = rate2 * weekly2;
            Console.WriteLine(person2);

            Console.WriteLine("Does Person 1 make more than Person 2?");

            if (person1 > person2)
            {
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }

            Console.Read();

        }
    }
}
