using System;

namespace E7
{
    /**
     * Dados dos valores numéricos enteros, calcular e
     * informar su producto mediante sumas sucesivas
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n=0, m = 0, total=0;
            Console.WriteLine("ingrese dos numeros");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            for (int i = 1; i <=m ; i++)
            {
                total = total + n;
            }

            Console.WriteLine("multiplicacion : "+total);
        }
    }
}