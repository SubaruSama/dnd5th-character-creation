using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DnD5th_CaracterCreation
{
    public class Writer
    {
        public void WriteToFile(string filename, string data)
        {
            File.WriteAllText($"{$@"{Directory.GetCurrentDirectory()}\{filename}.txt"}", data);
        }
    }
}
