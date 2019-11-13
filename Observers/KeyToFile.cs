using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Observers
{
    class KeyToFile : IObservador<ConsoleKey>
    {
        private string fileName;

        public KeyToFile(string fileName) 
        {
            this.fileName = fileName;
        }
        public void Update(ConsoleKey key)
        {
            File.AppendAllText(fileName, key.ToString());
        }
    }
}
