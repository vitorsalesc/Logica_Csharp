using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse  
             usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00)*/

            double salario_min, salario_user, conta, conta2;
            salario_min = 1518.00;

            Console.WriteLine("Digite o valor do salario do usuario: ");
            salario_user = double.Parse(Console.ReadLine());

            conta = salario_user / salario_min;
            conta2 = Math.Round(conta,2);

            Console.WriteLine(conta2);


        }
    }
}
