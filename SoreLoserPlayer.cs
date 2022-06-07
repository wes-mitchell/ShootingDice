using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A Player that throws an exception when they lose to the other player
  // Where might you catch this exception????
  public class SoreLoserPlayer : Player
  {
    public override void Play(Player other)
    {
      // Call roll for "this" object and for the "other" object
      int myRoll = Roll();
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