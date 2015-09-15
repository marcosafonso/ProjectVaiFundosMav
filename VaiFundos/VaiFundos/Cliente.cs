using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Cliente   
    {
        protected int codigo;
        protected string nome;
        protected string numero;
        protected string endereco;

        public int getCodigo()
        {
            return codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        
        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNumero()
        {
            return numero;
        }

        public void setNumero(string numero)
        {
            this.numero = numero;
        }

        public string getEndereco()
        {
            return endereco;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }


    }
}
