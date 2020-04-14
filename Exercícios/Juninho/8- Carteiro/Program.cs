/* Luíz Carlos é um carteiro muito comprometido com seu trabalho. Ele participou de uma reunião recente em que foi informado de que deveria entregar pelo menos 100 correspondências por dia para dar conta do grande fluxo de envios na época de Natal.

Escreva um programa que receba como entrada a quantidade de correspondências entregues por ele em cada um dos sete dias da semana, e exiba em quantos dias ele cumpriu a meta, e a média de entregas diárias que ele fez no período.

 

Formato de entrada

Valores inteiros

Formato de saída

Um valor inteiro para a quantidade de dias, e outro valor inteiro para a média de entregas

Exemplos de:

Entrada

100
120
140
80
105
130
75

SAÍDA:
5
107 */

using System;

namespace _8__Carteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dias = new int[8];
            int diaEntrega = 0, media = 0;

            for (int contador = 1; contador <= 7; contador++) {
                dias[contador] = Int32.Parse(Console.ReadLine());
                media += dias[contador];
                if (dias[contador]>=100) {
                    diaEntrega++;
                }
            }

            Console.Clear();

            media /= 7;
            System.Console.WriteLine("O carteiro cumpriu a meta em: " + diaEntrega + " dia(s). A média de entregas por dia foi de: " + media + " cartas por dia.");
        }
    }
}
