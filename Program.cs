using System;

namespace lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nVocê me ganhou no ‘Hello World’… Enfim, vamo? ");

            char resposta = 's';
            do {
                Console.Write("\n\t Escolha o exercício (1-15): ");

                int exercicio = Convert.ToInt32(Console.ReadLine());
                switch (exercicio) {
                    case 1: 
                        Ex1 ex1 = new Ex1 ();
                        ex1.Resposta();
                        break;
                    case 2:
                        Ex2 ex2 = new Ex2 ();
                        ex2.Resposta();
                        break;
                    case 3:
                        Ex3 ex3 = new Ex3 ();
                        ex3.Resposta();
                        break;
                    case 4: 
                        Ex4 ex4 = new Ex4 ();
                        ex4.Resposta();
                        break;
                    case 5:
                        Ex5 ex5 = new Ex5 ();
                        ex5.Resposta();
                        break;
                    case 6:
                        Ex6 ex6 = new Ex6 ();
                        ex6.Resposta();
                        break;
                    case 7:
                        Ex7 ex7 = new Ex7 ();
                        ex7.Resposta(); 
                        break;
                    case 8:
                        Ex8 ex8 = new Ex8 ();
                        ex8.Resposta();
                        break;
                    case 9:
                        Ex9 ex9 = new Ex9 ();
                        ex9.Resposta();
                        break;
                    case 10: 
                        Ex10 ex10 = new Ex10 ();
                        ex10.Resposta();
                        break;
                    case 11:
                        Ex11 ex11 = new Ex11 ();
                        ex11.Resposta();
                        break;
                    case 12:
                        Ex12 ex12 = new Ex12 ();
                        ex12.Resposta();
                        break;
                    case 13: 
                        Ex13 ex13 = new Ex13 ();
                        ex13.Resposta();
                        break;
                    case 14:
                        Ex14 ex14 = new Ex14 ();
                        ex14.Resposta();
                        break;
                    case 15:
                        Ex15 ex15 = new Ex15 ();
                        ex15.Resposta();
                        break;
                    default:
                        Console.WriteLine("\nInválido, minha inteligência não-artificial 2.0. Por que você não tenta aprender por condicionamento? ");
                        break;
                }

                Console.Write("Deseja continuar? ");
                resposta = Convert.ToChar((Console.ReadLine()).Substring(0,1).ToLower());

            } while (resposta != 'n');

            Console.WriteLine("\n--- Programa Encerrado ---\n");
        }
    }
}