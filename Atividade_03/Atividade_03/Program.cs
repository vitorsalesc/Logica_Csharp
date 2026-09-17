using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia um valor qualquer e imprima na tela com um
            reajuste de 5 %.*/

            double n1, almento, final;

            Console.WriteLine("Digite um valor: ");
            n1 = double.Parse(Console.ReadLine());

            almento = n1 * 0.05;
            final = n1 + almento;
            Console.Clear();
            Console.WriteLine(final);


        }
    }
}
