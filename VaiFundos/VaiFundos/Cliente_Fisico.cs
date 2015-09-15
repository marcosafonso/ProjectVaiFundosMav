using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Cliente_Fisico : Cliente
    {
        private string cpf;

        public string getCPF()
        {
            return cpf;
        }

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public override void imprimirCliente()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("CPF: {0}", cpf);
            Console.WriteLine("Códido: {0}", codigo);
            Console.WriteLine("Telefone: {0}", numero);
            Console.WriteLine("Endereço: {0}", endereco);
            Console.WriteLine("------------------------------------------");
        }
    }
}
