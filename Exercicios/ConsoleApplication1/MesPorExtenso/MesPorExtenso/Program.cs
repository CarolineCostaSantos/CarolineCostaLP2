using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            string v;

            string data = Console.ReadLine();    // "25/04/1954"

            string pedacoDoMes = data.Substring( 4, 2);  // "04"
            mes = int.Parse(pedacoDoMes); // 4

             switch(mes)
             {
                 case 01: v = "janeiro"; break;
                 case 02: v = "fevereiro"; break;
                 case 03: v = "março";break;
                 case 04: v = "abril";break;
                 case 05: v = "maio"; break;
                 case 06: v = "junho";break;
                 case 07: v = "julho"; break;

                 case 08:

                         v = "agosto";

                         break;

                 case 09:

                         v = "setembro";

                         break;

                 case 10:

                         v = "outubro";

                         break;

                 case 11:

                         v = "novembro";

                         break;

                 case 12:

                         v = "dezembro";

                         break;
                 default:
                         v = ""; break;

             }
             Console.WriteLine("{0} de {1} de {2}", data);
         
                



                

           
        }
    }
}
