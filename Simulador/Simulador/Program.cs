using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Simular o jogo de adivinhação: o jogador 1 escolhe um número entre 1 e 10;
              o jogador 2 insere números na tentativa de acertar o número escolhido pelo
              jogador 1. Quando ele acertar, o algoritmo deve informar que ele acertou o
              número x (escolhido pelo jogador 1) em x tentativas
              (quantidade de tentativas do jogador 2).`*/

            int jog1, jog2, contador = 1;

            Random random = new Random();
            int numero = random.Next(1, 11);


            Random random2 = new Random();
            int numero2 = random.Next(1, 11);
           
           

            while (contador <= 10)
            { 
            
            jog1 = random.Next(1, 11);
            Console.WriteLine("O jogador 1 escolheu o numero: " + jog1);
 
            
            jog2 = random.Next(1, 11);
            Console.WriteLine(contador + " O jogador 2 chutou o numeoro: " + jog2);
            
            if (jog1 == jog2)
            {
                Console.WriteLine("você acertou o numero :)  com  " + contador + " tentativas");
                break;
            }
            else
            {
                Console.WriteLine("você errou o numero :(");
            }
            contador++;

          }
        }
    }
}
