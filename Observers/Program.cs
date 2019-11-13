using System;

namespace Observers
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyReader kr = new KeyReader();
            IObservador<ConsoleKey> kts = new KeyToScreen();
            IObservador<ConsoleKey> ktf = new KeyToFile("lp2.txt");

            kr.RegisterObserver(kts);
            kr.RegisterObserver(ktf);

            kr.Execute();
            
        }
    }
}
