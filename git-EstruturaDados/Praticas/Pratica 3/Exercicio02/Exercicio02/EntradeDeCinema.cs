using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    class EntradeDeCinema
    {
        private int ano;
        private int hora;
        private int sala;
        private float valor;
        private String nome;

        public int Ano { get => ano; set => ano = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Sala { get => sala; set => sala = value; }
        public float Valor { get => valor; set => valor = value; }
        public string Nome { get => nome; set => nome = value; }

        public EntradeDeCinema(int ano, int hora, int sala, float valor, string nome)
        {
            this.ano = ano;
            this.hora = hora;
            this.sala = sala;
            this.valor = valor;
            this.nome = nome;
        }

        public void CalculaDesconto(int idade, bool estudande)
        {
            if (idade < 12)
            {
                Valor = Valor * 0.5f;
                Console.WriteLine("Pessoas menores de 12 anos pagam meia, o valor com desconto e': " + Valor);
            }
            else if (idade > 12 || idade <= 15)
            {
                if (estudande == true)
                {
                    Valor = Valor * 0.6f;
                    Console.WriteLine("Pessoas maiores de 12 anos e menores de 16 pagam 60% do valor, o valor com desconto e': " + Valor);
                }
                else
                {
                    Console.WriteLine("O valor do ingresso e' : " + Valor);
                } 
            }
            else if (idade > 16 || idade <= 20)
            {
                if (estudande == true)
                {
                    Valor = Valor * 0.7f;
                    Console.WriteLine("Pessoas maiores de 16 anos e menores de 21 pagam 70% do valor, o valor com desconto e': " + Valor);
                }
                else
                {
                    Console.WriteLine("O valor do ingresso e' : " + Valor);
                }
            }
            else
            {
                if (estudande == true)
                {
                    Valor = Valor * 0.8f;
                    Console.WriteLine("Pessoas maiores de 21 anos pagam 80% do valor, o valor com desconto e': " + Valor);
                }
                else
                {
                    Console.WriteLine("O valor do ingresso e' : " + Valor);
                }
            }




        }
    }
}
