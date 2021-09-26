using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Informe o 1º numero - >");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º numero - >");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 - n2;

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
