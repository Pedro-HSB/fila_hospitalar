using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvi_fila_hospitalar
{
    class Program
    {
        static void Main(string[] args)
        {
            string start;

            Console.WriteLine("deseja iniciar o programa ?");
            start = Console.ReadLine();
                while (start=="yes" || start == "sim")
            {
                Console.WriteLine("entrar em:");
                Console.WriteLine("------------------");
                Console.WriteLine("lista de pacientes");
                Console.WriteLine("dados do paciente");
                Console.WriteLine("cadastro de paciente");
                Console.WriteLine("------------------");
                start = Console.ReadLine();
                if (start == "lista de pacientes")
                {
                    lista_pacientes f = new lista_pacientes();
                    f.lista();
                }
                if (start == "dados do pacientes" )
                {
                    dados_pacientes d = new dados_pacientes();
                    d.ExibirCadastro();
                }
                if(start == "cadastro de paciente")
                {
                    Pessoa a = new Pessoa();
                    a.cadastrar();
                    Console.WriteLine("Deseja realizar outro cadastro ?");
                    start=Console.ReadLine();
                    while(start == "sim")
                    {
                        Pessoa b= new Pessoa();
                        b.cadastrar();
                        Console.WriteLine("Deseja realizar outro cadastro ?");
                        start = Console.ReadLine();
                    }if (start == "nao")
                    {
                        Console.WriteLine("Deseja fazer outra operacao");
                        start = Console.ReadLine();
                    }
                        if (start == "sim")
                        {
                            Console.WriteLine("entrar em:");
                            Console.WriteLine("------------------");
                            Console.WriteLine("lista de pacientes");
                            Console.WriteLine("dados do paciente");
                            Console.WriteLine("cadastro de paciente");
                            Console.WriteLine("------------------");
                            start = Console.ReadLine();
                    }
                        else if (start =="nao")
                        {
                            Console.WriteLine("programa encerrando");
                            Console.ReadKey();
                        }
                    }

                    Console.ReadKey();
                }
                

            if (start=="no"||start=="nao")
            {
                Console.WriteLine("programa encerrando");
                Console.ReadKey();
            }



        }
    }
}
