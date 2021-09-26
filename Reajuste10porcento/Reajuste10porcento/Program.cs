using System;

/*2.	Receber um valor qualquer do teclado e imprimir esse valor com reajuste de 10%.*/

namespace Reajuste10porcento
{
    class Program
    {
        static void Main(string[] args)
        {
            int preco = 0;
            int novopreco=0;

            Console.WriteLine("Digite o preco: ");
            preco = int.Parse(Console.ReadLine());

            novopreco = (int)(preco * 1.1);

            Console.WriteLine("O novo preco é: {0}", novopreco);

        }
    }
}
