using System;

namespace ShootingDice
{
    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public UpperHalfPlayer(string name)
        {
            Name = name;
        }
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(3, DiceSize) + 1;
        }
    }
}