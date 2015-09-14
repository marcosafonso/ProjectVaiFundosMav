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
            fundo.setMoeda("Real");

            //criar um cliente 
            Cliente cli = new Cliente();
            cli.setCodigo(1);
            cli.setNome("Marcos Afonso");

            //fazer uma aplicacao do cliente acima
            Aplicacao apl1 = new Aplicacao();
            apl1.setCodCliente(1);
            apl1.setValor(600f);
            apl1.setDataAplicacao(Convert.ToDateTime("28/12/2013"));
            
            //outra aplicacao do mesmo cliente
            Aplicacao apl2 = new Aplicacao();
            apl2.setCodCliente(1);
            apl2.setValor(1227f);
            apl2.setDataAplicacao(Convert.ToDateTime("27/01/2013"));

            //terceira aplicacao do mesmo cliente
            Aplicacao apl3 = new Aplicacao();
            apl3.setCodCliente(1);
            apl3.setValor(2600f);
            apl3.setDataAplicacao(Convert.ToDateTime("01/12/2014"));
            
            //chamar metodo de FundoInvestimento para adicionar a aplicacao nova
            fundo.novaAplicacao(apl1);
            fundo.novaAplicacao(apl2);
            fundo.novaAplicacao(apl3);

            //tentar fazer o resgate 
            fundo.resgate(600f, 1);

            //relatorio aplicacoes por cliente
            //fundo.relatorioPorCliente(1);

            Console.ReadKey();
            
        }
    }
}
