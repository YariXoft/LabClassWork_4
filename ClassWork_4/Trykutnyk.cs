using System;

namespace TrykutnykNamespace
{
    internal class Trykutnyk
    {
        private double a;//сторони трикутника
        private double b; 
        private double c;

        public Trykutnyk(double a, double b, double c)
        {
            this.a = a;//тустую this.
            this.b = b;
            this.c = c;
        }

        public void DisplayTriangleInfo()
        {
            Console.WriteLine("\tТрикутник:");
            Console.WriteLine($"\tСторона a: {a}");
            Console.WriteLine($"\tСторона b: {b}");
            Console.WriteLine($"\tСторона c: {c}");
        }
    }
}
