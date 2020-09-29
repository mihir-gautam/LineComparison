using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
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

            double lineLength = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            Console.WriteLine("Length of the first line = " + lineLength);
        }
    }
}
