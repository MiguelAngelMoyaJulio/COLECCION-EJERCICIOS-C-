using System;

namespace E13
{
    /**
     * Desarrollar un programa tal que, dado un valor entero positivo que se ingresa por
     * teclado indique si se trata de un número primo o no.
     * Nota: los números primos son aquellos valores enteros positivos que solo
     * son divisibles por sí mismos y por la unidad.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = 0, tot = 0;
            Console.WriteLine("ENTER A NUMBER");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    tot++;
                }
            }

            if (tot==2)
            {
                Console.WriteLine("IT'S PRIME NUMBER");
            }else{
                Console.WriteLine("IT'S NOT PRIME NUMBER");
            }
        }
    }
}