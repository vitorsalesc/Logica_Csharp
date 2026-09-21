using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia o valor de um produto
              e determine o valor que deve ser pago,
            conforme a escolha da forma de pagamento pelo comprador
            e imprima na tela o valor final do produto a ser pago.
            Utilize os códigos da tabela de condições de pagamento
            para efetuar o cálculo adequado.*/

            double valor, total;
            string pagamento;

            Console.WriteLine("Digite o valor do produto: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a forma que deseja pagar: (Pix p1) (Crédito a vista p2) (cartão 2x p3) (cartão 3x p4)");
            pagamento = Console.ReadLine();

            if (pagamento == "p1")
            {
                total = (valor * 0.15) - valor;
                Console.WriteLine(total);
            }
            if (pagamento == "p2")
            {
                total = valor * 0.10 - valor;
                Console.WriteLine(total);
            }
            if (pagamento == "p3")
            {
                total = valor;
                Console.WriteLine(total);
            }
            if(pagamento == "p4")
            {
                total = valor * 0.10 + valor;
                Console.WriteLine(total);
            }

            
        }
    }
}
