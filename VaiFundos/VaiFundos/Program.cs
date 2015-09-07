using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Program
    {
        static void Main(string[] args)
        {
            FundoInvestimento fundo = new FundoInvestimento();

            fundo.setNome("Fundo DI");
            fundo.setCodigo(12);
            fundo.setSigla("DI");

            Cliente cli = new Cliente();
            cli.setCodigo(1);
            cli.setNome("Marcos Afonso");

            Aplicacao apl1 = new Aplicacao();
            apl1.setCodCliente(1);
            apl1.setValor(600f);

            fundo.novaAplicacao(apl1);



            Console.ReadKey();
            
        }
    }
}
