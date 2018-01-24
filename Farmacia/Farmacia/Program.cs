using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1 - Produto\n 2 - Cadastrar funcionário\n 3 - ");
            int opcoes = int.Parse(Console.ReadLine());

            if(opcoes == 1)
            {
                Console.WriteLine(" 1 - Cadastrar\n 2 - ");
                int opcoesP = int.Parse(Console.ReadLine());

                if (opcoesP == 1)
                {
                    Produto produto = new Produto();
                    produto.Cadastro();
                }
            }

            else if (opcoes == 2)
            {
                Console.WriteLine(" 1 - Cadastrar\n 2 - Atualizar\n 3 - ");
                int opcoesF = int.Parse(Console.ReadLine());

                if(opcoesF == 1)
                {
                    Funcionário funcionario = new Funcionário();
                    funcionario.Cadastro();
                }
            }

            Console.ReadKey();
        }
    }
}
