using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    struct Strstruct
    {
        private string myStr;

        public Strstruct(string myStr) 
        {
            this.myStr = myStr;
        }

        public void ConcatAndPrint(string str) 
        {
            Console.WriteLine(str + myStr);
        }
    }
}
