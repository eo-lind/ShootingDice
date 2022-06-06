using System;

namespace ShootingDice
{
    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        public SmackTalkingPlayer(string taunt)
        {
            Taunt = taunt;
        }

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine(Taunt);
            return new Random().Next(DiceSize) + 1;
        }
    }
}