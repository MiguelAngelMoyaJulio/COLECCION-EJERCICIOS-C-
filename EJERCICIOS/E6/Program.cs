using System;

namespace E6
{
    /**
     * Se ingresa un valor numérico entero n, se pide desarrollar un
     * algoritmo que muestre por consola los primeros n números naturales
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("cantidad de numeros naturales que desea ver");
            n = int.Parse(Console.ReadLine());
            if (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("el valor ingresado no es válido");
            }
        }
    }
}