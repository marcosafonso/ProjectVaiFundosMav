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
            int codCliente = 1;

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
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Fazer Aplicaçao");
                Console.WriteLine("3 - Fazer Resgate");
                Console.WriteLine("4 - Trasferir aplicãções de um fundo para outro");
                Console.WriteLine("5 - Gerar relatório mensal de aplicações (Empresa)");
                Console.WriteLine("6 - Gerar relatório de aplicações (Cliente)");
                Console.WriteLine("7 - Aplicar Remuneração");
                Console.WriteLine("-1 - Sair");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());                
                Console.WriteLine();

                // OPÇÃO 1

                if (opcao == 1)
                {
                    //criar um cliente 
                    Console.WriteLine("1 - Pessoa Física, 2 - Pessoa Jurídica");
                    Console.Write("Digite a opção desejada: ");
                    int tipoCliente = int.Parse(Console.ReadLine());
                    if (tipoCliente == 1)
                    {
                        Cliente_Fisico cli = new Cliente_Fisico();
                        cli.setCodigo(codCliente++);
                        Console.Write("Nome do cliente: ");
                        cli.setNome(Console.ReadLine());
                        Console.Write("CPF do cliente: ");
                        cli.setCPF(Console.ReadLine());
                        Console.Write("Número do cliente: ");
                        cli.setNumero(Console.ReadLine());
                        Console.Write("Endereço do cliente: ");
                        cli.setEndereco(Console.ReadLine());
                        clientes.Add(cli);
                        Console.WriteLine("Código do cliente: {0} ", cli.getCodigo());
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

                // OPÇÃO 2

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

                    Console.Clear();

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

                    Console.Clear();
                }

                // OPÇÃO 3

                if (opcao == 3)
                {
                    //fazer o resgate 
                    Console.WriteLine("Valor do resgate: ");
                    float valor = float.Parse(Console.ReadLine());
                    Console.WriteLine("Código do cliente: ");
                    int cod = int.Parse(Console.ReadLine());
                    Console.WriteLine();
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

                    Console.Clear();
                }

                // OPÇÃO 4

                if (opcao == 4)
                {
                    Console.WriteLine("Informe qual Fundo de investimento vai receber a(s) aplicação(ões): ");
                    Console.WriteLine("1 - BOVESPA, 2 - BM&F, 3 - NASDAQ, 4 - NYSE");
                    Console.Write("Digite a opção desejada: ");
                    int fundoA = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (fundoA == 1)
                    {
                        Console.WriteLine("Informe qual Fundo de investimento vai perder a(s) aplicação(ões): ");
                        Console.WriteLine("2 - BM&F, 3 - NASDAQ, 4 - NYSE");
                        Console.Write("Digite a opção desejada: ");
                        int fundoB = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (fundoB == 2)
                        {
                            Console.Write("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo1.trasferirAplicacoes(fundo2, cod);
                        }
                        else if (fundoB == 3)
                        {
                            Console.Write("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo1.trasferirAplicacoes(fundo3, cod);
                        }
                        else if (fundoB == 4)
                        {
                            Console.Write("Código do cliente: ");
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
                        Console.Write("Digite a opção desejada: ");
                        int fundoB = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (fundoB == 1)
                        {
                            Console.Write("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo2.trasferirAplicacoes(fundo1, cod);
                        }
                        else if (fundoB == 3)
                        {
                            Console.Write("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo2.trasferirAplicacoes(fundo3, cod);
                        }
                        else if (fundoB == 4)
                        {
                            Console.Write("Código do cliente: ");
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
                        Console.Write("Digite a opção desejada: ");
                        int fundoB = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (fundoB == 1)
                        {
                            Console.Write("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo3.trasferirAplicacoes(fundo1, cod);
                        }
                        else if (fundoB == 2)
                        {
                            Console.Write("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo3.trasferirAplicacoes(fundo2, cod);
                        }
                        else if (fundoB == 4)
                        {
                            Console.Write("Código do cliente: ");
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
                        Console.Write("Digite a opção desejada: ");
                        int fundoB = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (fundoB == 1)
                        {
                            Console.Write("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo4.trasferirAplicacoes(fundo1, cod);
                        }
                        else if (fundoB == 2)
                        {
                            Console.Write("Código do cliente: ");
                            int cod = int.Parse(Console.ReadLine());
                            fundo4.trasferirAplicacoes(fundo2, cod);
                        }
                        else if (fundoB == 3)
                        {
                            Console.Write("Código do cliente: ");
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

                    Console.Clear();

                }

                // OPÇÃO 5

                if (opcao == 5)
                {
                    Console.WriteLine("Informe qual Fundo de investimento você deseja gerar o relatório: ");
                    Console.WriteLine("1 - BOVESPA, 2 - BM&F, 3 - NASDAQ, 4 - NYSE");
                    Console.Write("Digite a opção desejada: ");
                    int fundoE = int.Parse(Console.ReadLine());

                    if (fundoE == 1)
                    {
                        fundo1.relatorioAplicacoes();
                    }
                    else if (fundoE == 2)
                    {
                        fundo2.relatorioAplicacoes();
                    }
                    else if (fundoE == 3)
                    {
                        fundo3.relatorioAplicacoes();
                    }
                    else if (fundoE == 4)
                    {
                        fundo4.relatorioAplicacoes();
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }

                    Console.Clear();
                }

                // OPÇÃO 6

                if (opcao == 6)
                {
                    Console.WriteLine("Informe qual Fundo de investimento você deseja gerar o relatório: ");
                    Console.WriteLine("1 - BOVESPA, 2 - BM&F, 3 - NASDAQ, 4 - NYSE");
                    Console.Write("Digite a opção desejada: ");
                    int fundoE = int.Parse(Console.ReadLine());

                    if (fundoE == 1)
                    {
                        Console.WriteLine("Código do cliente: ");
                        int cod = int.Parse(Console.ReadLine());
                        foreach (Cliente c in clientes)
                        {
                            if (c.getCodigo() == cod)
                            {
                                Console.WriteLine("Nome: {0}", c.getNome());
                            }
                        }
                        fundo1.relatorioPorCliente(cod);
                    }
                    else if (fundoE == 2)
                    {
                        Console.WriteLine("Código do cliente: ");
                        int cod = int.Parse(Console.ReadLine());
                        foreach (Cliente c in clientes)
                        {
                            if (c.getCodigo() == cod)
                            {
                                Console.WriteLine("Nome: {0}", c.getNome());
                            }
                        }
                        fundo2.relatorioPorCliente(cod);
                    }
                    else if (fundoE == 3)
                    {
                        Console.WriteLine("Código do cliente: ");
                        int cod = int.Parse(Console.ReadLine());
                        foreach (Cliente c in clientes)
                        {
                            if (c.getCodigo() == cod)
                            {
                                Console.WriteLine("Nome: {0}", c.getNome());
                            }
                        }
                        fundo3.relatorioPorCliente(cod);
                    }
                    else if (fundoE == 4)
                    {
                        Console.WriteLine("Código do cliente: ");
                        int cod = int.Parse(Console.ReadLine());
                        foreach (Cliente c in clientes)
                        {
                            if (c.getCodigo() == cod)
                            {
                                Console.WriteLine("Nome: {0}", c.getNome());
                            }
                        }
                        fundo4.relatorioPorCliente(cod);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }

                    Console.Clear();
                }

                // OPÇÃO 7

                if (opcao == 7)
                {
                    fundo1.calculaRemuneracao();
                    fundo2.calculaRemuneracao();
                    fundo3.calculaRemuneracao();
                    fundo4.calculaRemuneracao();
                    Console.WriteLine("Remunerações realizadas com sucesso!");

                    Console.Clear();
                }

            }
        }
    }
}
