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
                if (start=="yes" || start == "sim")
            {
                Console.WriteLine("entrar em:");
                Console.WriteLine("------------------");
                Console.WriteLine("lista de pacientes");
                Console.WriteLine("dados do paciente");
                Console.WriteLine("cadastro paciente");
                Console.WriteLine("------------------");
                start = Console.ReadLine();
                if (start == "lista de pacientes")
                {

                }
                if (start == "dados do pacientes" )
                {

                }
                if (start == "cadastro paciente")
                {
                    cadastro_paciente cp = new cadastro_paciente();
                    cp.cadastrar();
                    Console.ReadKey();
                }
                
            }
            if (start=="no"||start=="nao")
            {
                Console.WriteLine("programa encerrando");
            }



        }
    }
}
