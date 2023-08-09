using System;

namespace MathGame.kacperkwa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var date = DateTime.Now;
            string name = GetName();
            Menu(name);


            Console.ReadKey();

        }

        private static string GetName()
        {
            Console.WriteLine("Please enter your name");
            string name=Console.ReadLine();
            return name;
        }

        private static void Menu(string name)
        {
            Console.WriteLine($"Hi {name.ToUpper()}. It's {date.DayOfWeek}.");
            Console.WriteLine(@$"Please chose what game would you play today:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program
");

            string gameSelected = Console.ReadLine();
            switch (gameSelected.ToUpper().Trim())
            {
                case "A":
                    AdditionGame("Addition game selected!");
                    break;
                case "S":
                    SubtractionGame("SubtractionGame game selected!");
                    break;
                case "M":
                    MultiplicationGame("Multiplication game selected!");
                    break;
                case "D":
                    DivisionGame("Division game selected!");
                    break;
                case "Q":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;

            }
        }

        private static void AdditionGame(string message)
        {
            Console.WriteLine(message);
        }

        private static void DivisionGame(string message)
        {
            Console.WriteLine(message);
        }

        private static void MultiplicationGame(string message)
        {
            Console.WriteLine(message);
        }
       
        private static void SubtractionGame(string message)
        {
            Console.WriteLine(message);
        }
    }
}