using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Observers
{
    class KeyToFile : IObservador
    {
        private string fileName;

        public KeyToFile(string fileName) 
        {
            this.fileName = fileName;
        }
        public void Update(ISujeito sujeito)
        {
            File.AppendAllText(fileName, 
                (sujeito as KeyReader).LastKey.ToString());
        }
    }
}
