using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("João", 1234, "Analista de Sistema", 5000);
            f1.Salario = 5000;                       
            Console.WriteLine("Nome: " + f1.Nome + " Codigo:" + f1.Condigo + " Cargo: " + f1.Cargo + " Salario: " + f1.Salario);
            f1.CalculaSalarioLiquidio(f1.Salario);

            Console.WriteLine("##############################");

            Funcionario f2 = new Funcionario("Josefina", 4321, "Programador", 2450);
            f2.Salario = 2450;
            Console.WriteLine("Nome: " + f2.Nome + " Codigo:" + f2.Condigo + " Cargo: " + f2.Cargo + " Salario: " + f2.Salario);
            f2.CalculaSalarioLiquidio(f2.Salario);

            Console.WriteLine("##############################");

            Funcionario f3 = new Funcionario("Carlinhos", 5678, "estagiario", 1000);
            f3.Salario = 1000;
            Console.WriteLine("Nome: " + f3.Nome + " Codigo:" + f3.Condigo + " Cargo: " + f3.Cargo + " Salario: " + f3.Salario);
            f3.CalculaSalarioLiquidio(f3.Salario);


            Console.ReadKey();
        }
    }
}
