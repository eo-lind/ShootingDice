using System;

namespace ShootingDice
{
    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public SoreLoserUpperHalfPlayer(string name)
        {
            Name = name;
        }
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(3, DiceSize) + 1;
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
                Console.WriteLine("Bogie is being a sore loser!");
            }
        }

    }
}