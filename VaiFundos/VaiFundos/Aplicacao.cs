using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Aplicacao
    {
        private int codCliente;
        private FundoInvestimento nomeAplicacao;// talvez nao seja necessaria 
        private double valor;
        private DateTime dataAplicacao; //data que a aplicacao foi registrada

        public int getCodCliente()
        {
            return codCliente;
        }

        public void setCodCliente(int codCliente)
        {
           this.codCliente = codCliente;
        }

        public FundoInvestimento getNomeApli()
        {
            return nomeAplicacao;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor()
        {
            return valor;
        } 

        //
        public void setDataAplicacao(DateTime dataAplicacao)
        {
            this.dataAplicacao = dataAplicacao;
        }

        public DateTime getDataAplicacao()
        {
            return dataAplicacao;
        } 

        public void imprimeAplicacao()
        {
            Console.WriteLine("Código Cliente: {0}\nValor: {1},\nData:{2}\n-------------",this.getCodCliente(),this.getValor(),this.getDataAplicacao());
        }
    }
}
