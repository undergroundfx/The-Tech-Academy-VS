using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            string[] animals = { "dog", "cat", "mouse", "bird", "horse", "snake" };

            Console.WriteLine("Please select an animal from 0 - 5");

            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice > 5)
            {
                Console.WriteLine("You selected an animal that doesn't exist");
            }
            else
            {
                Console.WriteLine("You selected a " + animals[Convert.ToInt16(choice)]);
            }

            List<string> times4 = new List<string>();
            times4.Add("Programming ");
            times4.Add("Coding ");
            times4.Add("Engineering ");
            times4.Add("Hacking ");
            times4.Add("Building ");

            Console.WriteLine("Please select a number from 0 - 4");

            int selected = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(times4[selected]);

            Console.Read();

        }
    }
}