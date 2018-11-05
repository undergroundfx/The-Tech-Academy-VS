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
                Console.WriteLine("This was a loop");
                loop = false; 
            }
            
            // <
            int age1 = 1;

            while (age1 < 21)
            {
                Console.WriteLine("You are " + Convert.ToString(age1) + " and too young to buy beer, sorry!");
                age1++;
            }

            Console.WriteLine("You are 21 and old enough to buy beer!");

            // <=
            int age2 = 1;

            while (age2 <= 17)
            {
                Console.WriteLine("You are " + Convert.ToString(age2) + " and can't vote!");
                age2++;
            }

            Console.WriteLine("You are 18 and old enough to vote!");

            // list

            List<string> cars = new List<string> {"Ford", "Chevy", "Mercedes", "Honda"};

            Console.WriteLine("Please enter a car brand");
            string brand = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < cars.Count - 1; i++)
            {
                if (cars[i] == brand)
                {
                    Console.WriteLine("Your selection is in index: " + Convert.ToString(i));
                        
                    // exit the loop
                    i = cars.Count;
                    found = true;
                }
            
            }

            if (found == false)
            {
                Console.WriteLine("Not found");
            }

            

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
                Console.WriteLine("Name wasn't found");
            }

            Console.Read();

        }
            }
}

