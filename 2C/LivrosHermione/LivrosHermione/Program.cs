using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, PH, N;

            Console.WriteLine(" Quantos livros deseja verificar? ");
            N = int.Parse(Console.ReadLine());

            Livro[] livros = new Livro[N]; int[] dias = new int[N];

            for (int i = 0; i < N; i++)
            {

                livros[i] = new Livro();

                Console.WriteLine("Informe o título do livro");
                livros[i].Titulo = Console.ReadLine();

                Console.WriteLine("Informe a quantidade de páginas");
                livros[i].NdPg = int.Parse(Console.ReadLine());

                Console.WriteLine("Em quantos dias deve haver a devolução? ");
                livros[i].Devol = int.Parse(Console.ReadLine());

                Console.WriteLine(" Quantos horas tenho disponível? ");
                horas = int.Parse(Console.ReadLine());

                Console.WriteLine(" Quantas páginas leio por hora? ");
                PH = int.Parse(Console.ReadLine());

                dias[i] = livros[i].Dias(horas, PH);
            }

            for (int i = 0; i < N; i++)
            {

                if (dias[i] <= livros[i].Devol)

                    Console.WriteLine(" Irei ler o livro: {0} em {1} dias, antes da data de devolução", livros[i].Titulo, dias[i]);

                else

                    Console.WriteLine(" É impossível ler o livro {0} antes da data de devolução pois levrei {1} dias", livros[i].Titulo, dias[i]);
            }
        }
    }
}
