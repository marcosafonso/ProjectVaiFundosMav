using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Real : Moeda
    {
        private float valorEmDolar = 0.26f;

        public void calcularNotas(float num)
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
    }
}
