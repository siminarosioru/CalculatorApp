using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    //crearea clasei
    class CalculatorHelper
    {
        //membrii privati - field
        private decimal termen1;
        private decimal termen2;

        //default constructor
        public CalculatorHelper()
        {
            termen1 = 0;
            termen2 = 0;
        }

        //overload constructor
        public CalculatorHelper(decimal Termen1, decimal Termen2)
        {
            termen1 = Termen1;
            termen2 = Termen2;
        }

        //accesarea membrilor privati => get() method
        public decimal getTermen1()
        {
            //returneaza valoarea termenului 1(membrul privat)
            return termen1;
        }
        public decimal getTermen2()
        {
            //returneaza valoarea termenului 2(membrul privat)
            return termen2;
        }

        //crearea functiei pentru adunare
        public decimal calculAdunare()
        {
            return (termen1 + termen2);
        }

        //crearea functiei pentru scadere
        public decimal calculScadere()
        {
            return (termen1 - termen2);
        }

        //crearea functiei pentru inmultire
        public decimal calculInmultire()
        {
            return (termen1 * termen2);
        }

        //crearea functiei pentru impartire
        public decimal calculImpartire()
        {
            if(termen2  != 0)
                return termen1 / termen2;
            else
                return - 1;
        }
    }
}
