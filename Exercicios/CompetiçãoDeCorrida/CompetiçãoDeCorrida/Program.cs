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
            Console.WriteLine("informe o numero de competidores");
            int N = int.Parse (Console.ReadLine());


            Competidor obj = new Competidor();

            for (int i = 0; i <= N; i++) 
            {
                Competidor[] Aluno = new Competidor [i]; 
                Tem

                Console.WriteLine("Informe o nome do competidor {0} ", i);
                obj.Nome = Console.ReadLine();

                Console.WriteLine("Informe o tempo 1 do competidor {0}", i);
                obj.Tempo1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tempo 2 do competidor {0}", i);
                obj.Tempo2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tempo 3 do competidor {0}", i);
                obj.Tempo3 = double.Parse(Console.ReadLine());

                Double Tempo[i] = obj.TempOfi;
            }

            for (int i = 0; i <= N; i++ )
            {
               

            }
            
        }
    }
}
