using System;

namespace exercsuceseantec

    /*1.	Ler um número inteiro e imprimir seu sucessor e seu antecessor. */

{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int sucessor = 0, antecessor = 0;

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            sucessor = numero + 1;
            antecessor = numero - 1;

            Console.WriteLine("O sucessor é: {0}", sucessor);
            Console.WriteLine("O antecessor é: {0}", antecessor);
        }
    }
}
