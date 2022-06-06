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
            int userRoll = int.Parse(Console.ReadLine());
            try
            {
                while (userRoll < 1 || userRoll > 6) {
                Console.WriteLine("Nah doggy, try again.");
                Console.Write("Choose a number between 1 and 6: ");
                userRoll = int.Parse(Console.ReadLine());
                }
            }
            catch (System.FormatException) 
            {
                Console.WriteLine("Nah doggy, try again.");
                Console.WriteLine("Nah doggy, try again.");
                Console.Write("Choose a number between 1 and 6: ");
                userRoll = int.Parse(Console.ReadLine());
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