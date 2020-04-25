/* Construa uma função que desenhe um retângulo usando os caracteres ‘+’ , ‘−’ e ‘| ‘. Esta função deve receber dois parâmetros, linhas e colunas, sendo que o valor por omissão é o valor mínimo igual a 2 e o valor máximo é 20. Se valores fora da faixa forem informados, eles devem ser modificados para valores dentro da faixa de forma elegante. */

using System;

namespace _5__Desenha_moldura
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OBS: DIGITE VALORES INTEIROS ENTRE 2 E 20. CASO VOCÊ NÃO DIGITE UM VALOR OU DIGITE UM VALOR FORA DESSE INTERVALO, ELE SERÁ MODIFICADO AUTOMATICAMENTE. \n");

            System.Console.Write("Quantos cm de comprimento você deseja para a sua moldura? ");
            int colunas = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Quantos cm de altura você deseja para a sua moldura? ");
            int linhas = Convert.ToInt32(Console.ReadLine());

            tratarInformacoes(ref linhas, ref colunas);

            Console.Clear();

            System.Console.WriteLine($"Aqui está a sua moldura, de {colunas}cm de comprimento e {linhas}cm de altura: \n");
            moldura(linhas, colunas);
        }



        static void tratarInformacoes(ref int l, ref int c) { //Trata as informações e passa o valor por referência. Ou seja, ele atualiza definitivamente o valor da variável.
            if (l<2) {
                l=2;
            }
            else if (l>20) {
                l=20;
            }

            if (c<2) {
                c=2;
            }
            else if (c>20) {
                c=20;
            }
        }



        static void moldura(int l, int c) { //Cria a moldura.
            string diagonal="+", comprimento="-", altura="|"; //Peças

            for (int contador1=1; contador1<=l; contador1++) { //Linhas, ou, altura
                for (int contador2=1; contador2<=c; contador2++) { //Colunas, ou, comprimento
                    if (contador1==1 && contador2==1) { //Se tiver na primeira linha e na primeira coluna coloca +
                        System.Console.Write(diagonal);
                    }
                    else if (contador1==1 && contador2==c) { //Se tiver na primeira linha e na última coluna coloca +
                        System.Console.Write(diagonal);
                    }
                    else if (contador1==1) { //Se tiver na primeira linha, após a primeira coluna e antes da última coluna, coloca -
                        System.Console.Write(comprimento);
                    }

                    if (contador1>1 && contador1<l && contador2==1) { //Se tiver após a primeira linha e antes da última linha e na primeira coluna coloca |
                        System.Console.Write(altura);
                    }
                    else if (contador1>1 && contador1<l && contador2==c) { //Se tiver após a primeira linha e antes da última linha e na última coluna coloca |
                        System.Console.Write(altura);
                    }
                    else if (contador1>1 && contador1<l ) { //Se tiver após a primeira linha e antes da última linha e depois da primeira coluna e antes da última coluna coloca " "
                        System.Console.Write(" ");
                    }

                    if (contador1==l && contador2==1) { //Se tiver na última linha e na primeira coluna coloca +
                        System.Console.Write(diagonal);
                    }
                    else if (contador1==l && contador2==c) { //Se tiver na última linha e na última coluna coloca +
                        System.Console.Write(diagonal);
                    }
                    else if (contador1==l) { //Se tiver na última linha, após a primeira coluna e antes da última coluna, coloca -
                        System.Console.Write(comprimento);
                    }

                    if (contador2==c) { //Se completar uma linha, pula a linha
                        System.Console.WriteLine();
                    }
                }
            }
        }
    }
}