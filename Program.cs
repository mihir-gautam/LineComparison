using System;
using System.Net;
using System.Numerics;

namespace LineComparison
{
    class Program
    {
        static double lengthOfLine()
        {
            int x1, y1, x2, y2;
            Console.WriteLine("Input the X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            
            double lineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lineLength;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison computation program");
            Console.WriteLine("Enter the coordinates of line 1");
            double LengthOfLine1 = lengthOfLine();
            Console.WriteLine("Enter the coordinates of line 2");
            double LengthOfLine2 = lengthOfLine();

            if(LengthOfLine1 == LengthOfLine2)
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal!");
            }
        }

    }
}
