using System;

namespace Class.DLL
{
    public class ClassCharacter
    {
        private string choosenClass = string.Empty;

        public void SetClass(string ChoosenClass)
        {
            if(Enum.IsDefined(typeof(Classes), ChoosenClass))
            {
                choosenClass = ChoosenClass;
            }
            else
            {
                Console.WriteLine("Provided class doesn't exists.");
            }
        }

        public string GetClass()
        {
            return choosenClass;
        }
    }
}
