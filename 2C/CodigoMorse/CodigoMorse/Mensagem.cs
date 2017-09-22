using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMorse
{
    class Mensagem
    {
        public string txt;

        private string[] tab = new string[]   {

        ".-", "-...","-.-.","-..",".","..-.","--.","....","..",
        ".---","-.-",".-..","--","-.","---",".--.","--.-",".-.",
        "...","-","..-","...-",".--","-..-","-.--","--.."};


        public string Codificar()
        {
            for (int i = 0; i < txt.Length; i++)
            {
                switch (txt[i])
                {
                    case 'A': return tab[i]; break;
                    case 'B': return tab[i]; break;
                    case 'C': return tab[i]; break;
                    case 'D': return tab[i]; break;
                    case 'E': return tab[i]; break;
                    case 'F': return tab[i]; break;
                    case 'G': return tab[i]; break;
                    case 'H': return tab[i]; break;
                    case 'I': return tab[i]; break;
                    case 'J': return tab[i]; break;
                    case 'K': return tab[i]; break;
                    case 'L': return tab[i]; break;
                    case 'M': return tab[i]; break;
                    case 'N': return tab[i]; break;
                    case 'O': return tab[i]; break;
                    case 'P': return tab[i]; break;
                    case 'Q': return tab[i]; break;
                    case 'R': return tab[i]; break;
                    case 'S': return tab[i]; break;
                    case 'T': return tab[i]; break;
                    case 'U': return tab[i]; break;
                    case 'V': return tab[i]; break;
                    case 'W': return tab[i]; break;
                    case 'X': return tab[i]; break;
                    case 'Y': return tab[i]; break;
                    case 'Z': return tab[i]; break;
                    default: Console.WriteLine("default case"); break;

                }
            }

        }

        public string Decodificar()
        {
            for ( int i = 0; i < txt.Length; i++)

                switch(txt[i])
                {
                    case tab[i]: return string.Format("A"); break;
                        
                }
        }

        public void Transmitir()
        {

            return;
        }
    }
}
