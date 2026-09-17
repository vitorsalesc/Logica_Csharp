using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_fabrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Uma fábrica tem uma linha de produção capaz de produzir 400 peças/dia. Um funcionario controla a qualidade, cadastro
             o número da peça e o seu estado (aprovado ou reprovado). Criar um programa para cadastrar o controle de
            qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia.*/

            string pecas;
            int contador=1, quantidadeApro = 0, quantidadeRepro = 0;

            while (contador != 40)
            {
                Console.WriteLine(contador+ " - Digite a condição da peça Aprovado (A) Reprovado (R)");
                pecas = Console.ReadLine();

                if (pecas == "A")
                {
                    quantidadeApro++;
                }
                if (pecas == "R")
                {
                    quantidadeRepro++;
                }

                contador++;
            }


                Console.Clear();
            Console.WriteLine("O total de peças Aprovadas é: " + quantidadeApro);
                Console.WriteLine("\nO total de peças Reprovadas é: " + quantidadeRepro);

        }
     }
}
