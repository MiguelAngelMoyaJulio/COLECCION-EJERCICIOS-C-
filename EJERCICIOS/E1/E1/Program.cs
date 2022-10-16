using System;

namespace E1
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("ingrese dos numeros");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " : " + (a + b));
            Console.WriteLine(a + " - " + b + " : " + (a - b));
            Console.WriteLine(a + " * " + b + " : " + (a * b));
        }
    }
}