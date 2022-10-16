using System;

namespace E5
{ /*    
   *Dado un triángulo representado por sus lados lado1, lado2 y lado3,
   * determinar e indicar según corresponda: “equilátero”,
   * “isósceles” o “escálenos”.
   */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int l1, l2, l3;
            Console.WriteLine("t");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());
            if (l1 == l2 && l3 == l2 )
            {
                Console.WriteLine("it's a equilateral");
            }else if ((l1 == l2 && l3 != l1) || (l3 == l2 && l3 != l1) || (l3 == l1 && l3 != l2))
            {
                Console.WriteLine("it's isosceles");
            }
            else
            {
                Console.WriteLine("it's scalene");
            }
                
        }
    }
}