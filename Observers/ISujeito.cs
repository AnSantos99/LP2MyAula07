using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    interface ISujeito
    {
        public void RegisterObserver(IObservador obs);

        public void RemoveObserver(IObservador obs);


    }
}
