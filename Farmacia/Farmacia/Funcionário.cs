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

        private int cpf;
        public int Cpf {
            get { return cpf; }
        }

        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Data { get; set; }
        public string Cargo { get; set; }

        SqlConnection conexão = new SqlConnection("Data Source=(localdb)lptrab;Initial Catalog = Farmacia;Integrated Security = SSPI;");
        SqlCommand cmd = new SqlCommand();

        public void Cadastro()
        {
            Console.WriteLine("Nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Registro: ");
            nRegistro = int.Parse(Console.ReadLine());

            Console.WriteLine("Cpf: ");
            cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Endereço: ");
            Endereco = Console.ReadLine();

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

            cmd.Connection = conexão;
            cmd.CommandText = @"INSERT
                                INTO Funcionario(nome, registro, cpf, endereço, telefone, e-mail, cargo, salario, admissão)
                                VALUES(@nome, @registro, @cpf, @endereço, @telefone, @e-mail, @cargo, @salario, @admissão );";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@registro", nRegistro);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@endereço", Endereco);
            cmd.Parameters.AddWithValue("@telefone", Telefone);
            cmd.Parameters.AddWithValue("@e-mail", Email);
            cmd.Parameters.AddWithValue("@cargo", Cargo);
            cmd.Parameters.AddWithValue("@salario", Salario);
            cmd.Parameters.AddWithValue("@admissão", Data);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            Console.WriteLine("Funcionário cadastrado!");
        }

    }
}
