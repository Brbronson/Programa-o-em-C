using System;

namespace ParOuImpar
{
    class Program
    {
        static void  (string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }
        }
    }
}