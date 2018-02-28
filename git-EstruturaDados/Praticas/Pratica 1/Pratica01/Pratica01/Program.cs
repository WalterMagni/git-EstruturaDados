using System;

namespace Pratica01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            //EXERCICIO 01
               
            string nome;
            double nascimento, idade;
            global::System.Console.WriteLine("Qual é seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + " Qual o ano do seu nascimento?");
            nascimento = double.Parse(Console.ReadLine());

            idade = 2020 - nascimento;

            Console.WriteLine("Em 2020 você tera " + idade + " anos");

            Console.ReadKey();


            //EXERCICIO 02

            int qtde;
            float preco;

            Console.WriteLine("Digite a quantidade que deseja comprar");
            qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preco do produto");
            preco = float.Parse(Console.ReadLine());

            float soma = preco * qtde;

            Console.WriteLine("O valor da sua compra é R$" + soma);

            Console.ReadKey();

            */        

            //EXERCICIO 03

            float salario;
            float imposto;
            float gambiarra = 100;

            Console.WriteLine("Digite seu salario");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de imposto do salario");
            imposto = float.Parse(Console.ReadLine());

            gambiarra = gambiarra - imposto;

            

            salario = salario / 100 * gambiarra;

            Console.WriteLine(gambiarra);
            //Console.WriteLine("O seu salario liquido com desconto de "+ imposto + "% é R$" + salario);

            Console.ReadKey();

            /*

            //EXERCICIO 04

            float continuada, semestral, total;
            

            Console.WriteLine("Digite sua nota continuada:");
            continuada = float.Parse(Console.ReadLine());
            continuada = continuada  * 0.4f;

            Console.WriteLine("Digite sua nota semestral:");
            semestral = float.Parse(Console.ReadLine());
            semestral = continuada * 0.6f;

            total = continuada + semestral;

            if (total >= 5)
            {
                Console.WriteLine("Parabens você esta aprovado");
            } else
            {
                Console.WriteLine("Você foi reprovado");
            }

            Console.ReadKey();

            
            //EXERCICIO 05

            int num1, num2, resto;

            Console.WriteLine("Digite o primeiro numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2 )
            {
                resto = num1 - num2;
                Console.WriteLine("A diferença entre os números é " + resto);
            } else
            {
                resto = num2 - num1;
                Console.WriteLine("A diferença entre os números é " + resto);
            }

            Console.ReadKey();

            */
        }
    }
}
