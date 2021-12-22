namespace Multiplication
{
    public class Program
    {
        public static void Main()
        {
            var numberOfQuestions = GetNumber("How many questions should I ask?", 3, 30);
            var minimumNumber = GetNumber("What is the smallest number you want to multiply?", 0, 50);
            var maximumNumber = GetNumber("What is the largest number you want to multiply?", minimumNumber, Math.Max(12, minimumNumber + 10));

            var randomNumberGenerator = new Random();
            var score = 0;

            for (var i = 0; i < numberOfQuestions; i++)
            {
                var number1 = randomNumberGenerator.Next(minimumNumber, maximumNumber + 1);
                var number2 = randomNumberGenerator.Next(minimumNumber, maximumNumber + 1);

                var answer = GetNumber($"What is {number1}x{number2}?", 0, maximumNumber * maximumNumber);

                if (answer == number1 * number2)
                {
                    WriteColoured("Correct!", ConsoleColor.Green, newLine: true);
                    score++;
                }
                else
                {
                    WriteColoured("Incorrect!", ConsoleColor.Red, newLine: true);
                }
                Console.WriteLine();
            }

            if (score >= 0.75 * numberOfQuestions)
            {
                WriteColoured("You're a PRO! ", ConsoleColor.Green);
            }
            else if (score < 0.25 * numberOfQuestions)
            {
                WriteColoured("You're a n00b! ", ConsoleColor.Red);
            }

            Console.WriteLine($"You got {score}/{numberOfQuestions} correct!");
        }

        static int GetNumber(string question, int minimum, int maximum)
        {
            Console.Write($"{question} ");
            var inputString = Console.ReadLine();
            int inputInt;

            if (!int.TryParse(inputString, out inputInt))
            {
                WriteColoured("That doesn't look like a number!", ConsoleColor.Red, newLine: true);

                return GetNumber(question, minimum, maximum);
            }
            else if (inputInt < minimum)
            {
                WriteColoured("That number is too small!", ConsoleColor.Red, newLine: true);
                Console.WriteLine($"Please enter a number between {minimum} and {maximum}");
                
                return GetNumber(question, minimum, maximum);
            }
            else if (inputInt > maximum)
            {
                WriteColoured("That number is too big!", ConsoleColor.Red, newLine: true);
                Console.WriteLine($"Please enter a number between {minimum} and {maximum}");
                
                return GetNumber(question, minimum, maximum);
            }
            else
            {
                return inputInt;
            }
        }

        static void WriteColoured(string text, ConsoleColor colour, bool newLine = false)
        {
            Console.ForegroundColor = colour;
            Console.Write(text);
            Console.ResetColor();

            if (newLine)
            {
                Console.WriteLine();
            }
        }
    }
}