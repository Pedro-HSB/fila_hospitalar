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

            Console.WriteLine("Deseja Iniciar o Programa ?");
            start = Console.ReadLine();
                while (start=="yes" || start == "sim")
            {
                Console.WriteLine("Entrar Em:");
                Console.WriteLine("------------------");
                Console.WriteLine("Lista De Pacientes");
                Console.WriteLine("Dados Do Paciente");
                Console.WriteLine("Cadastro De Paciente");
                Console.WriteLine("Para Encerrar o Programa Precione 'q' ");
                Console.WriteLine("------------------");
                start = Console.ReadLine();
                if (start == "Lista De Pacientes" || start == "lista de pacientes")
                {
                    Lista_pacientes f = new Lista_pacientes();
                    f.lista();
                }
                if (start == "Dados Do Paciente" || start == "dados do paciente")
                {
                    Console.WriteLine("----------");
                    Pessoa a = new Pessoa();
                    Dados_pacientes b = new Dados_pacientes();
                    a.ExibirCadastro();
                }
                if(start == "Cadastro De Paciente"||start == "cadastro de paciente")
                {
                    Pessoa a = new Pessoa();
                    a.Cadastrar();
                    Console.WriteLine("Deseja Realizar Outro Cadastro ?");
                    start=Console.ReadLine();
                    while(start == "sim")
                    {
                        Pessoa b= new Pessoa();
                        b.Cadastrar();
                        Console.WriteLine("Deseja Realizar Outro Cadastro ?");
                        start = Console.ReadLine();
                    }if (start == "nao")
                    {
                        Console.WriteLine("Deseja Fazer Outra Operacao");
                        start = Console.ReadLine();
                    }
                        if (start == "sim")
                        {
                        Console.WriteLine("Entrar Em:");
                        Console.WriteLine("------------------");
                        Console.WriteLine("lista De Pacientes");
                        Console.WriteLine("Dados Do Paciente");
                        Console.WriteLine("Cadastro De Paciente");
                        Console.WriteLine("------------------");
                        start = Console.ReadLine();
                    }
                        else if (start =="nao")
                        {
                            Console.WriteLine("Programa Encerrando");
                            Console.ReadKey();
                        }
                    }

                    Console.ReadKey();
                }
                

            if (start=="no"||start=="nao"||start=="q"||start=="Q")
            {
                Console.WriteLine("Programa Encerrando");
                Console.ReadKey();
            }



        }
    }
}
