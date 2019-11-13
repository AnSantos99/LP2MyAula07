using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    class KeyToScreen : IObservador<ConsoleKey>
    {
        public void Update(ConsoleKey key)
        {
            Console.WriteLine(key.ToString());
        }
    }
}
