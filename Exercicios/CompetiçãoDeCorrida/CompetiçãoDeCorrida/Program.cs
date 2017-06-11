using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetiçãoDeCorrida
{
    class Program
    {
        static void Main(string[] args)
        {
            double MenorT = 100000; string Venc = "Eu";

            Console.WriteLine("informe o numero de competidores");
            int N = int.Parse (Console.ReadLine());


            Competidor obj = new Competidor();

            for (int i = 0; i <= N; i++)
            {
                Competidor[] Alunos = new Competidor[i];

                Console.WriteLine("Informe o nome do competidor {0} ", i);
                obj.Nome = Console.ReadLine();
            }

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("Informe o tempo 1 do competidor {0}", i);
                obj.Tempo1 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("Informe o tempo 2 do competidor {0}", i);
                obj.Tempo2 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("Informe o tempo 3 do competidor {0}", i);
                obj.Tempo3 = double.Parse(Console.ReadLine());
            }
            

            for (int i = 0; i <= N; i++ )
            {
                double[] Tempos = new double[i];

                Tempos[i] = obj.CalcularTempo;

                if ( Tempos[i] < MenorT)
                {
                    MenorT = Tempos[i];

                    Venc = Alunos[i].Nome;
                }

                Console.WriteLine(Venc);
            }


            
        }
    }
}
