﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvi_fila_hospitalar
{
    class cadastro_paciente
    {

        public int idade;

        public string nome;

        public int telefone;

        public string endereco;

        public string rg;

        public string cpf;

        public string sexualidade;


        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite seu telefone");
            telefone = int.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite seu endereco");
            endereco = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite seu RG");
            rg = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite seu CPF");
            cpf = Console.ReadLine().ToUpper();

            Console.WriteLine("Qual sua sexualidade");
            sexualidade = Console.ReadLine().ToUpper();

        }

        public void ExibirCadastro()
        {
            Console.WriteLine(nome);
            Console.WriteLine(telefone);
            Console.WriteLine(endereco);
            Console.WriteLine(rg);
            Console.WriteLine(idade);
            Console.WriteLine(cpf);
            Console.WriteLine(sexualidade);
        }
    }
}
