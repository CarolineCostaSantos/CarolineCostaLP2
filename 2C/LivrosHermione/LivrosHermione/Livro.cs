using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Livro
    {
        public string Titulo;
        public int NdPg;
        public int Devol;
        public int qDias;

        public int Dias(int horas, int PH)
        {
            int qtd = PH * horas;

            qDias = NdPg / qtd;

            return qDias;
        }
        
    }
}
