using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;  //variavel cadeia
            int idade; // variavel inteiro
            Console.WriteLine("Digite seu nome: ");  // escreva
            nome = Console.ReadLine();  // leia
            Console.WriteLine("Digite sua idade: "); // escreva
            idade = int.Parse(Console.ReadLine()); // converte o que digitar para inteiro
            Console.WriteLine("Parabéns " + nome + " Você acabou de ganhar uma coca-cola"); // escreva
            Console.WriteLine("\n Você possui " + idade + " anos, beba mais água"); // escreva
            


        }
    }
}
