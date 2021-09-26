using System;

/* Elabore um programa que receba o salário de um funcionário e calcule o reajuste desse salário. 
 * Considere que o funcionário deve receber um reajuste de 15% caso seu salário seja menor que 800 reais. 
 * Se o salário for maior ou igual a 800 e menor ou igual a 1000, seu reajuste será de 10 %; caso seja maior que 1000, 
 * o reajuste deve ser de 5%. Ao final do programa deve apresentar o valor antigo e o novo salário.*/

namespace reajustesalario
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario = 1000; 
            float novosalario;

            if (salario < 800)
            {
                novosalario = (float)(salario * 1.15);
                Console.WriteLine("Seu salário irá de R${0} para R${1}.", salario, novosalario);
                
            } else if (salario >= 800 && salario <= 1000)
            {
                novosalario = (float)(salario * 1.10);
                Console.WriteLine("Seu salário irá de R${0} para R${1}.", salario, novosalario);

            } else
            {
                novosalario = (float)(salario * 1.05);
                Console.WriteLine("Seu salário irá de R${0} para R${1}.", salario, novosalario);

            }
            
        }
    }
}
