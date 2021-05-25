using LibraryLesson;
using System;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var OnePlusTwo = MathLib.Add(1, 2);
            var NbrMinNbr = MathLib.Sub(5, 3);
            var NbrMulNbr = MathLib.Mul(2, 5);
            var NbrDivNbr = MathLib.Div(6, 3);
            var ans = MathLib.Modulo(5, 3);
            
        }
    }
}
