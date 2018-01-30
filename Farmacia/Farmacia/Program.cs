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
            Console.WriteLine(" 1 - Produto\n 2 - Cadastrar funcionário\n 3 - Entrega ");
            int opcoes = int.Parse(Console.ReadLine());

            Produto produto = new Produto();

            if (opcoes == 1)
            {
                Console.WriteLine(" 1 - Cadastrar\n 2 - Comprar\n 3 - Verificar estoque\n 4 - Consultar produto e semelhantes ");
                int opcoesP = int.Parse(Console.ReadLine());

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

                else if(opcoesP == 4)
                {
                    produto.Consulta();
                }
            }

            else if (opcoes == 2)
            {
                Console.WriteLine(" 1 - Cadastrar\n 2 - Atualizar\n 3 - ");
                int opcoesF = int.Parse(Console.ReadLine());
                Funcionário funcionario = new Funcionário();

                if (opcoesF == 1)
                {
                    funcionario.Cadastro();
                }
            }

            else if (opcoes == 3)
            {
                Console.WriteLine(" 1 - Cadastrar cliente\n 2 - Cliente já cadastrado");
                int opcoesC = int.Parse(Console.ReadLine());
                Cliente cliente = new Cliente();

                if(opcoesC == 1)
                {
                    Console.WriteLine("Informe o telefone: ");
                    int telefone = int.Parse(Console.ReadLine());

                    cliente.Consulta(telefone);

                    produto.Consulta();
                    produto.Compra();
                    cliente.UpdateData(telefone);
                }

                else if(opcoesC == 2)
                {
                    Console.WriteLine("Informe o telefone: ");
                    int telefone = int.Parse(Console.ReadLine());

                    cliente.Consulta(telefone);

                    produto.Consulta();
                    produto.Compra();
                    cliente.UpdateData(telefone);

                }
            }

            Console.ReadKey();
        }
    }
}
