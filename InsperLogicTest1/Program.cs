using System;

namespace InsperLogicTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNTimes();
        }

        public static void PrintNTimes()
        {
            Console.WriteLine("Olá. \nInsira um valor para N ( inteiro maior que zero ) :");
            int n = 0;
            var text = Console.ReadLine();
            int.TryParse(text, out n);

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    for(int j = 1; j <= n-i; j++)
                        Console.Write(" ");
                    for(int k = 1; k <= i; k++)
                        Console.Write("@");
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Valor incorreto. Informe um numero inteiro maior que zero :");
                PrintNTimes();
            }
        }
    }
}
