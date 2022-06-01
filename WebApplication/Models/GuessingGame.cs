namespace WebApplication.Models
{
    public class GuessingGame
    {
       public static string MessageToPlayer()
        {
            return "Please enter your guess between 1 and 100: ";
        }
        public static string GuessGame(int guess, int randomNumber)
        {
            if (guess > randomNumber)
                return "Your guess is too high";
            else if (guess < randomNumber)
                return "Your guess is too low";
            else
                return "You have guessed the right number!";
        }
    }
}
