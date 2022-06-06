using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        public CreativeSmackTalkingPlayer(string name)
        {
            Name = name;
        }

        // public override int Roll()
        // {
        //     // construct taunt list
        //     List<string> taunts = new List<string>();

        //     // taunts
        //     taunts.Add("I don't want to talk to you anymore, you empty-headed animal food trough whopper.");
        //     taunts.Add("I fart in your general direction.");
        //     taunts.Add("Your mother was a hamster and your father smelt of elderberries!");

        //     // pick a taunt
        //     int randomNum = new Random();
        //     int tauntIndex = randomNum.Next(0, taunts.Count);
        //     Console.WriteLine(taunts[tauntIndex])

        //     // get roll #
        //     return new Random().Next(DiceSize) + 1; 
        // }
    }
}