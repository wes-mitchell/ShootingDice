using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always rolls one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            int roll = new Random().Next(DiceSize) + 1;
            if (roll == 1) {
                roll = 2;
                return roll;
            }
            else 
            {
                return roll;
            }
        }
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object

            int myRoll = Roll();
            int otherRoll = myRoll - 1;

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

