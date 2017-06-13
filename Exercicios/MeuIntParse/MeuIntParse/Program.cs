using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuIntParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número: ");
            string numStr = Console.ReadLine();

            Console.WriteLine(MeuIntParse(numStr));
        }

        public static int MeuIntParse(string nroComoStr)
        {
            int multi = 1;
            int numero = 0;

            for(int i=nroComoStr.Length-1; i >= 0; i--)
            {
                numero += (nroComoStr[i] - '0') * multi;
                multi *= 10;
            }
            return numero;    
        }
    }
}
