using System;

namespace LibraryLesson
{

    public class MathLib
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Modulo(int a, int b)
        {
            return Sub(a, Mul(Div(a, b), b));
        }
    }
}
