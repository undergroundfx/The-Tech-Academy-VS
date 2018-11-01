using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean Comparison

            bool on = true;

            while (on == true)
            {
                Console.WriteLine("Hello!");
                on = false;
            }

            do
            {
                Console.WriteLine("Hi!");
                on = true;
            }

            while (on == false);



            Console.Read();
        }



    }
}
