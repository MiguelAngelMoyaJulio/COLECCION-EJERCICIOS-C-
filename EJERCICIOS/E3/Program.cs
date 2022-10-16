using System;

namespace E3
{
    /**
     * Dados tres valores numéricos diferentes
     * , indicar cual es el menor,
     * cual está en el medio y cual es el mayor.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a=0, b=0, c=0;
            Console.WriteLine("enter three numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine(a + " is the largest number");
                Console.WriteLine(b + " is the number in the middle");
                Console.WriteLine(c + " is the smallest number");
            }
            else if (a > c && c > b)
            {
                Console.WriteLine(a + " is the largest number");
                Console.WriteLine(c + " is the number in the middle");
                Console.WriteLine(b + " is the smallest number");
            }
            
            if (b > a && a > c)
            {
                Console.WriteLine(b + " is the largest number");
                Console.WriteLine(a + " is the number in the middle");
                Console.WriteLine(c + " is the smallest number");
            }
            else if (b > c && c > a)
            {
                Console.WriteLine(b + " is the largest number");
                Console.WriteLine(c + " is the number in the middle");
                Console.WriteLine(a + " is the smallest number");
            }
            
            if (c > a && a > b)
            {
                Console.WriteLine(c + " is the largest number");
                Console.WriteLine(a + " is the number in the middle");
                Console.WriteLine(b + " is the smallest number");
            }
            else if (c > b && b > a)
            {
                Console.WriteLine(c + " is the largest number");
                Console.WriteLine(b + " is the number in the middle");
                Console.WriteLine(a + " is the smallest number");
            }
            

            

            
        }
    }
}
