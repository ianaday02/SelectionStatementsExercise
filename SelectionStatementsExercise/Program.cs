using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 555;

            Console.WriteLine("Try to guess my favorite number!");
            var userInput = int.Parse(Console.ReadLine());
           
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }

            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }

            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}

