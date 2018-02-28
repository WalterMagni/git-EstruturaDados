using System;

//Professora eu achei estranho pq em nenhum momento do codigo pede para passar o numero de aulas dadas, ai não tem como somar, o metodo CalculaSalario() tem a conta, mas não é pedido para passar o numero de aulas. 

namespace EDA2Q1_35089
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor("Francisco", "011.012.013-22", 55.49f); 
            p1.Exibir();                     
            p1.CalculaSalario(p1.ValorAula);

            Console.WriteLine("\n");

            Professor p2 = new Professor("Joana", "014.015.016-23", 59.49f);
            p2.Exibir();
            p2.CalculaSalario(p2.ValorAula);

            Console.ReadKey();

        }
    }
}
