//Exercício 19
using System;

namespace Exercicios{
    class Ex19{
        static void Main(string[] args){
            double x1, x2, x3, x4, soma, media;
            Console.WriteLine("Digite o valor um: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor dois: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor três: ");
            x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor quatro: ");
            x4 = Convert.ToDouble(Console.ReadLine());

            soma = Math.Sqrt(x1) + Math.Sqrt(x2) + Math.Sqrt(x3) + Math.Sqrt(x4);

            media = soma / 4;

            Console.WriteLine("A média das raízes é: "+ media);

        }
    }
}