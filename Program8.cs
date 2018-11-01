using System;
using System.Text;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings

            string first = "Mario";
            string middle = "Jaron";
            string last = "Mitchell";

            string name = first + " " + middle + " " + last;
            Console.WriteLine(name);

            string upper = name.ToUpper();
            Console.WriteLine(upper);

            // Stringbuilder

            StringBuilder build = new StringBuilder();
            build.Append("Although StringBuilder and String both represent sequences of characters, they are implemented differently. ");
            build.Append("String is an immutable type. That is, each operation that appears to modify a String object actually creates a new string.");

            Console.WriteLine(build);

            Console.Read();





        }



    }
}
