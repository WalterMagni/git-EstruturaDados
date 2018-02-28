using System;
using System.Collections.Generic;
using System.Text;

namespace EDA2Q2_35089
{
    class DivPar
    {
        private int num;

        public int Num { get => num; set => num = value; }

        public DivPar(int num)
        {
            this.num = num;
        }

        public void Exibir(int num)
        {
            do
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num = num - 1;

            } while (num > 0);
        }

        public int Somar(int num)
        {

            int soma = 0;

            do
            {
                if (num % 2 == 0)
                {
                    soma = soma + num;
                }
                num = num - 1;                

            } while (num > 0);

            Console.WriteLine(soma);

            return num;
        }
    }
}
