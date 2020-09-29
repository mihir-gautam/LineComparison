using System;
using System.Net;
using System.Numerics;

namespace LineComparison
{
    class Program
    {
        static double lengthOfLine()
        {
            Console.WriteLine("Input the X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the X2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            
            double lineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lineLength;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison computation program");

            Console.WriteLine("Enter the coordinates of line 1");
            double LengthOfLine1 = lengthOfLine();
            Console.WriteLine("Length of line 1 : " + LengthOfLine1);

            Console.WriteLine("Enter the coordinates of line 2");
            double LengthOfLine2 = lengthOfLine();
            Console.WriteLine("Length of line 2 : " + LengthOfLine2);

            if(LengthOfLine1 == LengthOfLine2)
            {
                Console.WriteLine("Both lines are equal in length");
            }
            else if (LengthOfLine1 > LengthOfLine2)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is smaller than Line 2");
            }
        }

    }
}
