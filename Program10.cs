using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program


    {
        static void Main(string[] args)
        {

            // Iteration

            string[] animals = { "dog", "cat", "mouse", "bird", "horse", "snake" };
            Console.WriteLine("Please enter a word");
            string userText = Console.ReadLine();

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i] + " " + userText;
                Console.WriteLine(animals[i] + "\n");
            }

            // infinite loop
            bool loop = true;

            while (loop == true)
            {
                Console.WriteLine("This was a loop\n\n");
                loop = false;
            }

            // <
            int age1 = 1;

            while (age1 < 21)
            {
                Console.WriteLine("You are " + Convert.ToString(age1) + " and too young to buy beer, sorry!");
                age1++;
            }

            Console.WriteLine("You are 21 and old enough to buy beer!\n\n");

            // <=
            int age2 = 1;

            while (age2 <= 17)
            {
                Console.WriteLine("You are " + Convert.ToString(age2) + " and can't vote!");
                age2++;
            }

            Console.WriteLine("You are 18 and old enough to vote!\n\n");

            // list

            List<string> cars = new List<string> { "Ford", "Chevy", "Mercedes", "Honda" };

            Console.WriteLine("Please enter a car brand");
            string brand = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < cars.Count - 1; i++)
            {
                if (cars[i] == brand)
                {
                    Console.WriteLine("Your selection is in index: " + Convert.ToString(i) + "\n\n");

                    // exit the loop
                    i = cars.Count;
                    found = true;
                }

            }

            if (found == false)
            {
                Console.WriteLine("Not found\n\n");
            }

            // second list

            List<string> names = new List<string> { "Mario", "James", "Peter", "Mario", "David", "James", "Bob", "Henry" };
            List<int> indexes = new List<int> { };

            Console.WriteLine("Please enter a name");
            string choice = Console.ReadLine();

            for (int i = 0; i < names.Count - 1; i++)
            {
                if (names[i] == choice)
                {
                    Console.WriteLine(i);
                    // exit the loop
                    found = true;
                }

            }

            if (found == false)
            {
                Console.WriteLine("Name wasn't found\n");
            }

            // identical strings

            List<string> names2 = new List<string> { "Mario", "James", "Peter", "Mario", "David", "James", "Bob", "Henry", "Henry" };
            List<string> duplicates = new List<string> { };

            // place each item in new lists and then loop thru the list to check for duplicates
            foreach (string name2 in names2)
            {
                duplicates.Add(name2);

                for (int j = 0; j < duplicates.Count - 1; j++)
                {
                    if (name2 == duplicates[j])
                    {
                        Console.WriteLine("\n" + name2 + " has a duplicate");
                    }

                }

            }

            Console.Read();

        }
    }
}

