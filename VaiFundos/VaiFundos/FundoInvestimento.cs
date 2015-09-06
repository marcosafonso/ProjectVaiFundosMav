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

        public void calcularNotasReal(float num)
        {
            float valor = num;
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
            Console.WriteLine("Notas de 100: " + qtd100);
            Console.WriteLine("Notas de 50: " + qtd50);
            Console.WriteLine("Notas de 20: " + qtd20);
            Console.WriteLine("Notas de 10: " + qtd10);
            Console.WriteLine("Notas de 5: " + qtd5);
            Console.WriteLine("Notas de 2: " + qtd2);
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.ReadKey();
        }

        public void calcularNotasDolar(float num)
        {
            float valor = num;
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
                    if(aux < 1)
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

            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine("Notas de 100: " + qtd100);
            Console.WriteLine("Notas de 50: " + qtd50);
            Console.WriteLine("Notas de 20: " + qtd20);
            Console.WriteLine("Notas de 10: " + qtd10);
            Console.WriteLine("Notas de 5: " + qtd5);
            Console.WriteLine("Notas de 2: " + qtd2);
            Console.WriteLine("Notas de 1: " + qtd1);
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.ReadKey();
        }

        public void resgate(double valorResgate)
        {

        }


    }
}
