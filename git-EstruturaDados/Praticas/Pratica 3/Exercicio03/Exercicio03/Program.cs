using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p1 = new Paciente("Jose", 1, 79.5f, 1.85f);
            p1.getStatus();

            Paciente p2 = new Paciente("Carlos", 2, 129.5f, 1.85f);
            p2.getStatus();

            Console.ReadKey();
        }
    }
}
