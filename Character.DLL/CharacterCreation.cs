using System;
using Race.DLL;
using Class.DLL;
using System.Collections.Generic;
using System.Linq;

namespace Character.DLL
{
    public class CharacterCreation : IRace, IClass
    {
        public string characterRace = string.Empty;
        public string characterClass = string.Empty;
        RaceCharacter CharacterRace = new RaceCharacter();
        ClassCharacter CharacterClass = new ClassCharacter();

        // === Classes stuff ===
        public void ReturnAllClasses()
        {
            foreach(string classes in Enum.GetNames(typeof(Classes)))
            {
                Console.WriteLine(classes);
            }
        }

        public void SetClass(string characterClass)
        {
            CharacterClass.SetClass(characterClass);
        }

        public string GetClass()
        {
            return CharacterClass.GetClass();
        }

        // === Races stuff ===
        public void ReturnAllRaces()
        {
            foreach(string race in Enum.GetNames(typeof(Races)))
            {
                Console.WriteLine(race);
            }
            
        }

        public void SetRace(string characterRace)
        {
            CharacterRace.SetRace(characterRace);
        }

        public string GetRace()
        {
            return CharacterRace.GetRace();
        }
    }
}
