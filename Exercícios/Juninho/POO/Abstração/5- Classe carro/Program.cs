/*

Implemente uma classe Carro
Propriedades:
- consumo (medidos em km/litro): O consumo deve ser especificado no construtor.
- quantidade_combustivel (quantidade de litros de combustível no tanque do carro): a
quantidade inicial deve ser zero
Métodos:
- adicionar_combustivel: recebe uma quantidade de litros de combustível para abastecer o
tanque.
- obter_combustivel: retorna a quantidade atual de combustível.
- andar: recebe uma distância em km e simula o ato de dirigir o veículo por essa distância,
reduzindo o nível de combustível no tanque de gasolina (de acordo com o consumo do
veículo)
Faça um programa para testar a classe Carro. Veja abaixo um trecho de programa que utiliza a
classe:
fusca = Carro(15) // 15 quilômetros por litro de combustível
fusca.adicionar_combustivel(20) // abastece com 20 litros de combustível
fusca.andar(100) // anda 100 quilômetros.
print(fusca.obter_combustivel()) // imprime o combustível que resta no tanque

*/

using System;

namespace _5__Classe_carro
{
    class Program 
    {
        static void Main(string[] args)
        {
            Carro bmw = new Carro(15);

            bmw.AdicionarCombustivel(20);
            bmw.Andar(100);
            bmw.ObterCombustivel();
        }
    }

    public class Carro 
    {
        int consumo;
        int quantidadeCombustivel; 

        public Carro(int kml) {
            consumo=kml;
            quantidadeCombustivel=0;
        }

        public void AdicionarCombustivel(int addc) {
            quantidadeCombustivel+=addc;
        }

        public void Andar(int dist) {
            dist=dist/consumo;
            quantidadeCombustivel-=dist;
        }

        public void ObterCombustivel() {
            System.Console.WriteLine(quantidadeCombustivel);
        }
    }
}
