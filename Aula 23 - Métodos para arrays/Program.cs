using System;

namespace Aula_23___Métodos_para_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int [5];
            int[] vetor2 = new int [5];
            int[] vetor3 = new int [5];
            int[,] matriz = new int [2,5] {{11, 22, 00, 44, 55}, {66, 77, 88, 99, 00}};

            //Atribui valores aleatórios de 0-50 para o array vetor1.
            System.Console.WriteLine("Random");
            Random random = new Random();
            for (int i=0; i<vetor1.Length; i++) {
                vetor1[i] = random.Next(50); 
            }
            System.Console.WriteLine("Vetor 1: ");
            foreach (int v in vetor1) {
                System.Console.Write("{0} ", v);
            }
            System.Console.WriteLine("\n");


            //Localiza a posição de algum elemento em algum array. Se o valor for inexistente, retorna um valor negativo. O vetor tem que estar organizado com sort.
            System.Console.WriteLine("BinarySearch");
            int procurado = 33;
            int posicao = Array.BinarySearch(vetor1, procurado); //Coloque no segundo parâmetro o elemento procurado no array, e este deverá ser o primeiro parâmetro.
            System.Console.WriteLine("O valor {0} está na posição {1}", procurado, posicao);
            System.Console.WriteLine("\n");


            //Copia elementos de outro array. 
            System.Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length); //(Array de origem, Array de destino, Quantidade de elementos que você quer copiar)
            foreach (int n in vetor2) {
                System.Console.Write("{0} ", n);
            }
            System.Console.WriteLine("\n");


            //Copia elementos para outro array.
            System.Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0); //(Array de destino, A partir de qual posição você quer enviar)
            foreach (int n in vetor3) {
                System.Console.Write("{0} ", n);
            }
            System.Console.WriteLine("\n");


            //Pega a quantidade de elementos do array.
            System.Console.WriteLine("GetLongLength");
            long quantidadeElementoVetor1 = vetor1.GetLongLength(0); //(dimensão. Vetores é sempre 0. Se for uma matriz, coloque a linha que você quer.)
            System.Console.WriteLine("A quantidade de elementos do vetor 1 é {0}", quantidadeElementoVetor1);
            System.Console.WriteLine("\n");


            //Pega o maior índice do array.
            System.Console.WriteLine("GetUpperBound");
            int maiorIndiceVetor1 = vetor1.GetUpperBound(0); //dimensão
            int maiorIndiceMatriz = matriz.GetUpperBound(1);
            System.Console.WriteLine("O maior índice do vetor 1 é {0} e o da matriz é {1}", maiorIndiceVetor1, maiorIndiceMatriz);
            System.Console.WriteLine("\n");


            //Pega o menor índice do array.
            System.Console.WriteLine("GetLowerBound");
            int menorIndiceVetor1 = vetor1.GetLowerBound(0); //dimensão
            int menorIndiceMatriz = matriz.GetLowerBound(1);
            System.Console.WriteLine("O menor índice do vetor 1 é {0} e o da matriz é {1}", menorIndiceVetor1, menorIndiceMatriz);
            System.Console.WriteLine("\n");


            //Pega o elemento a partir de um índice.
            System.Console.WriteLine("GetValue");
            int valor0 = Convert.ToInt32(vetor1.GetValue(3));
            int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
            System.Console.WriteLine("Valor do índice 3 do vetor 1: {0} \nValor do índice 3 da segunda linha da matriz: {1}", valor0, valor1);
            System.Console.WriteLine("\n");


            //Pega o índice a partir de um elemento. Se inexistente, retorna -1. Se houver mais de um elemento, ele vai pegar a posição do primeiro sempre.
            System.Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1,3); //(array, valor)
            System.Console.WriteLine("O índice do valor 3 é {0}", indice1);
            System.Console.WriteLine("\n");


            //Análogo ao IndexOf. Pega o índice da última ocorrência do elemento. Se inexistente, retorna -1.
            System.Console.WriteLine("LastIndexOf");
            int indice2 = Array.LastIndexOf(vetor1, 3); //Array, valor
            System.Console.WriteLine("O índice do último valor 3 é {0}", indice2);
            System.Console.WriteLine("\n");


            //Dispõe os elementos na ordem contrária. Não confunda com decrescente.
            System.Console.WriteLine("Reverse");
            Array.Reverse(vetor1); //Array
            foreach (int n in vetor1) {
                System.Console.Write("{0} ", n);
            }
            System.Console.WriteLine("\n");


            //Organiza os elementos em ordem crescente. Para colocar em ordem decrescente, aplique este e depois o reverse.
            System.Console.WriteLine("Sort");
            Array.Sort(vetor3);
            foreach (int j in vetor3) {
                System.Console.Write("{0} ", j);
            }
            System.Console.WriteLine("\n");


            //Colocar um valor em alguma posição
            System.Console.WriteLine("SetValue");
            vetor2.SetValue(99, 0); //Valor, posição
            foreach (int n in vetor2) {
                System.Console.Write("{0} ", n);
            }
        }
    }
}
