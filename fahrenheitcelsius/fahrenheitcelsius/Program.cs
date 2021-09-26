using System;

/*Ler uma temperatura em graus Celsius e transformá-la em graus Fahrenheit. 
 * A temperatura em Celsius não pode ser menor do que -273.15.*/

namespace fahrenheitcelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius, farh;

            Console.WriteLine("Digite a temperatura em grau Celsius:");
            celsius = float.Parse(Console.ReadLine());

            farh = (float)(1.8 * celsius) + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: {0}", farh);
        }
    }
}
