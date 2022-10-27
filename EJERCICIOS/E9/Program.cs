using System;

namespace E9
{
    /**
 * Dado un valor numérico entero m, determinar e imprimir un listado
 * con los m primeros múltiplos de 3 que no sean múltiples de 5.
 */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int m = 0, i = 1, tot=0;
            Console.WriteLine("ENTER A NUMBER");
            m = int.Parse(Console.ReadLine());
            while (tot < m)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                    tot++;
                }
                i++;
            }
        }
    }
}