using System;
using System.Net;
namespace _6___DESAFIO_FINAL_DE_ENCAPSULAMENTO
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            //OBJETOS CRIADOS
            Menu menuPrincipal = new Menu("Acionamento manual de gerador.", "Status dos geradores.", "Status dos tanques de combustível.", "Abastecer tanque de combustível", "Detalhes do gerador.", "Sair.");
            Especificacao g1 = new Especificacao(500, 8000, 90);
            Especificacao g2 = new Especificacao(400, 7000, 85);
            Especificacao g3 = new Especificacao(400, 7000, 85);
            Especificacao g4 = new Especificacao(850, 14500, 180);
            Gerador G1 = new Gerador(g1, "G1", 40);
            G1.SetStatus("Ligado");
            Gerador G2 = new Gerador(g2, "G2", 250);
            Gerador G3 = new Gerador(g3, "G3", 30);
            Gerador G4 = new Gerador(g4, "G4", 850);

            //MOSTRA A BARRA DE LOADING
            menuPrincipal.CriarBarraLoad();

            /*GUARDA AS OPÇÕES ESCOLHIDAS PELO USUÁRIO*/
            string opcao;

            do //SÓ SAI DO PROGRAMA SE A OPÇÃO FOR 6
            {
                do //ENQUANTO A OPÇÃO DIGITADA FOR UMA ENTRADA INVÁLIDA ELE REPETE
                {
                    menuPrincipal.MostrarOpcoes();
                    System.Console.ForegroundColor = System.ConsoleColor.DarkYellow;
                    opcao = System.Console.ReadLine();
                    opcao = opcao.Trim(); //REMOVE ESPAÇOS ANTES E DEPOIS
                    System.Console.ForegroundColor = System.ConsoleColor.White;

                    if ((opcao != "1") && (opcao != "2") && (opcao != "3") && (opcao != "4") && (opcao != "5") && (opcao != "6")) //MENSAGEM DE ERRO CASO A ENTRADA DIGITADA SEJA INVÁLIDA
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Red;
                        System.Console.WriteLine("    Erro! Entrada inválida!");
                        System.Console.ForegroundColor = System.ConsoleColor.White;
                        System.Threading.Thread.Sleep(850);
                        System.Console.Clear();
                    }

                    System.Console.Clear();

                    switch(opcao) //FAZ CADA OPÇÃO DO PROGRAMA DO MENU PRINCIPAL
                    {
                        case "1":
                            Opcao1(ref G1, ref G2, ref G3, ref G4);
                        break;
                        case "2":
                            System.Console.WriteLine();
                            G1.StatusGeradores();
                            G2.StatusGeradores();
                            G3.StatusGeradores();
                            G4.StatusGeradores();
                        break;
                        case "3":
                            System.Console.WriteLine();
                            G1.StatusTanques();
                            G2.StatusTanques();
                            G3.StatusTanques();
                            G4.StatusTanques();
                        break;
                        case "4":
                            Opcao4(ref G1, ref G2, ref G3, ref G4);
                        break;
                        case "5":
                            Opcao5(G1, G2, G3, G4);
                        break;
                    }

                } while ((opcao!="1") && (opcao != "2") && (opcao != "3") && (opcao != "4") && (opcao != "5") && (opcao != "6"));

            } while (opcao != "6");

            //PROGRAMA ENCERRADO APÓS DIGITAR 6
            System.Console.ForegroundColor = System.ConsoleColor.Cyan;
            System.Console.WriteLine("\n\n                                                                                              PROGRAMA ENCERRADO!\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            System.Console.ForegroundColor = System.ConsoleColor.White;
        }
    }
}