using System;

namespace _1__Dissecando_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string [4,4];

            preencherMatriz(matriz);

            menuOpcoes(matriz);
        }



        static void x (string[,] m) { //Função para preencher a matriz com X. Essa função tem seu retorno na função que preenche a matriz com valores digitados pelo usuário. Recebe como parâmetro a matriz a ser preenchida.
            for (int l=0; l<4; l++) {
                for (int c=0; c<4; c++) {
                    m[l,c] = "X";
                }
            }
        }



        static void preencherMatriz (string[,] m) { //Função para preencher a matriz com valores enviados pelo usuário. Tem como parâmetro a matriz a ser preenchida.
            int linha=0;

            x(m); //Preenche a matriz com X.

            for (int t=0; t<=16; t++) {

                System.Console.WriteLine("PREENCHA A MATRIZ COM NÚMEROS NATURAIS: \n");
                
                for (int l=0; l<4; l++) {
                    for (int c=0; c<4; c++) {
                        System.Console.Write($"{m[l,c],2} "); //Digita e insere dois espaços
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();

                if (t<4) {
                    m[0,linha] = Console.ReadLine();
                    linha++;
                }
                else if (t==4) {
                    linha=0;
                    m[1,linha] = Console.ReadLine();
                    linha++;
                }
                else if (t>4 && t<8) {
                    m[1,linha] = Console.ReadLine();
                    linha++;
                }
                else if (t==8) {
                    linha=0;
                    m[2,linha] = Console.ReadLine();
                    linha++;
                }
                else if (t>8 && t<12) {
                    m[2,linha] = Console.ReadLine();
                    linha++;
                }
                else if (t==12) {
                    linha=0;
                    m[3,linha] = Console.ReadLine();
                    linha++;
                }
                else if (t>12 && t<16) {
                    m[3,linha] = Console.ReadLine();
                    linha++;
                }
                
                Console.Clear();
            }
        }



        static void menuOpcoes(string[,] m) { //Cria o menu de opções e faz as matrizes de acordo com as opções
            int opcao;

            do {
                System.Console.WriteLine("MENU DE OPÇÕES \n");

                System.Console.WriteLine("[1] Mostrar a matriz");
                System.Console.WriteLine("[2] Diagonal principal");
                System.Console.WriteLine("[3] Triângulo superior");
                System.Console.WriteLine("[4] Triângulo inferior");
                System.Console.WriteLine("[5] Sair \n");
                opcao = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao) {
                    case 1:
                        Console.Clear();
                        for (int l=0; l<4; l++) {
                            for (int c=0; c<4; c++) {
                                System.Console.Write($"{m[l,c],2} ");
                            }
                            System.Console.WriteLine();
                        }
                        System.Console.WriteLine();
                    break;
                        
                    case 2:
                        Console.Clear();
                        for (int l=0; l<4; l++) {
                            for (int c=0; c<4; c++) {
                                if (c==l) {
                                    System.Console.Write($"{m[l,c],2} ");
                                }
                                else {
                                    System.Console.Write($"   ");
                                }
                            }
                            System.Console.WriteLine();
                        }
                        System.Console.WriteLine();
                    break;

                    case 3:
                        Console.Clear();
                        for (int l=0; l<4; l++) {
                            for (int c=0; c<4; c++) {
                                if (c!=l && c>l) {
                                    System.Console.Write($"{m[l,c],2} ");
                                }
                                else {
                                    System.Console.Write($"   ");
                                }
                            }
                            System.Console.WriteLine();
                        }
                        System.Console.WriteLine();
                    break;

                    case 4:
                        Console.Clear();
                        for (int l=0; l<4; l++) {
                            for (int c=0; c<4; c++) {
                                if (c!=l && c<l) {
                                    System.Console.Write($"{m[l,c],2} ");
                                }
                                else {
                                    System.Console.Write($"   ");
                                }
                            }
                            System.Console.WriteLine();
                        }
                        System.Console.WriteLine();
                    break;

                    case 5:
                        Console.Clear();
                        System.Console.WriteLine("ENCERRANDO...");
                    break;
                }

            } while (opcao!=5);
        }
    }
}
