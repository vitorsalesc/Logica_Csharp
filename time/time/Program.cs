using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //time

            double time;
            Console.WriteLine("Digite o tempo da entrega");
            time = double.Parse(Console.ReadLine());

            if (time <= 15) {
                Console.WriteLine("Entrega perfeita! Bônus garantido");
                if (time > 15 && time < 30){
                    Console.WriteLine("Pizza entregue a tempo, sem bônos.");

                if (time >= 30){
                    Console.WriteLine("A pizza esfriou! Peter foi demitido");

                  }
               }
            }
        }
    }
}
