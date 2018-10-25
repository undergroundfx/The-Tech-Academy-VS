using System;


    class Program
    {
        static void Main()
        {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();

        Console.WriteLine("What page number?");
        string page = Console.ReadLine();
        int pageNumber = Convert.ToInt16(page);

        Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
        string help = Console.ReadLine();
        bool anyHelp = Convert.ToBoolean(help);

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string experiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hours = Console.ReadLine();
        sbyte study = Convert.ToSByte(hours);
    }
}


