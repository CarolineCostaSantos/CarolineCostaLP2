using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    class Produto
    {
        private int id;
        private string nome;
        private double preco;
        public int Quantidade = 0;


        public int Id {

            get { return id; }
        }


        public string Nome {

            get { return nome; }
        }

        
        public double Preco {

            get { return preco; }
        }



        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }


        public void Retirada( int qtd)
        {
            if ( qtd <= Quantidade)
            {
                Quantidade -= qtd;
            }
        }

        public void Reposicao(int qtd)
        {
            if ( qtd > Quantidade)
            {
                Quantidade += qtd;
            }
        }

        public string Imprimir()
        {
            return string.Format("{0} - {1} - {2} - {3}", id, nome, preco, Quantidade);
        }
    }
}
