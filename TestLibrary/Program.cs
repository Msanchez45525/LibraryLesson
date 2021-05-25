using LibraryLesson;
using System;

namespace TestLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            var OnePlusTwo = MathLib.Add(1, 2);

            var SubTenV = MathLib.Sub(10, 5);

            var TenFive = MathLib.Mult(10, 5);

            var TenOne = MathLib.Div(10, 1);

            var TenTwo = MathLib.Modulo(10, 2);
        }
        
        

    }

}
