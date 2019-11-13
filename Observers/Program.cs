using System;

namespace Observers
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyReader kr = new KeyReader();
            IObservador kts = new KeyToScreen();
            IObservador ktf = new KeyToFile("lp2.txt");

            kr.RegisterObserver(kts);
            kr.RegisterObserver(ktf);

            kr.Execute();
            
        }
    }
}
