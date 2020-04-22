using System.Collections;
using System;

namespace _14__Analisador_de_números
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantos números você quer inserir? ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            ArrayList lista = new ArrayList();
            
            for (int c=0; c<n; c++) { 
                System.Console.Write($"Número {c+1}: ");
                lista.Add(Convert.ToDouble(Console.ReadLine())); //Adiciona o número na última posição do ArrayList.
            }
            Console.Clear();
            
            //RESULTADOS
            double soma=0; //Guarda o valor da soma de todos os resultados. A cada função, ela é atualizada. É atualizada por referência.

            double maior = maiorNumero(lista); //Guarda o maior número, retornado pela função. 
            System.Console.WriteLine($"O maior número digitado é {maior}.");

            double menor = menorNumero(lista, maior, out soma); //Guarda o menor número. A função recebe como parâmetros a lista, o maior número que já foi calculado pela função anterior, e um parâmetro de saída, que é a soma do maior com o menor número.
            System.Console.WriteLine($"O menor número digitado é {menor}."); 

            double somaN = somaNumeros(lista, soma, out soma); //Guarda a soma de todos os números. A função recebe como parâmetros a lista, a soma atual de todos os resultados, e um parâmetro de saída, que é a nova soma dos resultados: Do maior, menor e a soma de todos os números.
            System.Console.WriteLine($"A soma de todos os números digitados é {somaN}."); 

            double mediaN = mediaNumeros(lista, somaN, soma, out soma); //Guarda a média de todos os números. A função recebe como parâmetros a lista, a soma de todos os números que já foi calculada pela função anterior, a soma atual de todos os resultados, e um parâmetro de saída, que é a nova soma dos resultados: Do maior, menor, a soma de todos os números e a média de todos os números.
            System.Console.WriteLine($"A média de todos os números digitados é {mediaN}."); 

            System.Console.WriteLine($"A soma de todos os resultados anteriores é {soma}.");
        }



        static double maiorNumero(ArrayList l) { //Calcula o maior número. Recebe como parâmetro a lista.
            double maior=0;

            foreach (double v in l) {
                if (maior<v) {
                    maior=v;
                }
            }
            
            return maior;
        }



        static double menorNumero(ArrayList l, double m, out double somaSaida) { //Calcula o menor número. Recebe como parâmetros a lista, o maior número que já foi calculado pela função anterior, e um parâmetro de saída, que é a soma do maior com o menor número.
            double menor=m;

            foreach (double v in l) {
                if (v<menor) {
                    menor=v;
                }
            }

            somaSaida = menor+m;

            return menor;
        }



        static double somaNumeros(ArrayList l, double somaEntrada, out double somaSaida) { //Calcula a soma de todos os números digitados. Recebe como parâmetros a lista, a soma atual de todos os resultados, e um parâmetro de saída, que é a nova soma dos resultados: Do maior, menor e a soma de todos os números.
            double soma = 0;

            foreach (double v in l) {
                soma += v;
            }

            somaSaida = soma+somaEntrada;

            return soma;
        }



        static double mediaNumeros(ArrayList l, double somaTodosNumeros, double somaEntrada, out double somaSaida) { //Calcula a média de todos os números. Recebe como parâmetros a lista, a soma de todos os números que já foi calculada pela função anterior, a soma atual de todos os resultados, e um parâmetro de saída, que é a nova soma dos resultados: Do maior, menor, a soma de todos os números e a média de todos os números.
            double qtdNumeros = 0;

            foreach (double v in l) {
                qtdNumeros += 1;
            }

            double media = somaTodosNumeros/qtdNumeros;

            somaSaida = somaEntrada+media;

            return media;
        }
    }
}