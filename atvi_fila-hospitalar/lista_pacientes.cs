using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvi_fila_hospitalar
{
    class lista_pacientes:cadastro_paciente
    {
        public string fila;
        public void lista()
        {

            Console.WriteLine(nome[0]);
            Console.WriteLine(nome[1]);
            Console.WriteLine(nome[2]);
            Console.WriteLine(nome[3]);
            Console.WriteLine(nome[4]);
            Console.ReadKey();
        }
    }
}
