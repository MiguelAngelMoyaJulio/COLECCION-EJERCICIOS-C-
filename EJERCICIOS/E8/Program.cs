using System;

namespace E8
{
    /**
     * Se ingresa un valor numérico entero, se pide calcular e informar su factorial.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 0,fac=1;
            
            Console.WriteLine("ENTER A NUMBER");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }

            Console.WriteLine("FACTORIAL OF "+n+" IS "+fac);            
        }
    }
}