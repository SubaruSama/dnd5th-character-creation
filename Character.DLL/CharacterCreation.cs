using System;
using Race.DLL;
using Class.DLL;
using System.Collections.Generic;
using System.Linq;

namespace Character.DLL
{
    public class CharacterCreation : IRace
    {
        public string characterRace = string.Empty;
        public string characterClass = string.Empty;
        RaceCharacter CharacterRace = new RaceCharacter();
        // ClassCharacter CharacterClass = new ClassCharacter();

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

        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Stamina { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Charisma { get; private set; }
    }
}
