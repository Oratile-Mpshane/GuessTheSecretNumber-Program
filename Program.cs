namespace GuessingNumbrGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A Number Guessing Game!!!*/
            
            Console.WriteLine("Guess a number between 1 and 10:");

            Random r = new Random();
            int randomNumber = r.Next(1, 10);
            int input;
            bool timeout = false;

            do
            {
                input = Convert.ToInt32(Console.ReadLine());

                if (input < randomNumber)
                {
                    Console.WriteLine("You guessed too low!");
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("You guessed too high!");

                }
                else if (input == randomNumber)
                {
                    Console.WriteLine("You guessed the secret number!");
                    timeout = true;

                    Console.WriteLine("Game Over!!!");
                }

            } while (timeout == false);

            Console.ReadLine();
        }
    }
}