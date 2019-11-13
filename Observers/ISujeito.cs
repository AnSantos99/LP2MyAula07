using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    interface ISujeito
    {
        public void RegisterObserver(IObservador<ConsoleKey> key);

        public void RemoveObserver(IObservador<ConsoleKey> key);


    }
}
