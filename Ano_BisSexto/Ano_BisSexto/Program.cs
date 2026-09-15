using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_BisSexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            6. Ano Bissexto
            Determine se um ano é bisexto. um ano é bissexto se for divisível por 4, mas não por 100, a não ser que seja divisível por 400.
            *Entrada 2024
            *Saida: Ano Bissexto
            */


            double ano, total, divi;
            Console.WriteLine("Digite um ano aleatorio (EX: 2000): ");
            ano = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░███╗░░██╗░█████╗░  ██████╗░██╗░██████╗░██████╗███████╗██╗░░██╗████████╗░█████╗░
██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██║██╔════╝██╔════╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔══██╗
███████║██╔██╗██║██║░░██║  ██████╦╝██║╚█████╗░╚█████╗░█████╗░░░╚███╔╝░░░░██║░░░██║░░██║
██╔══██║██║╚████║██║░░██║  ██╔══██╗██║░╚═══██╗░╚═══██╗██╔══╝░░░██╔██╗░░░░██║░░░██║░░██║
██║░░██║██║░╚███║╚█████╔╝  ██████╦╝██║██████╔╝██████╔╝███████╗██╔╝╚██╗░░░██║░░░╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚═╝╚═════╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();
            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("Ano BisSexto");
            }
            else if(ano % 400 == 0)
            {
                Console.WriteLine("Ano BisSexto");
            }
            else
            {
                Console.WriteLine("Não BisSexto");
            }
    }
    }
    }
