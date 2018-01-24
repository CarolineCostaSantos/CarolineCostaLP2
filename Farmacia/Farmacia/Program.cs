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
            Console.WriteLine(" 1 - Cadastrar produto\n 2 -");
            int opcoes = int.Parse(Console.ReadLine());

            if(opcoes == 1)
            {
                Produto produto = new Produto();
                produto.Cadastro();
            }

            Console.ReadKey();
        }
    }
}
