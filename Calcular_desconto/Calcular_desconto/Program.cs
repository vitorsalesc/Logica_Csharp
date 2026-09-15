using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_desconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5. Calcular desconto
             Um produto com preço acima de R$100 tem desconto de 10%. caso contrario, o Desconto é de 5%.
            dado o preço, calcule o valor do desconto
            *Entrada: 120
            *Saída esperada: 12 reais de desconto
            */

            double final;
            double preco;
            Console.WriteLine("Digite o valor do produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██████╔╝
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██╔══██╗
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░███████╗░██████╗░█████╗░░█████╗░███╗░░██╗████████╗░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗
██║░░██║█████╗░░╚█████╗░██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██║░░██║
██║░░██║██╔══╝░░░╚═══██╗██║░░██╗██║░░██║██║╚████║░░░██║░░░██║░░██║
██████╔╝███████╗██████╔╝╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░╚█████╔╝
╚═════╝░╚══════╝╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();

            if (preco >= 100)
            {
                final = preco * 0.10;
                Console.WriteLine("O valor de desconto foi de: " + final);
            }
            else if (preco <= 100)
            {
                final = preco * 0.05;
                Console.WriteLine("O valor final de desconto foi de: " + final);
            }
        }
    }
}
