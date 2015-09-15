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

            int opcao = 0;
            List<Cliente> clientes = new List<Cliente>(100);
            Random randNum = new Random();

            //criando os fundos de investimento
            FundoInvestimento fundo1 = new FundoInvestimento();
            fundo1.setNome("Bolsa de Valores de São Paulo");
            fundo1.setCodigo(1);
            fundo1.setSigla("BOVESPA");
            fundo1.setMoeda("Real");

            FundoInvestimento fundo2 = new FundoInvestimento();
            fundo2.setNome("Bolsa de Mercadorias e Futuros");
            fundo2.setCodigo(2);
            fundo2.setSigla("BM&F");
            fundo2.setMoeda("Real");
            
            FundoInvestimento fundo3 = new FundoInvestimento();
            fundo3.setNome("NASDAQ Stock Market");
            fundo3.setCodigo(3);
            fundo3.setSigla("NASDAQ");
            fundo3.setMoeda("Dolar");

            FundoInvestimento fundo4 = new FundoInvestimento();
            fundo4.setNome("Bolsa de Valores de Nova York");
            fundo4.setCodigo(4);
            fundo4.setSigla("NYSE");
            fundo4.setMoeda("Dolar");

            while (opcao >= 0)
            {
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Fazer Aplicaçao");
                Console.WriteLine("3 - Fazer Resgate");
                Console.WriteLine("4 - Trasferir aplicãções de um fundo para outro");
                Console.WriteLine("5 - Gerar relatório mensal de aplicações (Empresa)");
                Console.WriteLine("6 - Gerar relatório de aplicações (Cliente)");
                Console.ReadLine();

                if (opcao == 1)
                {
                    //criar um cliente 
                    Console.WriteLine("1 - Pessoa Física, 2 - Pessoa Jurídica");
                    int tipoCliente = int.Parse(Console.ReadLine());
                    if (tipoCliente == 1)
                    {
                        Cliente_Fisico cli = new Cliente_Fisico();
                        cli.setCodigo(randNum.Next(100));
                        Console.WriteLine("Nome do cliente: ");                    
                        cli.setNome(Console.ReadLine());
                        Console.WriteLine("CPF do cliente: ");
                        cli.setCPF(Console.ReadLine());
                        Console.WriteLine("Número do cliente: ");
                        cli.setNumero(Console.ReadLine());
                        Console.WriteLine("Endereço do cliente: ");
                        cli.setEndereco(Console.ReadLine());
                        clientes.Add(cli);
                    }
                    else if (tipoCliente == 2)
                    {
                        Cliente_Juridico cli = new Cliente_Juridico();
                        cli.setCodigo(randNum.Next(100));
                        Console.WriteLine("Nome da Empresa: ");
                        cli.setNome(Console.ReadLine());
                        Console.WriteLine("CPF do cliente: ");
                        cli.setCNPJ(Console.ReadLine());
                        Console.WriteLine("Número do cliente: ");
                        cli.setNumero(Console.ReadLine());
                        Console.WriteLine("Endereço do cliente: ");
                        cli.setEndereco(Console.ReadLine());
                        clientes.Add(cli);
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida");
                    }
                    

                }

                if (opcao == 2)
                {
                    //fazer uma aplicacao
                    Aplicacao apl1 = new Aplicacao();
                    Console.WriteLine("Código do cliente: ");                    
                    apl1.setCodCliente(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Valor da Aplicação: "); 
                    apl1.setValor(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Informe a data de hoje (DIA/MÊS/ANO): "); 
                    apl1.setDataAplicacao(Convert.ToDateTime(Console.ReadLine()));

                    Console.WriteLine("Informe qual Fundo de investimento você deseja inserir essa aplicação: ");
                    Console.WriteLine("1 - BOVESPA, 2 - BM&F, 3 - NASDAQ, 4 - NYSE");
                    int fundoE = int.Parse(Console.ReadLine());

                    if (fundoE == 1)
                    {
                        fundo1.novaAplicacao(apl1);
                    }
                    else if (fundoE == 2)
                    {
                        fundo2.novaAplicacao(apl1);
                    }
                    else if (fundoE == 3)
                    {
                        fundo3.novaAplicacao(apl1);
                    }
                    else if (fundoE == 4)
                    {
                        fundo4.novaAplicacao(apl1);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }

                if (opcao == 3)
                {
                    //fazer o resgate 
                    Console.WriteLine("Valor do resgate: ");
                    float valor = float.Parse(Console.ReadLine());
                    Console.WriteLine("Código do cliente: ");
                    int cod = int.Parse(Console.ReadLine());                    

                    Console.WriteLine("Informe qual Fundo de investimento você deseja fazer o resgate: ");
                    Console.WriteLine("1 - BOVESPA, 2 - BM&F, 3 - NASDAQ, 4 - NYSE");
                    int fundoE = int.Parse(Console.ReadLine());

                    if (fundoE == 1)
                    {
                        fundo1.resgate(valor, cod);
                    }
                    else if (fundoE == 2)
                    {
                        fundo2.resgate(valor, cod);
                    }
                    else if (fundoE == 3)
                    {
                        fundo3.resgate(valor, cod);
                    }
                    else if (fundoE == 4)
                    {
                        fundo4.resgate(valor, cod);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }

                if (opcao == 4)
                {
                    Console.WriteLine("Informe qual Fundo de investimento vai receber a(s) aplicação(ões): ");
                    Console.WriteLine("1 - BOVESPA, 2 - BM&F, 3 - NASDAQ, 4 - NYSE");
                    int fundoA = int.Parse(Console.ReadLine());

                    if (fundoA == 1)
                    {
                        Console.WriteLine("Informe qual Fundo de investimento vai perder a(s) aplicação(ões): ");
                        Console.WriteLine("2 - BM&F, 3 - NASDAQ, 4 - NYSE");
                        int fundoB = int.Parse(Console.ReadLine());

                        if (fundoB == 2)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo1.trasferirAplicacoes(fundo2, cod);
                        }
                        else if (fundoB == 3)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo1.trasferirAplicacoes(fundo3, cod);
                        }
                        else if (fundoB == 4)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo1.trasferirAplicacoes(fundo4, cod);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }


                    }
                    else if (fundoA == 2)
                    {
                        Console.WriteLine("Informe qual Fundo de investimento vai perder a(s) aplicação(ões): ");
                        Console.WriteLine("1 - BOVESPA, 3 - NASDAQ, 4 - NYSE");
                        int fundoB = int.Parse(Console.ReadLine());

                        if (fundoB == 1)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo2.trasferirAplicacoes(fundo1, cod);
                        }
                        else if (fundoB == 3)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo2.trasferirAplicacoes(fundo3, cod);
                        }
                        else if (fundoB == 4)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo2.trasferirAplicacoes(fundo4, cod);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                    }
                    else if (fundoA == 3)
                    {
                        Console.WriteLine("Informe qual Fundo de investimento vai perder a(s) aplicação(ões): ");
                        Console.WriteLine("1 - BOVESPA, 2 - BM&F, 4 - NYSE");
                        int fundoB = int.Parse(Console.ReadLine());

                        if (fundoB == 1)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo3.trasferirAplicacoes(fundo1, cod);
                        }
                        else if (fundoB == 2)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo3.trasferirAplicacoes(fundo2, cod);
                        }
                        else if (fundoB == 4)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo3.trasferirAplicacoes(fundo4, cod);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                    }
                    else if (fundoA == 4)
                    {
                        Console.WriteLine("Informe qual Fundo de investimento vai perder a(s) aplicação(ões): ");
                        Console.WriteLine("1 - BOVESPA, 2 - BM&F, 3 - NASDAQ");
                        int fundoB = int.Parse(Console.ReadLine());

                        if (fundoB == 1)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo4.trasferirAplicacoes(fundo1, cod);
                        }
                        else if (fundoB == 2)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo4.trasferirAplicacoes(fundo2, cod);
                        }
                        else if (fundoB == 3)
                        {
                            Console.WriteLine("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo4.trasferirAplicacoes(fundo3, cod);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }

                }

            }
            
            

            

            
            
            

            //terceira aplicacao do mesmo cliente
            Aplicacao apl3 = new Aplicacao();
            apl3.setCodCliente(1);
            apl3.setValor(2600f);
            apl3.setDataAplicacao(Convert.ToDateTime("01/12/2014"));
            
            //chamar metodo de FundoInvestimento para adicionar a aplicacao nova
            //fundo1.novaAplicacao(apl1);
            fundo1.novaAplicacao(apl2);
            fundo1.novaAplicacao(apl3);

            //tentar fazer o resgate 
            fundo1.resgate(600f, 1);

            //relatorio aplicacoes por cliente
            //fundo.relatorioPorCliente(1);

            Console.ReadKey();
            
        }
    }
}
