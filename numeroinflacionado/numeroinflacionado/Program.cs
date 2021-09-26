using System;

/* 12.	Leia o preço de um produto e inflaciona esse preço em 10% 
 * se ele for menor que 100 e em 20% se ele for maior ou igual a 100.*/

namespace numeroinflacionado
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 111;
            float preco;

            if (a < 100)
            {
                preco = (float)(a * 1.1);
                Console.WriteLine("O preco e: {0}", preco);
            } else
            {
                preco = (float)(a * 1.2);
                Console.WriteLine("O preco e: {0}", preco);
            }
        }
    }
}
