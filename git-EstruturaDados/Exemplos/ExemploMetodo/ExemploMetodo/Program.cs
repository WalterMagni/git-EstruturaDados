using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMetodo
{
    class Program
    {
        /* Exemplo de método que não retorna valor
         * Deve ser do tipo void
         * Este método recebe um número inteiro e 
         * exibe os divisores desse número */

        static public void ExibeDivisores(int num)
        {
            /* faz a variável i variar de 1 até num (inclusive),
             * para verificar se i é divisor de num (resto de num por i = zero)
             */ 
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)   // se resto de num por i é zero, 
                {                   // então i é divisor de num
                    Console.WriteLine(i + " é divisor de " + num);
                }
            }
        }

        /* Exemplo de método que retorna valor
         * NÃO deve ser do tipo void
         * Este método recebe um número inteiro, 
         * exibe os divisores desse número 
         * e retorna quantos divisores existem */
        static public int QuantDivisores(int num)
        {
            int cont = 0;   // para contabilizar a quantidade de divisores
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " é divisor de " + num);
                    cont++;   // incrementa cont 
                }
            }
            return cont;   // retorna cont

        }

        static void Main(string[] args)
        {
            int numero;   // número a ser digitado pelo usuário
            int qtdDiv;   // quantidade de divisores

            // solicita que o usuário digite um número
            Console.WriteLine("Digite um número inteiro");
            // lê o número digitado pelo usuário
            numero = int.Parse(Console.ReadLine());

            // chama o método ExibeDivisores para exibir os divisores de numero
            ExibeDivisores(numero);
            Console.WriteLine();

            // chama o método QuantDivisores para saber quantos divisores
            // tem o numero, atribuindo esse valor para qtdDiv
            qtdDiv = QuantDivisores(numero);
            // Exibe quantos divisores tem o número
            Console.WriteLine("O número " + numero + " tem " +
                               qtdDiv + " divisor(es)");
            Console.WriteLine();

            // Equivalente à exibição acima, mas sem precisar da variável
            // qtdDiv. O método é chamado dentro do Console.WriteLine()
            Console.WriteLine("O número " + numero + " tem " +
                       QuantDivisores(numero) + " divisor(es)");


            Console.ReadKey();
        }
    }
}
