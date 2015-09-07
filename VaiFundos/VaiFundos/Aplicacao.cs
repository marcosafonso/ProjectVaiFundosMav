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
        private string nomeAplicacao;
        private double valor;
        private FundoInvestimento nome;

        public int getCodCliente()
        {
            return codCliente;
        }

        public string getNomeApli()
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
    }
}
