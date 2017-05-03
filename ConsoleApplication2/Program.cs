using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pala=Console.ReadLine().ToLower();
            int cont=0;
            
            for (int i=0;i<pala.Length;i++)
            {
                switch(pala[i])
                {
                    case 'a':
                        cont++;
                        break;
                            
                    case 'e':
                        cont++;
                        break;

                    case 'i':
                        cont++;
                        break;

                    case 'o':
                        cont++;
                        break;

                    case 'u':
                        cont++;
                        break;                    
                }
            }
            Console.WriteLine(cont);



        }
    }
}
