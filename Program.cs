using System;

namespace TP1_
{
    internal class Program
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        private static int Fib(int n1)
        {
            if (n1 <= 2)
                return 1;
            else
                return Fib(n1 - 1) + Fib(n1 - 2);
        }

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public static void Main(string[] args)
        {
            //Exo1();

            //Exo2();

            //Exo3();

            //Exo4();

            //Exo5();
        }

        private static void Exo1()
        {
           //1)
           for (int compteur = 1; compteur < 11; compteur++)
            {
                Console.WriteLine("Table of :" + compteur);
                for (int multi = 1; multi < 11; multi++)
                {
                    int res = compteur * multi;
                    //2)
                    if(res % 2 != 0)
                    {
                        Console.Write($"{compteur} * {multi} = {compteur * multi}\n");
                    }
                }
            }
           //3)
            int number = AskUserForParameter();
            Console.WriteLine("Table of :" + number);
            for (int multi = 1; multi < 11; multi++)
            {
                int resultat = multi * number;
                Console.WriteLine($"{multi} * {number} = {resultat}");
            }
        }

        private static void Exo2()
        {
            //1)
            Prime();

            static void Prime()
            {
                for (int prime = 1; prime < 1001; prime++)
                {
                    int res = prime / 2;
                    int flag = 0;
                    for (int i = 2; i <= res; i++)
                    {
                        if (prime % i == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.Write($"{prime} ");
                    }
                }
                Console.Write("\n");
            }

            //2)
            int Fibo = AskUserForParameter();

            for (int k = 0; k <= Fibo; k++)
            {
                Console.WriteLine($"F({k})={Fib(k)}");
            }

            //3)
            //a)
            int nombree4 = 4;
            int fin = 1;

            for(int j = 1; j < nombree4 + 1; j++)
            {
                fin = fin * j;
            }

            Console.WriteLine($"Factoriel de {nombree4} = {fin}");

            //b)
            int nombree6 = 6;
            int fin6 = 1;

            for (int j = 1; j < nombree6 + 1; j++)
            {
                fin6 = fin6 * j;
            }

            Console.WriteLine($"Factoriel de {nombree6} = {fin6}");

            //c)
            //If you tried to calculate 420.000, it will not work because it will not have enough memory because the factorial is way too high.

            //d)
            //A recursive function is a fuction that call itself in their instructions
        }

        private static void Exo3()
        {
            int res = 0;
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    res = 10 / PowerFunction(i);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception caught for i = {i}.", e);
                }
            }
        }

        private static void Exo4()
        {
            //1)
            int N;
            int M;
            do
            {
                Console.WriteLine("Choisir un premier nombre : ");
                N = AskUserForParameter();
            } while (N > 1000 || N < 1);

            do
            {
                Console.WriteLine("Choisir un deuxième nombre : ");
                M = AskUserForParameter();
            } while (M > 1000 || M < 1);

            bool compteur = false;

            for (int x = 0; x < M; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    if (x == 0 && y ==0 || x == M - 1 && y == 0 || x == 0 && y == N - 1 || x == M-1 && y == N-1)
                    {
                        Console.Write("0");
                    }
                    else if (x == 0 || x == M - 1)
                    {
                        Console.Write("-");
                    }
                    else if (y == 0 || y == N - 1)
                    {
                        Console.Write('|');
                    }
                    else
                    {
                        if (x % 3 == 0 && y == 1)
                        {
                            Console.Write("  ");
                            y++;
                        }
                        else if (x % 3 == 2 && y == 1)
                        {
                            Console.Write(' ');
                        }
                        else if (compteur == false)
                        {
                            Console.Write("*");
                            compteur = !compteur;
                        }
                        else if (compteur == true)
                        {
                            if (y == N - 2)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("  ");
                                y++;
                            }
                            compteur =! compteur;
                        }
                    }
                }
                compteur = false;
                Console.Write("\n");
            }
        }

        private static void Exo5()
        {
            int choix;
            do
            {
                Console.WriteLine("Choisir la taille du sapin : ");
                choix = AskUserForParameter();
            } while (choix > 23 || choix < 3);

            Console.WriteLine("Voulez-vous décorer le sapin ? 0/1 : ");
            int decoration = AskUserForParameter();

            int taille = choix;
            int compteur = 1;
            for (int i = 0; i < taille ; i++)
            {
                for (int j = 0; j < taille - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (i * 2) + 1; j++)
                {
                    if (decoration == 0)
                    {
                        Console.Write("*");
                    }
                    else if (decoration == 1)
                    {
                        if (i % 3 == 1 && j == 0)
                        {
                            Console.Write("o");
                        }
                        else if (i % 3 == 2 && j == 0)
                        {
                            Console.Write("**i");
                            j += 2;
                        }
                        else if (i % 3 == 0 && j == 0 && i != 0)
                        {
                            Console.Write("*i");
                            j++;
                        }
                        else
                        {
                            if (compteur % 3 == 0)
                            {
                                if ((j % 4) == 0)
                                {
                                    Console.Write("o");
                                }
                                else
                                {
                                    Console.Write("i");
                                }
                            }
                            else
                            {
                                Console.Write("*");
                            }
                            compteur++;
                        }
                    }
                }
                compteur = 1;
                Console.WriteLine();
            }
            for (int y = 0; y < taille * 2; y++)
            {
                if (y == taille - 1 || y == taille + 1)
                {
                    Console.Write("|");
                }
                else 
                {
                    Console.Write(" ");
                }
            }
        }
    }
}