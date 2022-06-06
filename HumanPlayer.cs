using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.Write("Choose a number between 1 and 6: ");

            int userRoll = 0;

            bool userResponse = int.TryParse(Console.ReadLine(), out userRoll);

            while (userRoll < 1 || userRoll > 6 || !userResponse) 
            {
            Console.WriteLine("Nah doggy, try again.");
            Console.Write("Choose a number between 1 and 6: ");
            userResponse = int.TryParse(Console.ReadLine(), out userRoll);
            }

            // Call roll for "this" object and for the "other" object
            int myRoll = userRoll;
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}