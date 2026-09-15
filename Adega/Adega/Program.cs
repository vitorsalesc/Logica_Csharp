using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Costrua um progama que permitab o levantamento do estoque de vinhos de uma adega, tendo como dados de entrada
             tipos de vinho sendo: "t" para tinto e "b" para branco. Como a quantidade de vinhos é desconhecida, utilize a
            letra 'f' para finalizar o progama deve mostrar a quantidade de cade vinho na adega.*/

            string vinhos;
            int contador, quantidadeBranco =0, quantidadeTinto =0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
░█████╗░██████╗░███████╗░██████╗░░█████╗░  ██████╗░███████╗  ██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔════╝██╔════╝░██╔══██╗  ██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔════╝
███████║██║░░██║█████╗░░██║░░██╗░███████║  ██║░░██║█████╗░░  ╚██╗░██╔╝██║██╔██╗██║███████║██║░░██║╚█████╗░
██╔══██║██║░░██║██╔══╝░░██║░░╚██╗██╔══██║  ██║░░██║██╔══╝░░  ░╚████╔╝░██║██║╚████║██╔══██║██║░░██║░╚═══██╗
██║░░██║██████╔╝███████╗╚██████╔╝██║░░██║  ██████╔╝███████╗  ░░╚██╔╝░░██║██║░╚███║██║░░██║╚█████╔╝██████╔╝
╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═════╝░");
            Console.ResetColor();
            for (contador = 1; contador > 0; contador++)
            {

                Console.WriteLine("digite qual tipo de vinho ou digite 'f' para finalizar o progama \n Digite ('t' para vinho tinto e 'b' para vinho branco: ");
                vinhos = Console.ReadLine();
                if (vinhos == "b")
                {
                    quantidadeBranco++;
                }
                if (vinhos == "t")
                {
                    quantidadeTinto++;
                }
                Console.Clear();
                if (vinhos == "f")
                {
                    Console.WriteLine("O total de vinho brancos em estoque são: " + quantidadeBranco + "\ne o de vinhos tintos são: " + quantidadeTinto);
                    break;

                }



            }
        }
        }
    }
