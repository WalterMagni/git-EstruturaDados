using System;

namespace EDA1QS_35089
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] qtdeAtletas;
            int atletas;
            float[] tempo;
            float media = 0;
            int cont = 0;

            do
            {
                Console.WriteLine("Digite a quantidade de atletas a competir: ( de 5 a 20 ) ");
                atletas = int.Parse(Console.ReadLine());
            } while (atletas < 5 || atletas >= 20);

            qtdeAtletas = new int[atletas];
            tempo = new float[atletas];

            for (int i = 0; i < qtdeAtletas.Length; i++)
            {
                Console.Write("Digite o tempo do atleta :");
                tempo[i] = float.Parse(Console.ReadLine());
                media = media + tempo[i];
            }

            media = media / atletas;

            Console.WriteLine("A média do tempo dos atletas é de : " + media);

            for (int i = 0; i < qtdeAtletas.Length; i++)
            {
                if (tempo[i] < media)
                {
                    cont++;
                }
            }

            Console.WriteLine("A quantidade de tempos abaixo da média é de: " + cont);

            Console.ReadKey();
        }
    }
}
