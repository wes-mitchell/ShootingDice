using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
    public override void Play(Player other)
    {
      // Call roll for "this" object and for the "other" object
      Random rnd = new Random();
      int upperRoll = rnd.Next(3, 6);
      int myRoll = upperRoll;
      int otherRoll = other.Roll();

      Console.WriteLine($"{Name} rolls a {myRoll}");
      Console.WriteLine($"{other.Name} rolls a {otherRoll}");
      try
      {
        if (myRoll > otherRoll)
        {
          Console.WriteLine($"{Name} Wins!");
        }
        else
        {
          throw new Exception();
        }
      }
      catch
      {
        Console.WriteLine($"No matter what the dice say, {Name} always wins. Try again sometime though.");
      }
    }
    }
}