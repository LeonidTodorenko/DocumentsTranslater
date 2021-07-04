using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Helpers
{
    class Counter
    {
        public static int GetCurrentValue()
        {
            return currentValue++;
        }

        private static int currentValue = 10000000; //start value - 10 millions
    }
}
