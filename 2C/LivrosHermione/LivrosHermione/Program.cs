﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, PH;
            Livro livros = new Livro();

            Console.WriteLine("Informe o título do livro");
            livros.Titulo = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de páginas");
            livros.NdPg = int.Parse (Console.ReadLine());

            Console.WriteLine("Em quantos dias deve haver a devolução? ");
            livros.Devol = int.Parse(Console.ReadLine());

            Console.WriteLine(" Quantos horas tenho disponível? ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine(" Quantas páginas leio por hora? ");
            PH = int.Parse(Console.ReadLine());



            Quais livros são impossiveis?

        }
    }
}