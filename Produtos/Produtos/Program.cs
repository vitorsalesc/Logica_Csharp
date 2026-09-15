using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um algoritimo para cadastro de produtos: Codigo do fabricante, categoria, preço, estoque, valor total em estoque 
            int codigo, estoque;
            string fabricante, categoria;
            double preco, total;
            Console.WriteLine("Digite o codigo: "); // escreva
            codigo = int.Parse(Console.ReadLine()); // laie (inteiro) int por não ser string (cadeia)
           
            Console.WriteLine("Digite o fabricante: "); //escreva
            fabricante = Console.ReadLine(); // leia (cadeia) aqui iria direto por ser string (cadeia)
            
            Console.WriteLine("Digite a categoria"); //escreva
            categoria = Console.ReadLine();
           
            Console.WriteLine("Digite o preço: "); //escreva
            preco = double.Parse(Console.ReadLine()); //leia (Real) double por não ser string (cadeia)



            Console.WriteLine("Digite o estoque: "); //escreva
            estoque = int.Parse(Console.ReadLine()); // leia (estoque) int por não ser string (cadeia)

            total = preco * estoque; //conta

            Console.WriteLine("O valor total em estoque é: " + total); //escreva + conta

        }
    }
}
