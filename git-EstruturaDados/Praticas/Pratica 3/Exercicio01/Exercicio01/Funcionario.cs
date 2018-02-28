using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Funcionario
    {
        private String nome;
        private int condigo;
        private String cargo;
        private float salario;
                
        public string Nome { get => nome; set => nome = value; }
        public int Condigo { get => condigo; set => condigo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public float Salario { get => salario; set => salario = value; }

        public Funcionario(string nome, int condigo, string cargo, float salario)
        {
            this.nome = nome;
            this.condigo = condigo;
            this.cargo = cargo;
            this.salario = salario;         
        }

        public void CalculaSalarioLiquidio(float salario)
        {
            if (salario > 2500)
            {
                Salario = salario * 0.8f;
                Console.WriteLine("Salario c/ desconto: " + Salario);
            }
            else if (salario > 1000 || salario < 2500)
            {
                Salario = salario * 0.85f;
                Console.WriteLine("Salario c/ desconto: " + Salario);
            } else
            {
                Salario = salario * 0.9f;
                Console.WriteLine("Salario c/ desconto: " + Salario);
            }
        }



    }
}
