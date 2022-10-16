using System;

namespace E4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a=0, m=0, d=0;
            Console.WriteLine("enter year month and day");
            a = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("date : "+(a*1000+m*100+d));
            
        }
    }
}