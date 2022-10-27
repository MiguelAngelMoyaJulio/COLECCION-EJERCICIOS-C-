using System;

namespace E10
{
    /**
     * Dados n valores numéricos, informar el mayor, el menor
     * y en que posición del conjunto fueron ingresados cada uno de ellos.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int amount = 0, num = 0, j = 0, max = 0, min = 0, posMax = 0, posMin = 0;
            Console.WriteLine("AMOUNT OF NUMBERS YOU WANNA ENTER");
            amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("ENTER A NUMBER");
                num = int.Parse(Console.ReadLine());
                if (j == 0)
                {
                    max = num;
                    min = num;
                    posMax = i + 1;
                    posMin = i + 1;
                    j++;
                }

                if (num > max)
                {
                    max = num;
                    posMax = i + 1;
                }

                if (num < min)
                {
                    min = num;
                    posMin = i + 1;
                }
            }
            Console.WriteLine("MAX NUMBER " + max + " POSITION : " + posMax);
            Console.WriteLine("MIN NUMBER " + min + " POSITION : " + posMin);
        }
    }
}