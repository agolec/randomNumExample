using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGuess = 0;

            int numberOfAttempts = 1;

            Random rnd = new Random();
            int randomNumber = Convert.ToInt32(rnd.Next(50));

            Console.WriteLine("enter a number between 1-50 and I will tell you if it matches the magic number.");
            userGuess = Convert.ToInt32(Console.ReadLine());

            while ((randomNumber) != userGuess)
            {
                if (randomNumber > userGuess)
                {
                    Console.WriteLine("Numbers aren't matching. Guess is too low. Enter another number.");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                else if (randomNumber < userGuess)
                {
                    Console.WriteLine("Numbers aren't matching. Guess is too high. Enter another number.");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                numberOfAttempts++;
            }
            Console.WriteLine("You got it! It took " + numberOfAttempts + " guesses.");
        }
    }
}

            