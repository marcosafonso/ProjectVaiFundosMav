using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Cliente_Juridico : Cliente
    {
        private string cnpj;

        public string getCNPJ()
        {
            return cnpj;
        }

        public void setCNPJ(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public override void imprimirCliente()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("CNPJ: {0}", cnpj);
            Console.WriteLine("Códido: {0}", codigo);
            Console.WriteLine("Telefone: {0}", numero);
            Console.WriteLine("Endereço: {0}", endereco);
            Console.WriteLine("------------------------------------------");
        }

    }
}
