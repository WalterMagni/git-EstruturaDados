using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    class Paciente
    {
        private String nome;
        private int codigo;
        private float peso;
        private float altura;
        private float IMC;

        public string Nome { get => nome; set => nome = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Altura { get => altura; set => altura = value; }

        public Paciente(string nome, int codigo, float peso, float altura)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.peso = peso;
            this.altura = altura;
        }

        public void CalculaImc()
        {
            IMC = Peso = (Altura * Altura);
        }

        public void getStatus()
        {
            if (IMC <= 18.4)
            {
                Console.WriteLine("Abaixo do preso");
            }
            else if (IMC >= 18.5 || IMC <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (IMC >= 25 || IMC <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
        }
    }
}
