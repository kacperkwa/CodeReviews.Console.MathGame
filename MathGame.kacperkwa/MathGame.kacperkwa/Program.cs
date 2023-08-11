using System;
using static System.Formats.Asn1.AsnWriter;

namespace MathGame.kacperkwa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var date = DateTime.Now;
            string name = GetName();
            Menu(name, date);


            Console.ReadKey();

        }

        private static string GetName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            return name;
        }

        private static void Menu(string name, DateTime date)
        {

            Console.WriteLine($"Hi {name.ToUpper()}. It's {date.DayOfWeek}.");
            bool isGameOn = true;
            do
            {
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
                        AdditionGame("Addition game!");
                        break;
                    case "S":
                        SubtractionGame("SubtractionGame game!");
                        break;
                    case "M":
                        MultiplicationGame("Multiplication game!");
                        break;
                    case "D":
                        DivisionGame("Division game!");
                        break;
                    case "Q":
                        Console.WriteLine("Goodbye!");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;

                }
            } while (isGameOn);
           
        }

        private static void AdditionGame(string message)
        {


            Random random = new();
            int score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                string resultString = Console.ReadLine();
                bool succes = int.TryParse(resultString, out int resultInt);
                if (resultInt == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next  question");
                    score++;
                    Console.ReadKey();

                }
                else if (succes == false)
                {
                    Console.WriteLine("Please enter a valid number next time!");
                    Console.ReadKey();  
                }
                else
                {
                    Console.WriteLine("Your anwser is incorrect. Type any key for the next  question");
                    Console.ReadKey();
                }
                if (i == 4) Console.WriteLine($"Game over. Your score is {score} out of 5!");

            }

        }

        private static void DivisionGame(string message)
        {

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                int[] divisionNumbers = GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];
                Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
                string resultString = Console.ReadLine();
                bool succes = int.TryParse(resultString, out int resultInt);
                if (resultInt == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next  question");
                    score++;
                    Console.ReadKey();

                }
                else if (succes == false)
                {
                    Console.WriteLine("Please enter a valid number next time!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your anwser is incorrect. Type any key for the next  question");
                    Console.ReadKey();
                }
                if (i == 4) Console.WriteLine($"Game over. Your score is {score} out of 5!");


            }
        }

        private static void MultiplicationGame(string message)
        {


            Random random = new();
            int score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                string resultString = Console.ReadLine();
                bool succes = int.TryParse(resultString, out int resultInt);
                if (resultInt == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next  question");
                    score++;
                    Console.ReadKey();

                }
                else if (succes == false)
                {
                    Console.WriteLine("Please enter a valid number next time!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your anwser is incorrect. Type any key for the next  question");
                    Console.ReadKey();
                }
                if (i == 4) Console.WriteLine($"Game over. Your score is {score} out of 5!");

            }
        }

        private static void SubtractionGame(string message)
        {


            Random random = new();
            int score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                string resultString = Console.ReadLine();
                bool succes = int.TryParse(resultString, out int resultInt);
                if (resultInt == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next  question");
                    score++;
                    Console.ReadKey();

                }
                else if (succes == false)
                {
                    Console.WriteLine("Please enter a valid number next time!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your anwser is incorrect. Type any key for the next  question");
                    Console.ReadKey();
                }
                if (i == 4) Console.WriteLine($"Game over. Your score is {score} out of 5!");

            }
        }
        private static int[] GetDivisionNumbers()
        {

            Random random = new();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);
            int[] result = new int[2];
            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }
            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
    }
}