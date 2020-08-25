using System;

namespace _2Selection_statements_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); //evaluate to a string

            switch (subject.ToLower())
            {
                case "Science":

                    Console.WriteLine("Science is tough!");
                    break;
                case "math":
                    Console.WriteLine("Math is tough!");
                    break;
                case "english":
                    Console.WriteLine("English is cool!");
                    break;
                case "history":
                    Console.WriteLine("History is interesting!");
                    break;
                case "pe":
                    Console.WriteLine("PE is a lot fun!");
                    break;
                default:
                    Console.WriteLine($"I never thought of that subject. {subject} sounds like a blast!");
                    break;
            }
        }
    }
}
 