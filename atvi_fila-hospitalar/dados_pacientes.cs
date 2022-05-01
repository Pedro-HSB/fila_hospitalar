using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvi_fila_hospitalar
{
    class dados_pacientes:Pessoa
    {
        public int idade;

        public string nome;

        public int telefone;

        public string endereco;

        public string rg;

        public string cpf;

        public string sexualidade;
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
