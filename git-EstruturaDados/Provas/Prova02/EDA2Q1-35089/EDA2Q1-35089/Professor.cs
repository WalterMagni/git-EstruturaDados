using System;
using System.Collections.Generic;
using System.Text;

namespace EDA2Q1_35089
{
    class Professor
    {
        private String nome;
        private String cpf;
        private int numAulas;
        private float valorAula;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int NumAulas { get => numAulas; set => numAulas = value; }
        public float ValorAula { get => valorAula; set => valorAula = value; }

        public Professor(string nome, string cpf, float valorAula)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.valorAula = valorAula;
        }

        public void Exibir()
        {
            Console.WriteLine("### DADOS DO PROFESSOR ###");
            Console.WriteLine("\nNome: " + Nome);
            Console.WriteLine("\nCPF: " + Cpf);          
        }

        public float CalculaSalario(float salario)
        {
            salario = NumAulas * ValorAula;
            Console.WriteLine("\nO Salario no fim do mês é R$" + salario);
            return salario;
        }
    }
}
