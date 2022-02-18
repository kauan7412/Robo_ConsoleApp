using System;

namespace Robo_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaraçao de variaveis
            Console.WriteLine("digite o canto superior da area do x");
            int areaX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o canto superior da area do y");
            int areaY = Convert.ToInt32(Console.ReadLine());
            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine("indique a posiçao do robo x");
                int posicaoRobox = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("indique a posiçao do robo y");
                int posicaoRoboy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("indique a direção do robo");
                char bussolarobo = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("digite a movimentação do robo");
                string movimentacaorobo = Console.ReadLine();
                //COMANDOS
                for (int i = 0; i < movimentacaorobo.Length; i++)
                {
                    char comando = movimentacaorobo[i];
                    if (comando == 'E')
                    {
                        if (bussolarobo == 'N')
                        {
                            bussolarobo = 'O';
                        }
                        else if (bussolarobo == 'O')
                        {
                            bussolarobo = 'S';
                        }
                        else if (bussolarobo == 'S')
                        {
                            bussolarobo = 'L';
                        }
                        else if (bussolarobo == 'L')
                        {
                            bussolarobo = 'N';
                        }
                    }
                    if (comando == 'D')
                    {
                        if (bussolarobo == 'N')
                        {
                            bussolarobo = 'L';
                        }
                        else if (bussolarobo == 'L')
                        {
                            bussolarobo = 'S';
                        }
                        else if (bussolarobo == 'S')
                        {
                            bussolarobo = 'O';
                        }
                        else if (bussolarobo == 'O')
                        {
                            bussolarobo = 'N';
                        }
                    }
                    if (comando == 'M')
                    {
                        if (bussolarobo == 'L')
                        {
                            posicaoRobox++;
                        }
                        else if (bussolarobo == 'N')
                        {
                            posicaoRoboy++;
                        }
                        else if (bussolarobo == 'O')
                        {
                            posicaoRobox--;
                        }
                        else if (bussolarobo == 'S')
                        {
                            posicaoRoboy--;
                        }                        
                    }                 
                    //saida
                }
                if (areaX > posicaoRobox && areaY > posicaoRoboy && posicaoRobox >= 0 && posicaoRoboy >= 0)
                {
                    Console.WriteLine($"O robo está X:{posicaoRobox},Y:{posicaoRoboy},Sentido {bussolarobo}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("os comandos execederam o limite da area, tente novamente");
                    Console.ResetColor();
                }
            }
        }
    }
}
