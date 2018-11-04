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

            string choice = Console.ReadLine();

            int animal = Convert.ToInt16(choice);

            if (animal > 5) {
                Console.WriteLine("You selected an animal that doesn't exist");
            } else
            {
                Console.WriteLine("You selected a " + animals[Convert.ToInt16(choice)]);
            }

            List<int> times4 = new List<int>();
            times4.Add(4);
            times4.Add(8);
            times4.Add(12);
            times4.Add(16);
            times4.Add(20);

            Console.WriteLine("Please select a number from 0 - 4");
            
            int selected = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(times4[selected]);

            Console.Read();

        }
    }
}

