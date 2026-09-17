using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores,  
            caso contrário deverá multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e  
            imprimir seu valor na tela.*/

            int n1, n2, soma, multiplicação;

            Console.WriteLine("Digite o Primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Primeiro numero: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;
            multiplicação = n1 * n2;
            if (n1 == n2)
            {
                Console.WriteLine("eles são iguais (+): " + soma);
            }
            else
            {
                Console.WriteLine("eles não são iguais (*): " + multiplicação);
            } 
               



        }
    }
}
