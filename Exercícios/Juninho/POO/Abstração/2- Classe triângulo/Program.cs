/*

Crie uma classe que representa um triângulo.
Atributos:
- lado_a
- lado_b
- lado_c
Métodos:
- calcular_perimetro: retorna o perímetro do triângulo (soma dos três lados)
- maior_lado: retorna o maior lado do triângulo
Crie um programa que utilize esta classe. O programa deve pedir ao usuário que informe as
medidas dos três lados de um triângulo. Depois deve criar um objeto com essas medidas e exibir
seu perímetro e seu maior lado.

*/

using System;

namespace _2__Classe_triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            System.Console.Write("Informe o tamanho do lado A: ");
            t.ladoA = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Informe o tamanho do lado B: ");
            t.ladoB = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Informe o tamanho do lado C: ");
            t.ladoC = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            t.calcular_perimetro(t.ladoA, t.ladoB, t.ladoC);
            t.maior_lado();
        }
    }

    public class Triangulo {
        public double ladoA;
        public double ladoB;
        public double ladoC;
        public void calcular_perimetro(double a, double b, double c) {
            double per=a+b+c;
            System.Console.WriteLine($"O perímetro do triângulo é {per}.");
        }

        public void maior_lado() {
            if (ladoA>ladoB || ladoA>ladoC) {
                System.Console.WriteLine("O maior lado do triângulo é o lado A.");
            }

            else if (ladoB>ladoC) {
                System.Console.WriteLine("O maior lado do triângulo é o lado B.");
            }

            else {
                System.Console.WriteLine("O maior lado do triângulo é o lado C.");
            }
        }
    }
}
