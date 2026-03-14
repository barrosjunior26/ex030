using System;
using System.Threading;

namespace ex030
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis globais
            int opcao;

            Console.Clear();
            Console.Write("Digite a opção desejada logo abaixo.\n1 - Lista de compras;\nDigite o número desejado: ");
            opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Lista();
                    break;
                case 2:
                    Sair();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n\n\nOpção inválida!\n\n");
                    break;
            }
        }

        public static void Lista()
        {
            //Variáveis locais
            string[] lista;
            int quantidade;

            Console.Write("Informe a quantidade de itens que deseja incluir na lista: ");
            quantidade = Convert.ToInt16(Console.ReadLine());

            lista = new string[quantidade];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($"Informe {i + 1}º item da lista: ");
                lista[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.Write("Gerando sua lista de compras");
            for (int s = 10; s > 0; s--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            Console.WriteLine("\n\n========== Sua lista de compras ==========\n");

            foreach (var itens in lista)
            {
                Console.WriteLine(itens);
            }
        }

        public static void Sair()
        {
            Console.Clear();
            Console.Write("Saindo do sistema");

            for (int x = 5; x > 0; x--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("\n\nAté logo!\n");

            Environment.Exit(0);
        }
    }
}
