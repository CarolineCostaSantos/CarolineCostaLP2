using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    class Funcionário
    {
        private int nRegistro;
        public int NRegistro {
            get { return nRegistro; }
        }

        private string cpf;
        public string Cpf {
            get { return cpf; }
        }

        public string Nome { get; set; }
        public double Salario { get; set; }

        private string endereco;
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        private string cep;
        public string cepA { get; set; }
        public string cepB { get; set; }
        public string Cep
        {
            get { return string.Format("{0}-{1}", cepA, cepB); }
        }
        public string Endereco {
            get {return string.Format("{0}, {1} - {2}\n Complemento:{3}\n CEP: {4}", Rua, Numero, Bairro, Complemento, Cep); }
        }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Data { get; set; }
        public string Cargo { get; set; }

        SqlConnection conexao = new SqlConnection("Data Source=EN2LIC_014;Initial Catalog=Farmacia;Integrated Security=SSPI;");
        SqlCommand cmd = new SqlCommand();

        public void Cadastro()
        {
            Console.WriteLine("Nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Registro: ");
            nRegistro = int.Parse(Console.ReadLine());

            Console.WriteLine("Cpf: ");
            cpf = Console.ReadLine();

            Console.WriteLine("Endereço\n Rua: ");
            Rua = Console.ReadLine();

            Console.WriteLine(" Número ");
            Numero = Console.ReadLine();

            Console.WriteLine(" Bairro ");
            Bairro = Console.ReadLine();

            Console.WriteLine(" Complemento ");
            Complemento = Console.ReadLine();

            Console.WriteLine(" Cep ");
            cep = Console.ReadLine();
            string cepa = cep.Substring(0, 5);
            cepA = cepa;
            string cepb = cep.Substring(5, 3);
            cepB = cepb;


            Console.WriteLine("Telefone: ");
            Telefone = Console.ReadLine();

            Console.WriteLine("E-mail: ");
            Email = Console.ReadLine();

            Console.WriteLine("Cargo: ");
            Cargo = Console.ReadLine();

            Console.WriteLine("Salário: ");
            Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Data de admissão: ");
            Data = Console.ReadLine();

            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT
                                INTO Funcionario(nome, registro, cpf, endereco, telefone, email, cargo, salario, admissao)
                                VALUES(@nome, @registro, @cpf, @endereco, @telefone, @email, @cargo, @salario, @admissao);";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@registro", nRegistro);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@endereco", Endereco);
            cmd.Parameters.AddWithValue("@telefone", Telefone);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@cargo", Cargo);
            cmd.Parameters.AddWithValue("@salario", Salario);
            cmd.Parameters.AddWithValue("@admissao", Data);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Console.WriteLine("Funcionário cadastrado!");
        }

    }
}
