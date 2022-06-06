using System;

namespace ShootingDice
{
    // A Player that throws an exception when they lose to the other player
    public class SoreLoserPlayer : Player
    {
        public SoreLoserPlayer(string name)
        {
            Name = name;
        }
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                // *not sure this is right
               try
               {
                   otherRoll = otherRoll * 1;
               }
               catch(Exception)
               {
                    Console.WriteLine($"{other.Name} Wins!");
               }
              
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}