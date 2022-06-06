using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
         public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();
            
            Taunt();
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

        public void Taunt()
        {
        Random rnd = new Random();
        int randomTaunt = rnd.Next(1, 6);
        switch(randomTaunt)
        {
            case 1:
            Console.WriteLine("You a dang ol cheezhead.");
            break;
            case 2:
            Console.WriteLine("You'll never win, I'm boss at this.");
            break;
            case 3:
            Console.WriteLine("You got nothing on me.");
            break;
            case 4:
            Console.WriteLine("Thanks for playing, you stand no chance.");
            break;
            case 5:
            Console.WriteLine("You so old you forgot how to count to 6 didn't you?");
            break;
            case 6:
            Console.WriteLine("I win always. You're done.");
            break;
        }
        }
    }
}
