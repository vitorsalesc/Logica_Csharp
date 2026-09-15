using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entre_10e50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entre 10 e 50

            double n1;
            Console.WriteLine("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            if (n1 >= 10 && n1 <= 50)
            {
                Console.WriteLine("Seu numero esta entre 10 e 50"); }
            else { Console.WriteLine("seu numero não está entre 10 e 50");}
        }
    }
}
