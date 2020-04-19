using System;

namespace Aula_15___Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("[2] Jogar \n[1] Recadastrar jogadores \n[0] Sair do jogo \n[-1] Sair do jogo também");
            string opcao = Console.ReadLine();
            switch (opcao) {
                case "2":
                    System.Console.Clear();
                    System.Console.WriteLine("Jogar");
                break;

                case "1":
                    System.Console.Clear();
                    System.Console.WriteLine("Recadastrar jogadores");
                break;

                case "0": //Dois cases
                case "-1":
                    System.Console.Clear();
                    System.Console.WriteLine("Sair do jogo");
                break;

                default: //Se não for nenhuma das opções
                    System.Console.Clear();
                    System.Console.WriteLine("Não faz nada");
                break;
            }
        }
    }
}
