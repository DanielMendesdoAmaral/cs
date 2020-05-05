using System;
using System.Collections.Generic;
using System.Text;

namespace _6___DESAFIO_FINAL_DE_ENCAPSULAMENTO
{
    public partial class Program //Utilize a palavra-chave partial para extender uma classe em outro arquivo.
    {
        static void Opcao1(ref Gerador G1, ref Gerador G2, ref Gerador G3, ref Gerador G4)
        {
            string nome;
            string opcao;
            Menu menu = new Menu("Sim.", "Não.");

            do //Se o gerador não existir, tratamento do erro
            {
                System.Console.Write($"    Informe o nome do gerador: ");
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                nome = System.Console.ReadLine();
                System.Console.ForegroundColor = System.ConsoleColor.White;
                nome = nome.Trim();
                nome = nome.ToUpper();

                if ((nome != "G1") && (nome != "G2") && (nome != "G3") && (nome != "G4")) //Mensagem de erro caso o gerador não exista
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Red;
                    System.Console.Write($"    Erro! O gerador {nome} não existe.");
                    System.Console.ForegroundColor = System.ConsoleColor.White;
                    System.Threading.Thread.Sleep(850);
                    System.Console.Clear();
                }

            } while ((nome != "G1") && (nome != "G2") && (nome != "G3") && (nome != "G4"));

            System.Console.Clear();

            switch (nome)
            {
                case "G1": //O usuário quer o gerador...
                    if ((G1.GetStatus() == "Ligado")) //Se estiver ligado ele printa uma mensagem
                    {
                        do //Tratar opção inválida
                        {
                            System.Console.Write("    G1 está ligado. Deseja desligar? ");
                            menu.MostrarOpcoes();
                            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                            opcao = System.Console.ReadLine();
                            System.Console.ForegroundColor = System.ConsoleColor.White;
                            opcao = opcao.Trim();

                            if ((opcao != "1") && (opcao != "2")) //Mensagem caso a opção seja inválida
                            {
                                System.Console.ForegroundColor = System.ConsoleColor.Red;
                                System.Console.WriteLine("    Erro! Entrada inválida!");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            }

                        } while ((opcao != "1") && (opcao != "2"));

                        switch (opcao)
                        {
                            case "1":
                                G1.Desligar();
                            break;
                            case "2":
                                System.Console.ForegroundColor = System.ConsoleColor.Green;
                                System.Console.WriteLine($"    Retornando ao menu principal...");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            break;
                        }
                    }
                    else //Se estiver desligado ele printa outra mensagem
                    {
                        do //Tratar opção inválida
                        {
                            System.Console.Write("    G1 está desligado. Deseja ligar? ");
                            menu.MostrarOpcoes();
                            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                            opcao = System.Console.ReadLine();
                            System.Console.ForegroundColor = System.ConsoleColor.White;
                            opcao = opcao.Trim();

                            if ((opcao != "1") && (opcao != "2")) //Mensagem caso a opção seja inválida
                            {
                                System.Console.ForegroundColor = System.ConsoleColor.Red;
                                System.Console.WriteLine("    Erro! Entrada inválida!");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            }

                        } while ((opcao != "1") && (opcao != "2"));

                        switch (opcao)
                        {
                            case "1":
                                G1.Ligar();
                            break;
                            case "2":
                                System.Console.ForegroundColor = System.ConsoleColor.Green;
                                System.Console.WriteLine($"    Retornando ao menu principal...");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            break;
                        }
                    }
                break; //Aqui acaba o g1

                case "G2":
                    if ((G2.GetStatus() == "Ligado")) //Se estiver ligado ele printa uma mensagem
                    {
                        do //Tratar opção inválida
                        {
                            System.Console.Write("    G2 está ligado. Deseja desligar? ");
                            menu.MostrarOpcoes();
                            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                            opcao = System.Console.ReadLine();
                            System.Console.ForegroundColor = System.ConsoleColor.White;
                            opcao = opcao.Trim();

                            if ((opcao != "1") && (opcao != "2")) //Mensagem caso a opção seja inválida
                            {
                                System.Console.ForegroundColor = System.ConsoleColor.Red;
                                System.Console.WriteLine("    Erro! Entrada inválida!");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            }

                        } while ((opcao != "1") && (opcao != "2"));

                        switch (opcao)
                        {
                            case "1":
                                G2.Desligar();
                                break;
                            case "2":
                                System.Console.ForegroundColor = System.ConsoleColor.Green;
                                System.Console.WriteLine($"    Retornando ao menu principal...");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                                break;
                        }
                    }
                    else //Se estiver desligado ele printa outra mensagem
                    {
                        do //Tratar opção inválida
                        {
                            System.Console.Write("    G2 está desligado. Deseja ligar? ");
                            menu.MostrarOpcoes();
                            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                            opcao = System.Console.ReadLine();
                            System.Console.ForegroundColor = System.ConsoleColor.White;
                            opcao = opcao.Trim();

                            if ((opcao != "1") && (opcao != "2")) //Mensagem caso a opção seja inválida
                            {
                                System.Console.ForegroundColor = System.ConsoleColor.Red;
                                System.Console.WriteLine("    Erro! Entrada inválida!");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            }

                        } while ((opcao != "1") && (opcao != "2"));

                        switch (opcao)
                        {
                            case "1":
                                if (G1.GetStatus()=="Desligado")
                                {
                                    System.Console.ForegroundColor = System.ConsoleColor.Red;
                                    System.Console.WriteLine("    G2 não pode ser ligado por que G1 está desligado.");
                                    System.Console.ForegroundColor = System.ConsoleColor.Green;
                                    System.Console.WriteLine("    Retornando ao menu principal...");
                                    System.Console.ForegroundColor = System.ConsoleColor.White;
                                    System.Threading.Thread.Sleep(850);
                                    System.Console.Clear();
                                }
                                else
                                {
                                    G2.Ligar();
                                }
                            break;
                            case "2":
                                System.Console.ForegroundColor = System.ConsoleColor.Green;
                                System.Console.WriteLine($"    Retornando ao menu principal...");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            break;
                        }
                    }
                    break; //Aqui acaba G2

                case "G3":
                    if ((G3.GetStatus() == "Ligado")) //Se estiver ligado ele printa uma mensagem
                    {
                        do //Tratar opção inválida
                        {
                            System.Console.Write("    G3 está ligado. Deseja desligar? ");
                            menu.MostrarOpcoes();
                            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                            opcao = System.Console.ReadLine();
                            System.Console.ForegroundColor = System.ConsoleColor.White;
                            opcao = opcao.Trim();

                            if ((opcao != "1") && (opcao != "2")) //Mensagem caso a opção seja inválida
                            {
                                System.Console.ForegroundColor = System.ConsoleColor.Red;
                                System.Console.WriteLine("    Erro! Entrada inválida!");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            }

                        } while ((opcao != "1") && (opcao != "2"));

                        switch (opcao)
                        {
                            case "1":
                                G3.Desligar();
                                break;
                            case "2":
                                System.Console.ForegroundColor = System.ConsoleColor.Green;
                                System.Console.WriteLine($"    Retornando ao menu principal...");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                                break;
                        }
                    }
                    else //Se estiver desligado ele printa outra mensagem
                    {
                        do //Tratar opção inválida
                        {
                            System.Console.Write("    G3 está desligado. Deseja ligar? ");
                            menu.MostrarOpcoes();
                            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                            opcao = System.Console.ReadLine();
                            System.Console.ForegroundColor = System.ConsoleColor.White;
                            opcao = opcao.Trim();

                            if ((opcao != "1") && (opcao != "2")) //Mensagem caso a opção seja inválida
                            {
                                System.Console.ForegroundColor = System.ConsoleColor.Red;
                                System.Console.WriteLine("    Erro! Entrada inválida!");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            }

                        } while ((opcao != "1") && (opcao != "2"));

                        switch (opcao)
                        {
                            case "1":
                                if (G1.GetStatus() == "Desligado")
                                {
                                    System.Console.ForegroundColor = System.ConsoleColor.Red;
                                    System.Console.WriteLine("    G3 não pode ser ligado por que G1 está desligado.");
                                    System.Console.ForegroundColor = System.ConsoleColor.Green;
                                    System.Console.WriteLine("    Retornando ao menu principal...");
                                    System.Console.ForegroundColor = System.ConsoleColor.White;
                                    System.Threading.Thread.Sleep(850);
                                    System.Console.Clear();
                                }
                                else
                                {
                                    G3.Ligar();
                                }
                                break;
                            case "2":
                                System.Console.ForegroundColor = System.ConsoleColor.Green;
                                System.Console.WriteLine($"    Retornando ao menu principal...");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                                break;
                        }
                    }
                    break; //Aqui acaba G3

                case "G4":
                    if ((G4.GetStatus() == "Ligado")) //Se estiver ligado ele printa uma mensagem
                    {
                        do //Tratar opção inválida
                        {
                            System.Console.Write("    G4 está ligado. Deseja desligar? ");
                            menu.MostrarOpcoes();
                            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                            opcao = System.Console.ReadLine();
                            System.Console.ForegroundColor = System.ConsoleColor.White;
                            opcao = opcao.Trim();

                            if ((opcao != "1") && (opcao != "2")) //Mensagem caso a opção seja inválida
                            {
                                System.Console.ForegroundColor = System.ConsoleColor.Red;
                                System.Console.WriteLine("    Erro! Entrada inválida!");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            }

                        } while ((opcao != "1") && (opcao != "2"));

                        switch (opcao)
                        {
                            case "1":
                                G4.Desligar();
                                break;
                            case "2":
                                System.Console.ForegroundColor = System.ConsoleColor.Green;
                                System.Console.WriteLine($"    Retornando ao menu principal...");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                                break;
                        }
                    }
                    else //Se estiver desligado ele printa outra mensagem
                    {
                        do //Tratar opção inválida
                        {
                            System.Console.Write("    G4 está desligado. Deseja ligar? ");
                            menu.MostrarOpcoes();
                            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                            opcao = System.Console.ReadLine();
                            System.Console.ForegroundColor = System.ConsoleColor.White;
                            opcao = opcao.Trim();

                            if ((opcao != "1") && (opcao != "2")) //Mensagem caso a opção seja inválida
                            {
                                System.Console.ForegroundColor = System.ConsoleColor.Red;
                                System.Console.WriteLine("    Erro! Entrada inválida!");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                            }

                        } while ((opcao != "1") && (opcao != "2"));

                        switch (opcao)
                        {
                            case "1":
                                if (G1.GetStatus() == "Desligado")
                                {
                                    System.Console.ForegroundColor = System.ConsoleColor.Red;
                                    System.Console.WriteLine("    G4 não pode ser ligado por que G1 está desligado.");
                                    System.Console.ForegroundColor = System.ConsoleColor.Green;
                                    System.Console.WriteLine("    Retornando ao menu principal...");
                                    System.Console.ForegroundColor = System.ConsoleColor.White;
                                    System.Threading.Thread.Sleep(850);
                                    System.Console.Clear();
                                }
                                else
                                {
                                    G4.Ligar();
                                }
                                break;
                            case "2":
                                System.Console.ForegroundColor = System.ConsoleColor.Green;
                                System.Console.WriteLine($"    Retornando ao menu principal...");
                                System.Console.ForegroundColor = System.ConsoleColor.White;
                                System.Threading.Thread.Sleep(850);
                                System.Console.Clear();
                                break;
                        }
                    }
                    break; //Aqui acaba G4
            }
        }

        static void Opcao4(ref Gerador G1, ref Gerador G2, ref Gerador G3, ref Gerador G4)
        {
            string nome;

            System.Console.WriteLine();
            do //Se o gerador não existir, tratamento do erro
            {
                System.Console.Write($"    Informe o nome do gerador: ");
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                nome = System.Console.ReadLine();
                System.Console.ForegroundColor = System.ConsoleColor.White;
                nome = nome.Trim();
                nome = nome.ToUpper();

                if ((nome != "G1") && (nome != "G2") && (nome != "G3") && (nome != "G4")) //Mensagem de erro caso o gerador não exista
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Red;
                    System.Console.Write($"    Erro! O gerador {nome} não existe.");
                    System.Console.ForegroundColor = System.ConsoleColor.White;
                    System.Threading.Thread.Sleep(850);
                    System.Console.Clear();
                }

            } while ((nome != "G1") && (nome != "G2") && (nome != "G3") && (nome != "G4"));

            System.Console.Write($"    Quantidade de litros de combustível: ");
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            string c = Console.ReadLine();
            c = c.Trim();
            System.Console.ForegroundColor = System.ConsoleColor.White;

            int c2;

            try
            {
                c2 = Convert.ToInt32(c);
                switch (nome)
                {
                    case "G1":
                        G1.Abastecer(c2);
                        break;
                    case "G2":
                        G2.Abastecer(c2);
                        break;
                    case "G3":
                        G3.Abastecer(c2);
                        break;
                    case "G4":
                        G4.Abastecer(c2);
                        break;
                }
            }
            catch
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine($"    Erro! Entrada inválida!");
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"    Retornando ao menu principal...");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Threading.Thread.Sleep(850);
                System.Console.Clear();
            }
        }

        static void Opcao5(Gerador G1, Gerador G2, Gerador G3, Gerador G4)
        {
            string nome;

            System.Console.WriteLine();
            do //Se o gerador não existir, tratamento do erro
            {
                System.Console.Write($"    Informe o nome do gerador: ");
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                nome = System.Console.ReadLine();
                System.Console.ForegroundColor = System.ConsoleColor.White;
                nome = nome.Trim();
                nome = nome.ToUpper();

                if ((nome != "G1") && (nome != "G2") && (nome != "G3") && (nome != "G4")) //Mensagem de erro caso o gerador não exista
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Red;
                    System.Console.Write($"    Erro! O gerador {nome} não existe.");
                    System.Console.ForegroundColor = System.ConsoleColor.White;
                    System.Threading.Thread.Sleep(850);
                    System.Console.Clear();
                }

            } while ((nome != "G1") && (nome != "G2") && (nome != "G3") && (nome != "G4"));

            switch (nome)
            {
                case "G1":
                    G1.DetalhesGerador();
                break;
                case "G2":
                    G2.DetalhesGerador();
                break;
                case "G3":
                    G3.DetalhesGerador();
                break;
                case "G4":
                    G4.DetalhesGerador();
                break;
            }
        }
    }
}