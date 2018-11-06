using System;
using System.Collections.Generic;

namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> nums = new List<int> { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048 };
                Console.WriteLine("Please select a number to divide by:");
                int num1 = Convert.ToInt16(Console.ReadLine());

                foreach (int number in nums)
                {
                    Console.WriteLine("The result is: " + (number / num1));
                }

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
                {
                Console.WriteLine("\nYou have exited the Try\\Catch block");
            }

            Console.ReadLine();

        }
    }
}
