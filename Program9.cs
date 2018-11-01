using System;




    class Program2
    {
        static void Main()
        {
            // Arrays

            string[] animals = { "dog, cat, mouse, bird, horse, snake" };

            Console.WriteLine("Please select an index from 0 - 5");

            string choice = Console.ReadLine();

            Console.WriteLine("You selected: " + animals[choice]);

           
            Console.Read();


        }
    }

