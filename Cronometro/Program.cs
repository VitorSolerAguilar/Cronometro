using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Segundos = 0;

                Console.Write("Digite a quantidade de tempo em segundos: ");
                Segundos = int.Parse(Console.ReadLine());

                for (int i = Segundos - 1; i < Segundos; i--)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Segundos: " + i);

                    if (i == 0)
                    {
                        Console.WriteLine("Tempo esgotado.");
                        Environment.Exit(0);
                    }
                }
            }catch(Exception Erro)
            {
                Console.WriteLine(Erro.Message);
            }
        }
    }
}
