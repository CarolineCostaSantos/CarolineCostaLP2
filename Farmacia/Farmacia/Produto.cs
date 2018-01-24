using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    class Produto
    {
        private string nome;
        public string Nome { 
            get { return nome; }
        }

        private string marca;
        public string Marca {
            get { return marca; }
        }

        public string Validade { get; set; }
        public double Preco { get; set; }

        SqlConnection conexao = new SqlConnection("Data Source=(localdb)lptrab;Initial Catalog=Farmacia;Integrated Security=SSPI;");
        SqlCommand cmd = new SqlCommand();


        public void Cadastro()
        {
            Console.WriteLine("Nome do produto: ");
            nome = Console.ReadLine();

            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();

            Console.WriteLine("Validade: ");
            Validade = Console.ReadLine();

            Console.WriteLine("Preço: ");
            Preco = double.Parse(Console.ReadLine());

            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT
                                INTO Produto(nome, marca, validade, preco)
                                VALUES (@nome, @marca, @validade, @preco);";

            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("marca", marca);
            cmd.Parameters.AddWithValue("validade", Validade);
            cmd.Parameters.AddWithValue("preco", Preco);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Console.WriteLine("Produto cadastrado!");

        }

    }
}
