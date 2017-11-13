using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vektor = new int[10] { 9, 3, 4, 2, 17, 32, 63, 54, 1, 8, };
            int[] vektorKopje = vektor;
            int Min1 = 999;
            int Min2 = 999;
            for (int i = 0; i < vektor.Length; i++)
            {
                
                
                    if (vektor[i] < Min1)
                    {
                        Min1 = vektor[i];

                    }
                
            }
            for (int i = 0; i < vektor.Length; i++)
            {
                if (vektor[i] < Min2 && vektor[i] != Min1)
                {
                    Min2 = vektor[i];
                    
                }
            }
            var list = vektor.ToList();
            for (int k=0;k<list.Count;k++)
            {
                if(list[k]==Min1)
                {
                    list.RemoveAt(k--);
                }
                if(list[k]==Min2)
                {
                    list.RemoveAt(k--);
                }
            }

            vektor = list.ToArray();

            for (int j = 0; j < vektorKopje.Length; j++)
            {
                Console.Write(vektorKopje[j]);
                Console.Write("\t");
            }

            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Dy numrat me te vegjel te Vektorit jane:\t" + Min1 + " dhe " + Min2);
            Console.Write("\n");
            Console.Write("\n");

            for (int i = 0; i < vektor.Length; i++)
            {
                Console.Write(vektor[i]);
                Console.Write("\t");
                
            }   
        }
    }
}
