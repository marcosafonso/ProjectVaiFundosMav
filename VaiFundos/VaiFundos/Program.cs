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
            //criar um fundo
            FundoInvestimento fundo = new FundoInvestimento();

            fundo.setNome("Fundo DI");
            fundo.setCodigo(12);
            fundo.setSigla("DI");

            //criar um cliente 
            Cliente cli = new Cliente();
            cli.setCodigo(1);
            cli.setNome("Marcos Afonso");

            //fazer uma aplicacao do cliente acima
            Aplicacao apl1 = new Aplicacao();
            apl1.setCodCliente(1);
            apl1.setValor(600f);

            //outra aplicacao do mesmo cliente
            Aplicacao apl2 = new Aplicacao();
            apl2.setCodCliente(1);
            apl2.setValor(1200f);

            //chamar metodo de FundoInvestimento para adicionar a aplicacao nova
            fundo.novaAplicacao(apl1);
            fundo.novaAplicacao(apl2);

            //tentar fazer o resgate 
            fundo.resgate(1000f, 1);


            Console.ReadKey();
            
        }
    }
}
