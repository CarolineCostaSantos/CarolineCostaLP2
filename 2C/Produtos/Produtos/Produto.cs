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
        public string marca;
        public double preco;
        private int estoque;


        public int Id {

            get { return id; }
        }


        public string Nome {

            get { return nome; }
        }

        
        public int Estoque {

            get { return estoque; }
        }



        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            estoque = 0;
        }


        public void Retirada( int qtd)
        {
            if ( qtd <= estoque)
            {
                estoque -= qtd;
            }

            else
            {
                throw new Exception();
            }
        }

        public void Reposicao(int qtd)
        {
            if ( qtd > estoque)
            {
                estoque += qtd;
            }
        }

        public string Imprimir()
        {
            return string.Format(" Produto {0} - {1} - R$ {2} - Estoque: {3}", id, nome, preco, estoque);
        }
    }
}
