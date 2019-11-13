using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    class KeyReader : ISujeito
    {
        private ICollection<IObservador> observers;

        public ConsoleKey LastKey { get; private set; }

        public KeyReader() 
        {
            observers = new List<IObservador>();
        }


        public void RegisterObserver(IObservador obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObservador obs)
        {
            observers.Remove(obs);
        }


        public void Execute() 
        {

            while(true)
            {
                LastKey = Console.ReadKey().Key;

                if (LastKey == ConsoleKey.Escape) break;

                foreach (IObservador ob in observers) 
                {
                    ob.Update(this);
                }
            }
        }
    }
}
