using System;

/* Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar. */

namespace numerosiguais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            if(a % 2 == 0)
            {
                Console.WriteLine("Numero par");
            }else {
                Console.WriteLine("Numero impar");
            }
        }
    }
}
