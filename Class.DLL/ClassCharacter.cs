using System;

namespace Class.DLL
{
    public class ClassCharacter
    {
        private string choosenClass = string.Empty;
        public string ChoosenClass {
            get { return choosenClass; }

            private set
            {
                if (Enum.IsDefined(typeof(Classes), ChoosenClass))
                {
                    choosenClass = ChoosenClass;
                }
                else
                {
                    Console.WriteLine("Provided class doesn't exists.");
                }
            }
        }
    }
}
