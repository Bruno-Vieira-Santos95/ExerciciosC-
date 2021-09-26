using System;

/*14.	Leia o número de identificação, as 3 notas obtidas por um aluno nas 3 verificações e a média 
 * dos exercícios que fazem parte da avaliação. Calcular a média de aproveitamento, usando a fórmula:
 * MA = (Nota1 + Nota2 x 2 + Nota3 x 3)/3
A atribuição de conceitos obedece a tabela abaixo:
Média de Aproveitamento	Conceito
9,0	A
8,0 e < 9,0	B
6,0 e < 8,0	C
4,0 e < 6,0	D
< 4,0	E
O algoritmo deve escrever o número do aluno, suas notas, a média dos exercícios, a média de aproveitamento, 
o conceito correspondente e a mensagem: APROVADO se o conceito for A,B ou C e REPROVADO se o conceito for D ou E.*/


namespace mediaalunonota
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, media;

            Console.WriteLine("Digite a primeira nota:");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            n3 = float.Parse(Console.ReadLine());

            media = (float)((n1 + n2 + n3) / 3);

            if (media >= 9)
            {
                Console.WriteLine("Seu conceito e A e está APROVADO");
            } else if (media >= 8 && media < 9)
            {
                Console.WriteLine("Seu conceito e B e está APROVADO");
            } else if (media >= 6 && media < 8)
            {
                Console.WriteLine("Seu conceito e C e está APROVADO");
            } else if (media >= 4 && media < 6)
            {
                Console.WriteLine("Seu conceito e D e está REPROVADO");
            } else
            {
                Console.WriteLine("Seu conceito e E e está REPROVADO");
            }
        }
    }
}
