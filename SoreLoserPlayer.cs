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

            try
            {
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    // *not sure this is right
                    throw new NotImplementedException();

                }
                else
                {
                    Console.WriteLine("It's a tie");
                }
            }
            catch
            {
                Console.WriteLine("Bev is being a sore loser!");
            }
            
        }
    }
}