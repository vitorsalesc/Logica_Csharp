using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Escolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // media escolar

            string nome;
            double n1, n2, n3, n4, media;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a Primeira nota: ");
            n1 = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite a Segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quarta nota: ");
            n4 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("O nome do aluno é: " + nome + " e a média dele é: " + media);
        }
    }
}
