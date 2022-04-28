using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvi_fila_hospitalar
{
    class cadastro_paciente
    {

        int n;

        public string[] nome = new string[10];

        public int[] telefone = new int[10];

        public string[] endereco = new string[10];

        public int[] idade = new int[10];

        private string[] RG = new string[10];

        private string[] CPF = new string[10];

        public string[] sexualidade = new string[10];
        
        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome");
            nome[n] = Console.ReadLine().ToUpper();
         
            Console.WriteLine("Digite seu telefone");
            telefone[n] = int.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite seu endereco");
            endereco[n] = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite seu RG");
            RG[n] = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite sua idade");
            idade[n] = int.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite seu CPF");
            CPF[n] = Console.ReadLine().ToUpper();

            Console.WriteLine("Qual sua sexualidade");
            sexualidade[n] = Console.ReadLine().ToUpper();

        }
    }
}
