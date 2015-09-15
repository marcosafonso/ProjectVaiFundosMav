using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Cliente_Juridico : Cliente
    {
        private string cnpj;
        private List<string> filial;

        public string getCNPJ()
        {
            return cnpj;
        }

        public void cadastrarFilial(string nomeFilial)
        {
            filial.Add(nomeFilial);
        }

    }
}
