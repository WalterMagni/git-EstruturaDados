using System;

namespace EDA2Q2_35089
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            do
            {
                Console.WriteLine("Digite um valor: (de 2 a 18)");
                valor = int.Parse(Console.ReadLine());
            } while (valor < 2 || valor > 18);

            Console.WriteLine("\nDiv");

            DivPar d1 = new DivPar(valor);
            d1.Exibir(valor);

            Console.WriteLine("\nSoma");

            DivPar d2 = new DivPar(valor);
            d2.Somar(valor);

            Console.ReadKey();
        }
    }
}
