using System;

namespace EDA1Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bem vindo as eleições para presidente do Brasil 2018, para confirmar
             * seu voto basta informar seu nome, idade valida a partir de 16 anos e CPF.
             * Existe dois candidatos concorrendo ao pleito, do lado direito temos um 
             * ex militar que é deputado a mais de 20 anos e não fez nada, totalmente 
             * despreparado mais alguns chamam de mito, e do outro lado um ex presidente 
             * condenado e com mais inqueritos que titulos mundiais da seleção brasileira.
            */

            string nome;
            string CPF;
            int idade;

            int candidatos = 2;
            int somaVotos1 = 0;
            int somaVotos2 = 0;
            int somaBranco = 0;
            int somaNulos = 0;

            Console.Write("Bem vindo, qual é seu nome? ");
            nome = Console.ReadLine();

            do
            {
                Console.Write("Qual a sua idade? ");
                idade = int.Parse(Console.ReadLine());
            } while (idade < 16);

            Console.Write("Agora digite o seu CPF: ");
            CPF = Console.ReadLine();

            Console.WriteLine("Pronto! agora é a hora de votar, você pode escolher entre o Candidato 1 de Direita e o Candidato 2 de Esquerda, Clicando 3 você anula o voto e 4 vota em branco:  ");
            candidatos = int.Parse(Console.ReadLine());

            switch (candidatos)
            {
                case 1:
                    

                    Console.WriteLine("Obrigado pelo seu voto, você votou no canditado 1");
                    Console.WriteLine("FIM");
                    somaVotos1 += 1;
                    break;

                case 2:
                    

                    Console.WriteLine("Obrigado pelo seu voto, você votou no canditado 2");
                    Console.WriteLine("FIM");
                    somaVotos2 += 1;
                    break;

                case 3:
                    

                    Console.WriteLine("Obrigado pelo seu voto, você votou nulo");
                    Console.WriteLine("FIM");
                    somaNulos += 1;
                    break;

                case 4:
                    

                    Console.WriteLine("Obrigado pelo seu voto, você votou em branco");
                    Console.WriteLine("FIM");
                    somaBranco += 1;
                    break;

                case 171:

                    Console.WriteLine("Soma de votos de todos os votos");
                    Console.WriteLine("Votos canditado 1 " + somaVotos1);
                    Console.WriteLine("Votos canditado 2 " + somaVotos2);
                    Console.WriteLine("Votos em branco " + somaBranco);
                    Console.WriteLine("Votos nulos " + somaNulos);

                    break;
            }


            Console.ReadKey();
        }
    }
}
