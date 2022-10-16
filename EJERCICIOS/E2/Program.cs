using System;

namespace E2
{
    /**
     * Dados dos valores numéricos enteros a y b calcular e informar el cosiente a/b.
     * Considere que b puede ser cero.
     * En ese caso mostrar el correspondiente mensaje de error.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a=0, b=0;
            Console.WriteLine("enter two numbers");
            a= int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("cant divide by zero");
            }
            else
            {
                Console.WriteLine(a+" / "+b+" : "+(a/b));
            }
        }
    }
}