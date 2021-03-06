﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class FundoInvestimento
    {
        private int codigo;
        private string nome;
        private string sigla;
        protected List<Aplicacao> aplicacoes = new List<Aplicacao>(10);
        private string moeda;

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setSigla(string sigla)
        {
            this.sigla = sigla;
        }

        public string getSigla()
        {
            return sigla;
        }
        //
        public void setMoeda(string moeda)
        {
            this.moeda = moeda;
        }

        public string getMoeda()
        {
            return moeda;
        }
        
        public void calcularNotasReais(float num)
        {
            //descontando IRRF
            float valor = num - num*0.20f;
            Console.WriteLine("Valor Após Desconto IRRF: {0}", valor);
            int qtd100 = 0, qtd50 = 0, qtd20 = 0, qtd10 = 0, qtd5 = 0, qtd2 = 0;

            float aux = valor;

            while (aux > 0)
            {
                if (aux >= 100)
                {
                    qtd100 = qtd100 + 1;
                    aux = aux - 100;
                }
                else if (aux >= 50)
                {
                    qtd50 = qtd50 + 1;
                    aux = aux - 50;
                }
                else if (aux >= 20)
                {
                    qtd20 = qtd20 + 1;
                    aux = aux - 20;
                }
                else if (aux >= 10)
                {
                    qtd10 = qtd10 + 1;
                    aux = aux - 10;
                }
                else if (aux >= 5)
                {
                    qtd5 = qtd5 + 1;
                    aux = aux - 5;
                }
                else if (aux >= 2)
                {
                    qtd2 = qtd2 + 1;
                    aux = aux - 2;
                }

                if (aux > 0 & aux < 2)
                {
                    if (aux < 2)
                    {
                        aux = 2;
                    }
                    else if (aux < 5 & aux > 2)
                    {
                        aux = 5;
                    }
                    else if (aux < 10 & aux > 5)
                    {
                        aux = 10;
                    }
                    else if (aux < 20 & aux > 10)
                    {
                        aux = 20;
                    }
                    else if (aux < 50 & aux > 20)
                    {
                        aux = 50;
                    }
                    else if (aux < 100 & aux > 50)
                    {
                        aux = 100;
                    }
                }


            }

            Console.WriteLine("********************************");
            Console.WriteLine();
            //Exibe somente as notas que forem usadas
            if (qtd100 > 0)
            {
                Console.WriteLine("Notas de 100: " + qtd100);
            }
            if (qtd50 > 0)
            {
                Console.WriteLine("Notas de 50: " + qtd50);
            }
            if (qtd20 > 0)
            {
                Console.WriteLine("Notas de 20: " + qtd20);
            }
            if (qtd10 > 0)
            {
                Console.WriteLine("Notas de 10: " + qtd10);
            }
            if (qtd5 > 0)
            {
                Console.WriteLine("Notas de 5: " + qtd5);
            }
            if (qtd2 > 0)
            {
                Console.WriteLine("Notas de 2: " + qtd2);
            }

            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.ReadKey();
        }
        

        public void calcularNotasDolar(float num)
        {
            // descontar IOF
            float valor = num - num*0.01f;
            Console.WriteLine("Valor com desconto IOF:{0}",valor);
            int qtd100 = 0, qtd50 = 0, qtd20 = 0, qtd10 = 0, qtd5 = 0, qtd2 = 0, qtd1 = 0;

            float aux = valor;

            while (aux > 0)
            {
                if (aux >= 100)
                {
                    qtd100 = qtd100 + 1;
                    aux = aux - 100;
                }
                else if (aux >= 50)
                {
                    qtd50 = qtd50 + 1;
                    aux = aux - 50;
                }
                else if (aux >= 20)
                {
                    qtd20 = qtd20 + 1;
                    aux = aux - 20;
                }
                else if (aux >= 10)
                {
                    qtd10 = qtd10 + 1;
                    aux = aux - 10;
                }
                else if (aux >= 5)
                {
                    qtd5 = qtd5 + 1;
                    aux = aux - 5;
                }
                else if (aux >= 2)
                {
                    qtd2 = qtd2 + 1;
                    aux = aux - 2;
                }
                else if (aux >= 1)
                {
                    qtd1 = qtd1 + 1;
                    aux = aux - 1;
                }

                if (aux > 0 & aux < 2)
                {
                    if (aux < 1)
                    {
                        aux = 1;
                    }
                    else if (aux < 2 & aux > 1)
                    {
                        aux = 2;
                    }
                    else if (aux < 5 & aux > 2)
                    {
                        aux = 5;
                    }
                    else if (aux < 10 & aux > 5)
                    {
                        aux = 10;
                    }
                    else if (aux < 20 & aux > 10)
                    {
                        aux = 20;
                    }
                    else if (aux < 50 & aux > 20)
                    {
                        aux = 50;
                    }
                    else if (aux < 100 & aux > 50)
                    {
                        aux = 100;
                    }
                }


            }

            Console.WriteLine("**************Dolar**************");
            Console.WriteLine();
            //Exibe somente as notas que forem usadas
            if (qtd100 > 0)
            {
                Console.WriteLine("Notas de 100: " + qtd100);
            }
            if (qtd50 > 0)
            {
                Console.WriteLine("Notas de 50: " + qtd50);
            }
            if (qtd20 > 0)
            {
                Console.WriteLine("Notas de 20: " + qtd20);
            }
            if (qtd10 > 0)
            {
                Console.WriteLine("Notas de 10: " + qtd10);
            }
            if (qtd5 > 0)
            {
                Console.WriteLine("Notas de 5: " + qtd5);
            }
            if (qtd2 > 0)
            {
                Console.WriteLine("Notas de 2: " + qtd2);
            }
            if (qtd1 > 0)
            {
                Console.WriteLine("Notas de 1: " + qtd1);
            }
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.ReadKey();
        }

        /// <summary>
        /// Método para adicionar um objeto aplicacao na lista de aplicacoes
        /// </summary>
        /// <param name="aplicacao"></param>
        public void novaAplicacao(Aplicacao aplicacao)
        {
            this.aplicacoes.Add(aplicacao);
        }

        /// <summary>
        /// metodo para resgatar uma aplicacao de um cliente especifico 
        /// </summary>
        /// <param name="valorResgate"></param>
        /// <param name="codCliente"></param>

        public void resgate(float valorResgate, int codCliente)
        {
            bool encontrou = false;
            foreach (Aplicacao apli in aplicacoes)
            {
               
                if (apli.getCodCliente() == codCliente && apli.getValor() == valorResgate)
                {
                    Console.WriteLine("Resgate Válidado.");
                    encontrou = true;
                    if (this.moeda.Equals("Real"))
                    {
                        this.calcularNotasReais(valorResgate);                        
                        break;
                    }
                    else if(this.moeda.Equals("Dolar"))
                    {
                        this.calcularNotasDolar(valorResgate);
                        break;
                    }                    
                }          

            }
            if(encontrou == false)
            {
                Console.WriteLine("Resgate Negado.");
                Console.WriteLine("Só é possível resgatar um valor igual a uma das aplicações.");

            }
            
        }

        //gerar relatório de um  cliente especifico
        public void relatorioPorCliente(int codCliente)
        {
            foreach(Aplicacao apli in aplicacoes)
            {
                if(apli.getCodCliente()==codCliente)
                {
                    apli.imprimeAplicacao();
                }
            }
        }

        //gerar relatorio de todas aplicacoes de um fundo
        public void relatorioAplicacoes()
        {
            foreach (Aplicacao apli in aplicacoes)
            {
               
                    apli.imprimeAplicacao();
            }
        }

        public void relatorioAplicacoesMensal()
        {
            foreach (Aplicacao apli in this.aplicacoes)
            {

                apli.imprimeAplicacao();
            }
        }

        public void trasferirAplicacoes(FundoInvestimento fi, int codigoC)
        {
            // Verificando se a moeda do fundo passado como parâmetro
            // é igual ao do fundo que está recebendo
            if (fi.getMoeda() == this.getMoeda())
            {
                foreach (Aplicacao apli in fi.aplicacoes)
                {               
                    if (fi.getMoeda().Equals("Real") && apli.getCodCliente() == codigoC)
                    {                        
                        double aux = apli.getValor();
                        apli.setValor(aux - 10);
                        this.novaAplicacao(apli);
                    }
                    else if (fi.getMoeda().Equals("Dolar") && apli.getCodCliente() == codigoC)
                    {
                        this.novaAplicacao(apli);
                    }
                }

                //Limpando a lista de aplicações do FI passado por parâmetro
                fi.aplicacoes.Clear();                
            }

        }

        public void calculaRemuneracao()
        {
            foreach(Aplicacao ap in this.aplicacoes)
            {
                int anosAplicados = (DateTime.Today.Subtract(ap.getDataAplicacao()).Days / 365);
                double valorAplicacao = ap.getValor();

                if (anosAplicados > 1)
                {
                    valorAplicacao += valorAplicacao * 0.05;
                    ap.setValor(valorAplicacao);
                }

            }

           
        }

            

    }
}
