using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-  Faça um algoritmo que receba um valor A e B,
             * e troque o valor de A por B e o valor de B por
             * A e imprima na tela os valores.*/

            string A,B;
            Console.WriteLine("Digite o valor de (A)");
            A = Console.ReadLine();
            Console.WriteLine("Digite o valor de (B)");
            B = Console.ReadLine();

            Console.WriteLine("O novo valor de (A) é: " + B);
            Console.WriteLine("O novo valor de (B) é: " + A);

        }
    }
}
