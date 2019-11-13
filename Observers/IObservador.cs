using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    interface IObservador<T>
    {
        
        public void Update(T obj);
    }
}
