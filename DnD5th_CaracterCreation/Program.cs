using System;
using Character.DLL;

namespace DnD5th_CaracterCreation
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                string raceTemp, classTemp, filename, writeToText;
                CharacterCreation character = new CharacterCreation();
                Writer writer = new Writer();

                Console.WriteLine("Enter the name of the file to save: ");
                filename = Console.ReadLine();

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

                writeToText = $"{character.GetRace()},{character.GetClass()}";
                writer.WriteToFile(filename, writeToText);

                Console.Write("Do you want to exit the creation?[Y/N]");
                if (Console.ReadLine() == "Y" || Console.ReadLine() == "y") done = true;
                
                Console.WriteLine("\n");
            }
        }
    }
}
