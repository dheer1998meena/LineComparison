using System;

namespace LineComparison
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int X1, X2, Y1, Y2;
            Random radom = new Random();
            X1 = radom.Next(-100, 100);
            X2 = radom.Next(-100, 100);
            Y1 = radom.Next(-100, 100);
            Y2 = radom.Next(-100, 100);
            Console.WriteLine("The coordinates are : " + X1 + " " + Y1 + " " + X2 + " " + Y2);
            double length = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Length of the line : " + Math.Round(length, 2));
        }
    }
}
