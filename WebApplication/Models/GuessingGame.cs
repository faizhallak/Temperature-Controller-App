using System;
namespace WebApplication.Models
{
    public class GuessingGame
    {
       public static string MessageToPlayer()
        {
            return "Please enter your guess between 1 and 100: ";
        }

        public static string GuessNumber(int guess, int rndNr)
        {
                if (guess > rndNr)
                {
                return "Your guess is too high";
                }
                else if (guess < rndNr)
                {
                return "Your guess is too low";
                }
                else

                return "You have guessed the right number!";
            
        }
    }
}
