using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
namespace Cadastro_Bandas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             se / enquanto   / para   / caso
             is    while       for      switch
            
            Crie um sistema de cadastro de Àlbuns de um artista / banda em que será possível cadastrar um número X
            de músicas informada pelo usuário. crie um menu de opções para isso. 
             */

            int opcao = 0;
            while (opcao != 4) {

           
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░  ██████╗░███████╗  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░  ██████╦╝███████║██╔██╗██║██║░░██║███████║
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝
");
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine(" 1 - Cadastrar Album da Banda");
            Console.WriteLine(" 2 - Cadastrar Album do Artista"); // Ano, Nome Artista, qtd album, qtd vendas
            Console.WriteLine(" 3 - Cadastrar Músicas"); //Digitar a qnt musicas (Nome musica, duração,premiação)
            Console.WriteLine(" 4 - Sair do Programa");
            Console.WriteLine(" ---->");
            Console.ResetColor();
            opcao = int .Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                        Cadastro_de_Bandas();
                    break;
                case 2:
                        Cadastro_Artista();
                    break;
                case 3:
                    break; 
                case 4:
                    Console.Clear();
                    Console.WriteLine("Saindo do Programa !!! Tchau Tchau !!   :)");
                    break;
            
                
                
                
                
                
                
                
             
            }          
          }
        }

        static void Cadastro_de_Bandas()
        {
            string nomeBanda, nomeAlbum;
            int qtdMusicas;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
            Console.ResetColor();

            Console.WriteLine("Digite o nomeda Banda: ");
            nomeBanda = Console.ReadLine();

            Console.WriteLine("Digite o nomeda Album: ");
            nomeAlbum = Console.ReadLine();

            Console.WriteLine("Digite o Números de Músicas: ");
            qtdMusicas = int .Parse(Console.ReadLine());

            Console.WriteLine("\n Cadastro realizado com Sucesso !!! ");
            Console.WriteLine("\n" + nomeBanda);
            Console.WriteLine("\n" + nomeAlbum);
            Console.WriteLine("\n" + qtdMusicas);

            Thread.Sleep(3000);

        }

        static void Cadastro_Artista()
        {
            string nomeArtista;
        int anoAlbum, qntAlbuns, qntVendas;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@" 
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝

██████╗░░█████╗░  ░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░
██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗
██║░░██║██║░░██║  ███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║
██║░░██║██║░░██║  ██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║
██████╔╝╚█████╔╝  ██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║
╚═════╝░░╚════╝░  ╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝ ");
        Console.ResetColor ();
        
        Console.WriteLine("Digite o Nome do(a) Artista: ");
        nomeArtista = Console.ReadLine();

        Console.WriteLine("Digite o Ano que foi lançado: ");
        anoAlbum = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Quantos Albuns esse artista tem: ");
        qntAlbuns = int .Parse(Console.ReadLine());

            Console.WriteLine("Digite Quantas Vendas esse Album teve: ");
            qntVendas = int .Parse(Console.ReadLine());

            Console.WriteLine("\n Cadastro realizado com Sucesso !!! ");
            Console.WriteLine("\n" + nomeArtista);
            Console.WriteLine("\n" + anoAlbum);
            Console.WriteLine("\n" + qntAlbuns);
            Console.WriteLine("\n" + qntVendas);
            Thread.Sleep(3000);


        }


    }
}
