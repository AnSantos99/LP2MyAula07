using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    class KeyToScreen : IObservador
    {
        public void Update(ISujeito sujeito)
        {
            Console.WriteLine((sujeito as KeyReader).LastKey);
        }
    }
}
