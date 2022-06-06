using System;

namespace ShootingDice
{
    // A player who prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {

        public HumanPlayer(string name)
        {
            Name = name;
        }
        public override void Play(Player other)
        {
        // Call roll for "this" object and for the "other" object
        Console.WriteLine("Please enter a number for your roll");
        int myRoll = Int32.Parse(Console.ReadLine());
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");
        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll<otherRoll)
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