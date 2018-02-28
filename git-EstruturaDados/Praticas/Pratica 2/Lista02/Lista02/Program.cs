using System;

namespace Lista02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            //Exercicio01

            int desconto = 1;
            float valor, valorDesconto;
            

            Console.Write("Digite o valor do produto: ");
            valor = float.Parse(Console.ReadLine());

            Console.Write("Digite o codigo do desconto de 1 a 4: ");
            desconto = int.Parse(Console.ReadLine());

            switch (desconto)
            {
                case 1:
                    valorDesconto = valor * 0.95f;
                    Console.WriteLine("O valor final é R$" + valor + " com desconto de 5% fica R$" + valorDesconto);
                break;
                case 2:
                    valorDesconto = valor * 0.90f;
                    Console.WriteLine("O valor final é R$" + valor + " com desconto de 10% fica R$" + valorDesconto);
                    break;
                case 3:
                    valorDesconto = valor * 0.80f;
                    Console.WriteLine("O valor final é R$" + valor + " com desconto de 20% fica R$" + valorDesconto);
                    break;
                case 4:
                    valorDesconto = valor * 0.50f;
                    Console.WriteLine("O valor final é R$" + valor + " com desconto de 50% fica R$" + valorDesconto);
                    break;
                default:
                    Console.WriteLine("Valor invalido");
                break;
            }

            //Exercicio02

            string login;
            string senha;

            Console.WriteLine("OLA BEM VINDO");

            Console.Write("Digite o login: ");
            login = Console.ReadLine();
            Console.Write("Digite a senha para o usuario " + login + ": ");
            senha = Console.ReadLine();

            switch (login)
            { 
                case "aluno":
                    if (senha == "bandtec")
                    {
                        Console.WriteLine("Olá, "+ login + " Benvindo ao sistema! ");
                    } else
                    {
                        Console.WriteLine("Usuario ou senha invalida");
                    }
                break;

                case "prof":
                    if (senha == "band")
                    {
                        Console.WriteLine("Olá, " + login + " Benvindo ao sistema! ");
                    }
                    else
                    {
                        Console.WriteLine("Usuario ou senha invalida");
                    }
                    break;

                case "coord":
                    if (senha == "colband")
                    {
                        Console.WriteLine("Olá, " + login + " Benvindo ao sistema! ");
                    }
                    else
                    {
                        Console.WriteLine("Usuario ou senha invalida");
                    }
                    break;

                case "admin":
                    if (senha == "bbbbb")
                    {
                        Console.WriteLine("Olá, " + login + " Benvindo ao sistema! ");
                    }
                    else
                    {
                        Console.WriteLine("Usuario ou senha invalida");
                    }
                    break;

                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }


            //Exercicio03

            int[] num = new int[7];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Digite um numero: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS em ordem");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("NUMEROS em ordem INVERSA");
            for (int j = num.Length; j > 0; j--)
            {
                Console.WriteLine(num[j]);
            }

            

            //Exercicio04

            float[] num = new float[10];
            float soma = 0;

            for (int i = 0; i < num.Length;)
            {
                Console.WriteLine("Digite um numero: ");
                num[i] = float.Parse(Console.ReadLine());
                soma = soma + num[i];
                i++;
            }

            soma = soma / 10;

            Console.WriteLine("A média dos valores somados é: " + soma);

            

            //Exercicio05

            string[] nome = new string[3];
            string pesquisa;

            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write("Digite um nome: ");
                nome[i] = Console.ReadLine();
            }

            Console.Write("Digite um nome para pesquisa: ");
            pesquisa = Console.ReadLine();

            for (int i = 0; i < nome.Length; i++)
            {
                if (pesquisa == nome[i])
                {
                    Console.WriteLine(nome[i]);
                }
            }

            

            //Exercicio07

            int[] numeros = new int[2];
            

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
                                
            }

            foreach (int i in numeros)
            {
                if (i == numeros[i])
                {
                    Console.WriteLine(i);
                }
            }

             */

            //Exercicio06

            int[] mes = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            int dia, meses;

            do
            {
                Console.WriteLine("Digite o dia: (de 1 a 31)");
                dia = int.Parse(Console.ReadLine());

            } while (dia < 1 || dia > 31);

            do
            {
                Console.WriteLine("Digite o mes: (de 1 a 12)");
                meses = int.Parse(Console.ReadLine());

            } while (meses < 1 || dia > 12);

            for (int i = 0; i < mes.Length; i++)
            {
                if ()
                {

                }
            }


            Console.ReadKey();


        }


    }
}
