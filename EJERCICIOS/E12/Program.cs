using System;
using System.Media;

namespace E12
{
    /**
     * Dada una serie de caracteres que conforman una oración, donde cada palabra está separada de la siguiente por un carácter blanco y la oración finaliza con un punto. Se pide informar:
     * Cantidad de veces que apareció cada vocal.
     * Cantidad de palabras que contiene la oración.
     * Cantidad de letras que posee la palabra más larga.
     */
    internal class Program
    {
        const string VOWEL_A = "a";
        const string VOWEL_E = "e";
        const string VOWEL_I = "i";
        const string VOWEL_O = "o";
        const string VOWEL_U = "u";
        const char DELIMITADOR = ' ';

        public static void Main(string[] args)
        {
            string phrase = "";
            string phrase2 = "";
            string[] words = null;
            int a = 0, e = 0, i = 0, o = 0, u = 0, spaces = 0, max = 0, l = 0;

            Console.WriteLine("ENTER A PHRASE");
            phrase = Console.ReadLine();
            phrase2 = phrase.ToLower();
            words = phrase2.Split(DELIMITADOR);

            for (int j = 0; j < phrase2.Length; j++)
            {
                if (phrase2.Substring(j, 1).Equals(VOWEL_A))
                {
                    a++;
                }

                if (phrase2.Substring(j, 1).Equals(VOWEL_E))
                {
                    e++;
                }

                if (phrase2.Substring(j, 1).Equals(VOWEL_I))
                {
                    i++;
                }

                if (phrase2.Substring(j, 1).Equals(VOWEL_O))
                {
                    o++;
                }

                if (phrase2.Substring(j, 1).Equals(VOWEL_U))
                {
                    u++;
                }

                if (phrase2.Substring(j, 1).Equals(" "))
                {
                    spaces++;
                }
            }

            for (int j = 0; j < words.Length; j++)
            {
                if (l == 0)
                {
                    max = words[j].Length;
                    l++;
                }

                if (max < words[j].Length)
                {
                    max = words[j].Length;
                }
            }

            Console.WriteLine("AMOUNT VOWELS A : " + a);
            Console.WriteLine("AMOUNT VOWELS E : " + e);
            Console.WriteLine("AMOUNT VOWELS I : " + i);
            Console.WriteLine("AMOUNT VOWELS O : " + o);
            Console.WriteLine("AMOUNT VOWELS U : " + u);
            Console.WriteLine("AMOUNT WORDS : " + (spaces + 1));
            Console.WriteLine("LONGEST WORD : "+max);
        }
    }
}