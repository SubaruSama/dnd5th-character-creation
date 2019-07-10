using System.Collections.Generic;

namespace Race.DLL
{
    public interface IRace
    {
        void SetRace(string ChoosenRace);
        string GetRace();
        void ReturnAllRaces();
    }
}
