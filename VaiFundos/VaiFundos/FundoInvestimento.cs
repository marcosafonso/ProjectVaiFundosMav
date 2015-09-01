using System;
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

        


    }
}
