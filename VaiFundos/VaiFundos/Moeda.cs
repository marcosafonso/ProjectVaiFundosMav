﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Moeda
    {
        protected string paisOrigem;

        public void setPaisOrigem(string paisOrigem)
        {
            this.paisOrigem = paisOrigem;
        }

        public string getPaisOrigem()
        {
            return paisOrigem;
        }
    }
}
