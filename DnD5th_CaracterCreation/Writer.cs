using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DnD5th_CaracterCreation
{
    public class Writer
    {
        /*
         * Get the path of the file;
         * Open the file;
         * Write the contents of the character class, race and class, to file;
         * Close the file.
         */
        public void WriteToFile(string filename, string data)
        {
            File.WriteAllText($"{$@"{Directory.GetCurrentDirectory()}\{filename}.txt"}", data);
        }
    }
}
