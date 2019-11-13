using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    class KeyReader : ISujeito
    {
        private ICollection<IObservador<ConsoleKey>> observers;

        public ConsoleKey LastKey { get; private set; }

        public KeyReader() 
        {
            observers = new List<IObservador<ConsoleKey>>();
        }


        public void RegisterObserver(IObservador<ConsoleKey> obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObservador<ConsoleKey> obs)
        {
            observers.Remove(obs);
        }


        public void Execute() 
        {

            while(true)
            {
                LastKey = Console.ReadKey().Key;

                if (LastKey == ConsoleKey.Escape) break;

                foreach (IObservador<ConsoleKey> ob in observers) 
                {
                    ob.Update(this.LastKey);
                }
            }
        }
    }
}
