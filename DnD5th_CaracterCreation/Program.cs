using System;
using Character.DLL;

namespace DnD5th_CaracterCreation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string raceTemp = string.Empty;
            string classTemp = string.Empty;
            CharacterCreation character = new CharacterCreation();

            Console.WriteLine("Possible races for the character: ");
            character.ReturnAllRaces();

            Console.WriteLine("\n======================\n");

            Console.WriteLine("Possible classes for the character: ");
            character.ReturnAllClasses();

            Console.Write("Enter the race of the character: ");
            raceTemp = Console.ReadLine();
            character.SetRace(raceTemp);

            Console.Write("Enter the class of the character: ");
            classTemp = Console.ReadLine();
            character.SetClass(classTemp);

            Console.WriteLine("\n======================\n");

            Console.WriteLine($"Info of the character: \nRace: {character.GetRace()}\nClass: {character.GetClass()}");

            Console.Read();
        }
    }
}
