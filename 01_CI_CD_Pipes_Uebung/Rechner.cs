using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CI_CD_Pipes_Uebung
{
    public class Rechner
    {
        public static int Addiere(int a, int b) => a + b;
        public static int Subtrahiere(int a, int b) => a - b;
        public static int Multipliziere(int a, int b) => a * b;
        public static int Dividiere(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division durch 0 ist nicht erlaubt.");
            return a / b;
        }
    }
}
