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
                Console.WriteLine(" 1 - Cadastrar\n 2 - Comprar\n 3 - Verificar estoque\n 4 - ");
                int opcoesP = int.Parse(Console.ReadLine());
                Produto produto = new Produto();

                if (opcoesP == 1)
                {
                    produto.Cadastro();
                }

                else if (opcoesP == 2)
                {
                    produto.Compra();
                }

                else if (opcoesP == 3)
                {
                    Console.WriteLine("Código do produto: ");
                    int codigo = int.Parse(Console.ReadLine());

                    produto.QtdEstoque(codigo);
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
