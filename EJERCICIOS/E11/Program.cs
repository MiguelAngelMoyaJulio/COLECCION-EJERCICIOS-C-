using System;
using Microsoft.SqlServer.Server;

namespace E11
{
    /**
     * Dado un conjunto de nombres y fechas de nacimiento con formato ddmmaaaa, que finaliza cuando se ingrese un
     * nombre igual a “fin”, informar el nombre de la persona con mayor edad y el de la más joven
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int date = 0, dateMax = 0, dateMin = 0, j = 0;
            string name = "";
            string nameMax = "";
            string nameMin = "";
            string res = "";
            Console.WriteLine("YOU WANNA LOAD DATA? Y/N");
            res = Console.ReadLine();

            while (res.Equals("y"))
            {
                Console.WriteLine("ENTER A DATE");
                date = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER A NAME");
                name = Console.ReadLine();

                if (j == 0)
                {
                    dateMax = date;
                    nameMax = name;
                    
                    dateMin = date;
                    nameMin = name;
                    j++;
                }


                if (date > dateMax)
                {
                    dateMax = date;
                    nameMax = name;
                }

                if (date < dateMin)
                {
                    dateMin = date;
                    nameMin = name;
                }

                Console.WriteLine("YOU WANNA LOAD DATA? Y/N");
                res = Console.ReadLine();
            }

            Console.WriteLine("DATE MAX : " + dateMax);
            Console.WriteLine("NAME MAX : " + nameMax);
            Console.WriteLine("");
            Console.WriteLine("DATE MIN : " + dateMin);
            Console.WriteLine("NAME MIN : " + nameMin);
        }
    }
}