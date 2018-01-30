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
        public int Estoque { get; set; }
        public string Referencia { get; set; }

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

            Console.WriteLine("Quantidade em estoque: ");
            Estoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Referência: ");
            Referencia = Console.ReadLine();

            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT
                                INTO Produto(codigo, nome, marca, validade, preco, estoque, referencia)
                                VALUES (@codigo, @nome, @marca, @validade, @preco, @estoque, @referência);";

            cmd.Parameters.AddWithValue("@código", codigo);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@validade", Validade);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@estoque", Estoque);
            cmd.Parameters.AddWithValue("@referência", Referencia);

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
                cmd.CommandText = string.Format( @"SELECT nome, marca, preco, estoque
                                                   FROM Produto
                                                   WHERE codigo = {0}", codigo);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        nome = reader.GetString(0);
                        marca = reader.GetString(1);
                        Preco = reader.GetDouble(2);
                        Estoque = reader.GetInt32(3);

                        Console.WriteLine(" Produto: {0}  Marca: {1}      Preço: {2}", nome, marca, Preco);
                    }
       
                    QtdEstoque(Preco, Total, Estoque, codigo);
                }

                else
                {
                    Console.WriteLine("Produto não encontrado!");
                }

                cmd.Connection.Close();

                Console.WriteLine("Aperte ENTER para finalizar a compra");
                Console.ReadKey();
            }

            while ( finalizar != ConsoleKey.Enter);
        }


        public void QtdEstoque(double preco, double total, int estoque, int codigo)

        {
            if (estoque <= 0)
            {
                Console.Beep(698, 800);
                Console.WriteLine("Produto sem estoque!");

                Console.WriteLine(" Total: {0}", total);
            }

            else if (estoque <= 5 && estoque > 0)
            {
                Console.Beep(698, 400);
                Console.WriteLine("Baixa quantidade em estoque!");

                total += preco;
                Console.WriteLine(" Total: {0}", total);

                estoque -= 1;

                UpdateEstoque(codigo, estoque);

            }

            else
            {
                total += preco;
                Console.WriteLine(" Total: {0}", total);

                estoque -= 1;

                UpdateEstoque(codigo, estoque);
            }
        }

        public void QtdEstoque(int codg)
        {
            cmd.Connection = conexao;
            cmd.CommandText = string.Format(@"SELECT nome, estoque
                                              FROM Produto
                                              WHERE codigo = {0}", codg);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    nome = reader.GetString(0);
                    Estoque = reader.GetInt32(1);
                }

                if(Estoque <= 0)
                {
                    Console.WriteLine("{0} não possui estoque!", nome);
                }

                else if(Estoque > 0 && Estoque <= 5)
                {
                    Console.WriteLine("{0} possui baixa quantidade em estoque: {1}", nome, Estoque);
                }

                else
                {
                    Console.WriteLine("{0} pussui {1} unidade(s) em estoque!", nome, Estoque);
                }
            }

            else
            {
                Console.WriteLine("Produto não encontrado!");
            }

            cmd.Connection.Close();
        }

            public void UpdateEstoque(int cod, int etq)
            {
                cmd.Connection = conexao;
                cmd.CommandText = @"UPDATE Produto 
                                    SET estoque = @estoque
                                    WHERE codigo = @código";

                cmd.Parameters.AddWithValue("@estoque", etq);
                cmd.Parameters.AddWithValue("@código", cod);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }

        public void Consulta()
        {
            Console.WriteLine("Código do produto: ");
            codigo = int.Parse(Console.ReadLine());

            cmd.Connection = conexao;
            cmd.CommandText = string.Format(@"SELECT codigo, nome, marca, preco, referencia
                                              FROM Produto
                                              WHERE codigo = {0}", codigo);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    codigo = reader.GetInt32(0);
                    nome = reader.GetString(1);
                    marca = reader.GetString(2);
                    Preco = reader.GetDouble(3);
                    Referencia = reader.GetString(4);

                    Console.WriteLine("{0}  {1}  {2}   {3}", codigo, nome, marca, Preco);
                }

                cmd.CommandText = string.Format(@"SELECT codigo, nome, marca, preco, referencia
                                                  FROM Produto
                                                  WHERE referencia = {0}", Referencia);

                reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    Console.WriteLine("OUTROS: ");

                    while(reader.Read())
                    {
                        codigo = reader.GetInt32(0);
                        nome = reader.GetString(1);
                        marca = reader.GetString(2);
                        Preco = reader.GetDouble(3);
                        Referencia = reader.GetString(4);

                        Console.WriteLine(" {0}  {1}  {2}   {3}", codigo, nome, marca, Preco);
                    }
                }

                else
                {
                    Console.WriteLine("Não foram encontrados outros produtos parecidos!");
                }
            }

            else
            {
                Console.WriteLine("Produto não encontrado!");
            }

            cmd.Connection.Close();
        }
        

    }
}
