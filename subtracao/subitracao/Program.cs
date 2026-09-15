using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subitracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //subtração

            double n1, n2, soma;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());

            soma = n1 - n2;

            Console.WriteLine("O resultado da subtração é: " + soma);
        }
    }
}
