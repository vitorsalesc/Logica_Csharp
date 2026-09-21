using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5 - Faça um algoritmo que calcule o IMC(Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condição
            de acordo com a tabela abaixo*/

            double peso, altura, conta;

            Console.WriteLine("Digite o peso do atleta: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altuea do atleta: ");
            altura = double.Parse(Console.ReadLine());

            conta = (altura * altura) / peso;

            if (conta  < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            if (conta >= 18.6 && conta <= 24.9)
            {
                Console.WriteLine("Peso ideal (parabéns)");
            }
            if (conta >=25.0 && conta <= 29.9)
            {
                Console.WriteLine("Levemente acima do peso");
            }
            if (conta >= 30.0 && conta <= 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            if (conta >= 35.0 && conta <= 39.9)
            {
                Console.WriteLine("Obesidade grau II (severa)");
            }
            if (conta > 40.0)
            {
                Console.WriteLine("Obesidade grau III (mórbida)");
            }



        }
    }
}
