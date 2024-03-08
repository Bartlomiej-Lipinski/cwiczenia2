using System;

namespace ConsoleApplication1
{
    public class pro
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GetAvg(new int[] { 1, 2, 3, 4, 5 }));
        }
        static double GetAvg(int[] arr)
        {
            int sum = 0;
            foreach (var VARIABLE in arr)
            {
                sum += VARIABLE;
            }
            return (double)sum / arr.Length;
        }
    }
}