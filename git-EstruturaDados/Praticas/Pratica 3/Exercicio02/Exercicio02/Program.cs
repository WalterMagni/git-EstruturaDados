using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            EntradeDeCinema P1 = new EntradeDeCinema(1991, 21, 4, 22, "A casa Caiu");
            P1.CalculaDesconto(12, true);

            EntradeDeCinema P2 = new EntradeDeCinema(1991, 21, 4, 22, "A casa Caiu");
            P2.CalculaDesconto(12, false);

            EntradeDeCinema P3 = new EntradeDeCinema(1991, 21, 4, 22, "A casa Caiu");
            P3.CalculaDesconto(11, true);
            
            EntradeDeCinema P4 = new EntradeDeCinema(1991, 21, 4, 22, "A casa Caiu");
            P4.CalculaDesconto(11, false);
            
            EntradeDeCinema P5 = new EntradeDeCinema(1991, 21, 4, 22, "A casa Caiu");
            P5.CalculaDesconto(17, true);
            
            EntradeDeCinema P6 = new EntradeDeCinema(1991, 21, 4, 22, "A casa Caiu");
            P6.CalculaDesconto(17, false);
            
            EntradeDeCinema P7 = new EntradeDeCinema(1991, 21, 4, 22, "A casa Caiu");
            P7.CalculaDesconto(22, true);
            
            EntradeDeCinema P8 = new EntradeDeCinema(1991, 21, 4, 22, "A casa Caiu");
            P8.CalculaDesconto(22, false);

            Console.ReadKey();
        }
    }
}
