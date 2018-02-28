using System;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorNomes = new int[2];
            string[] nome1 = new string[2];
            string[] nome2 = new string[2];

            string turma;
            

            for (int i = 0; i < vetorNomes.Length; i++)
            {

                Console.Write("Digite a sua turma L1 ou L2: ");
                turma = Console.ReadLine();

                if (turma == "L1")
                {
                    Console.Write("Digita o seu nome:");
                    nome1[i] = Console.ReadLine();
                }
                else
                {
                    Console.Write("Digita o seu nome:");
                    nome2[i] = Console.ReadLine();
                }
                                
            }

            Console.WriteLine("###Turma L1###");
            for (int i = 0; i < nome1.Length; i++)
            {
                Console.WriteLine( nome1[i]);        
            }

            Console.WriteLine("###Turma L2###");
            for (int i = 0; i < nome2.Length; i++)
            {
                Console.WriteLine(nome2[i]);
            }



            Console.ReadKey();
        }
    }
}
