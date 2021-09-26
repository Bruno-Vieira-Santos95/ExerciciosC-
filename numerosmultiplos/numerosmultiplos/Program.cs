using System;

namespace numerosmultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            if (a % b == 0)
            {
                Console.WriteLine("Numero Multiplos");
            } else
            {
                Console.WriteLine("Numeros nao Multiplos");
            }
        }
    }
}
