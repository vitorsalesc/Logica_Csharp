using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //soma dos numeros

         double n1, menor, maior;
            Console.WriteLine("Escolha um numero: ");
           n1 = double.Parse(Console.ReadLine());
            menor = n1 - 1;
            maior = n1 + 1;
            Console.WriteLine("o antessesor é: " + menor);
            Console.WriteLine("o sucessor é: " + maior);
        }
    }
}
