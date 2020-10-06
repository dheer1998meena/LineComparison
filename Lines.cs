using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class Lines
    {
        public void Comparison()
        {
            double[] length = new double[2];
            int count = 0;
            while (count < 2)
            {
                int X1, X2, Y1, Y2;
                Random radom = new Random();
                X1 = radom.Next(-100, 100);
                X2 = radom.Next(-100, 100);
                Y1 = radom.Next(-100, 100);
                Y2 = radom.Next(-100, 100);
                Console.WriteLine("The coordinates are : (" + X1 + " " + Y1 + ") (" + X2 + " " + Y2 + ")");
                length[count] = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                Console.WriteLine("Length of the line : " + Math.Round(length[count], 2));
                count++;
            }
            int result = length[0].CompareTo(length[1]);
            if (result < 0)
            {
                Console.WriteLine("Line 1 is smaller than line 2.");
            }
            else if (result == 0)
            {
                Console.WriteLine("Line 1 is  equal line 2 :");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than line 2");
            }
        }
    }
}
