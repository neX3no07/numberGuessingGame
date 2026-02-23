using System.Globalization;

namespace numberGuessingGame;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        bool isOpen = true;
        int min = 1;
        int max = 101;
        int guess;
        int number;
        int guesses;
        String response;

        while (isOpen)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = rand.Next(min, max);
            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + " your number is too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " your number is to low!");
                }
                guesses++;
            }

            Console.WriteLine("Number: " + number);
            Console.WriteLine("You win!");
            Console.WriteLine("Guesses: " + guesses);
            
            Console.WriteLine("Would you play again? (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();
            if (response == "Y")
            {
                isOpen = true;
            }
            else
            {
                isOpen = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
        Console.ReadKey();
    }
        
}