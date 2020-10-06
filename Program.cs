using System;

namespace LineComparison
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Random radom = new Random();
            x1 = radom.Next(-100, 100);
            x2 = radom.Next(-100, 100);
            y1 = radom.Next(-100, 100);
            y2 = radom.Next(-100, 100);
            Console.WriteLine("The coordinates are : " + x1 + " " + y1 + " " + x2 + " " + y2);
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the line : " + Math.Round(length, 2));
        }
    }
}
