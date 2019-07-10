using System;
using Character.DLL;

namespace DnD5th_CaracterCreation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string raceTemp = string.Empty;
            CharacterCreation character = new CharacterCreation();

            Console.WriteLine("Possible races for the character: ");
            character.ReturnAllRaces();

            // Console.WriteLine("Enter the race of the character");

            Console.Read();
        }
    }
}
