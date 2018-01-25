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

        private int codigo;
        public int Codigo {
            get { return codigo; }
        }

        public string Validade { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        SqlConnection conexao = new SqlConnection("Data Source=(localdb)lptrab;Initial Catalog=Farmacia;Integrated Security=SSPI;");
        SqlCommand cmd = new SqlCommand();


        public void Cadastro()
        {
            Console.WriteLine("Nome do produto: ");
            nome = Console.ReadLine();

            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();

            Console.WriteLine("Código: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Validade: ");
            Validade = Console.ReadLine();

            Console.WriteLine("Preço: ");
            Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            Quantidade = int.Parse(Console.ReadLine());

            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT
                                INTO Produto(codigo, nome, marca, validade, preco, quantidade)
                                VALUES (@codigo, @nome, @marca, @validade, @preco, @quantidade);";

            cmd.Parameters.AddWithValue("@código", codigo);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@validade", Validade);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Console.WriteLine("Produto cadastrado!");

        }


        public double Total { get; set; } = 0;
        ConsoleKey finalizar = ConsoleKey.K;

        public void Compra()
        {
            do
            {
                Console.WriteLine("Código do produto: ");
                codigo = int.Parse(Console.ReadLine());

                cmd.Connection = conexao;
                cmd.CommandText = string.Format( @"SELECT nome, marca, preco
                                                   FROM Produto
                                                   WHERE codigo = '{0}'", codigo);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        nome = reader.GetString(0);
                        marca = reader.GetString(1);
                        Preco = reader.GetDouble(2);

                        Console.WriteLine(" Produto: {0}  Marca: {1}      Preço: {2}", nome, marca, Preco);
                    }
                }

                else
                {
                    Console.WriteLine("Código não encontrado!");
                }

                cmd.Connection.Close();

                 Total += Preco;
                Console.WriteLine(" Total: {0}", Total);

                Quantidade -= 1;

                cmd.CommandText = @"UPDATE Produto 
                                    SET quantidade = @quantidade
                                    WHERE codigo = @código";

                cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@código", codigo);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                Console.WriteLine("Aperte ENTER para finalizar a compra");
                Console.ReadKey();
            }

            while ( finalizar != ConsoleKey.Enter);
        }

    }
}
