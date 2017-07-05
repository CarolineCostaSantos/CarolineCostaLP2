using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            string Resp; int cont = 0;
            int A, B, C, D, E;
            Console.WriteLine(" Informe a quantidade de questões.");
            int N = Int16.Parse(Console.ReadLine());


            for ( int i = 0; i < N; i++)

            {
                Console.WriteLine(" Informe o tom médio de A: ");
                A = int.Parse(Console.ReadLine());

                Console.WriteLine(" Informe o tom médio de B: ");
                B = int.Parse(Console.ReadLine());

                Console.WriteLine(" Informe o tom médio de C: ");
                C = int.Parse(Console.ReadLine());

                Console.WriteLine(" Informe o tom médio de D: ");
                D = int.Parse(Console.ReadLine());

                Console.WriteLine(" Informe o tom médio de E: ");
                E = int.Parse(Console.ReadLine());


                if (A > 100 && A < 155)
                {
                    Resp = "*";
                }

                else if (B > 100 && B < 155)
                {
                    Resp = "*";
                }

                else if (C > 100 && C < 155)
                {
                    Resp = "*";
                }

                else if (D > 100 && D < 155)
                {
                    Resp = "*";
                }

                else if (E > 100 && E < 155)
                {
                    Resp = "*";
                }

                else if (A <= 100 && B >= 155 && C >= 155 && D >= 155 && E >= 155)
                {
                    Resp = "A"; cont++;
                }

                else if (A <= 100 && B >= 155 && C >= 155 && D >= 155 && E >= 155)
                {
                    Resp = "A"; cont++;
                }

                else if (B <= 100 && A >= 155 && C >= 155 && D >= 155 && E >= 155)
                {
                    Resp = "B"; cont++;
                }

                else if (C <= 100 && A >= 155 && B >= 155 && D >= 155 && E >= 155)
                {
                    Resp = "C"; cont++;
                }

                else if (D <= 100 && A >= 155 && B >= 155 && C >= 155 && E >= 155)
                {
                    Resp = "D"; cont++;
                }

                else if (E <= 100 && A >= 155 && B >= 155 && C >= 155 && D >= 155)
                {
                    Resp = "E"; cont++;
                }

                else
                {
                    Resp = "*";
                }

                if ( cont > 1 || cont < 1)
                {
                    Resp = "*";
                }

                Console.WriteLine(Resp);
            }


           
        }
    }
}
