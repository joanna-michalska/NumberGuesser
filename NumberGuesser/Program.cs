namespace NumberGuesser
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);

            // Prompt the user to guess the number
            Console.WriteLine("Guess a number between 1 and 100:");
            int guess = 0;

            while (guess != numberToGuess)
            {
                // Read user input
                string input = Console.ReadLine();

                // Parse user input as an integer
                bool isValidInput = int.TryParse(input, out guess);
                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    continue;
                }

                // Check if the guess is correct
                if (guess == numberToGuess)
                {
                    Console.WriteLine("Congratulations, you guessed the number!");
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine("The number is higher, try again.");
                }
                else
                {
                    Console.WriteLine("The number is lower, try again.");
                }
            }

            Console.ReadKey();
        }
    }
}