using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Cliente
    {
        private int codigo;
        private string nome;

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

    }
}
