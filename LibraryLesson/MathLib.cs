using System;

namespace LibraryLesson
{
    public class MathLib
    {
        private static int b;
        private static int a;

        // subtract multiply devide modulo
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }


        public static int Modulo(int a, int b)
            {
            return Sub(a,Mult(Div(a, b), b));

            
        }

        // modulo = Mod(a,b) = a - ((a/b)*b)
        // Mod(5,3) = 5 - ((5/3)*c)
    } //return Sub(a, Mult(Div(a, b),b));
}
