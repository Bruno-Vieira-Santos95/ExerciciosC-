using System;

/*4.	 Cálculo de um salário líquido de um professor. Serão fornecidos valor da hora aula, 
 * número de aulas dadas e o % de desconto do INSS.*/

namespace INSS
{
    class Program
    {
        static void Main(string[] args)
        {
            float va, na, inss, soma;

            Console.WriteLine("Valor da aula trabalhada:");
            va = float.Parse(Console.ReadLine());

            Console.WriteLine("Número de aulas:");
            na = float.Parse(Console.ReadLine());

            soma = va * na;

            Console.WriteLine("O salário é: {0}", soma);

            inss = ((float)(soma * 0.08));

            Console.WriteLine("O valor do desconto do INSS é: {0}", inss);
           
        }
    }
}
