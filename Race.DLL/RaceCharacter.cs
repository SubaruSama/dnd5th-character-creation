using System;

namespace Race.DLL
{
    public class RaceCharacter
    {
        private string choosenRace = string.Empty;

        public void SetRace(string ChoosenRace)
        {
            if (Enum.IsDefined(typeof(Races), ChoosenRace))
            {
                choosenRace = ChoosenRace;
            }
            else
            {
                Console.WriteLine("Provided race doesn't exists.");
            }
        }

        public string GetRace()
        {
            return choosenRace;
        }
    }
}
