using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Codificar /n2- Decodificar /n3-Transmitir /n0-Sair");
            int dig = int.Parse(Console.ReadLine());

            Mensagem cod = new Mensagem();

             Console.WriteLine("Digite a menssagem");
             cod.txt = Console.ReadLine();

            if (dig == 1)
            {
               Console.WriteLine(cod.Codificar());

            }
            else if (dig == 2)
            {
                Console.WriteLine(cod.Decodificar());
            }
            else if (dig == 3)
            {
                Console.WriteLine(cod.Transmitir());
            }

            else
            {
               
            }
        }
    }
}
