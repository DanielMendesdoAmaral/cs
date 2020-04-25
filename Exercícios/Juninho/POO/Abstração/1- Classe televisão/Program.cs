/* 

Implemente uma classe Televisao.
Atributos:
- canal (o canal inicial da tv deve ser None)
- volume (o volume inicial da tv deve ser zero)
Métodos:
- aumentar_volume: aumenta o nível de volume em uma unidade
- diminuir_volume: diminui o nível de volume em uma unidade
- alterar_canal: recebe o número do canal que será sintonizado e altera o canal da tv
Faça um programa para criar um objeto Televisao e testar a sua classe. Veja abaixo um trecho de
programa que utiliza a classe:
tv = Televisao()
tv.alterar_canal(5)
tv.aumentar_volume()
tv.aumentar_volume()
tv.aumentar_volume()
tv.diminuir_volume()
print('A tv está no canal:', tv.canal) // imprime 5
print('A tv está no volume:', tv.volume) // imprime 2

*/

using System;

namespace _1__Classe_televisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisao tv = new Televisao();
            tv.alterar_canal(5);
            tv.aumentar_volume();
            tv.aumentar_volume();
            tv.aumentar_volume();
            tv.diminuir_volume();

            System.Console.WriteLine($"A tv está no canal {tv.canal}");
            System.Console.WriteLine($"A tv está no volume {tv.volume}");
        }
    }


    public class Televisao 
    {
        public int canal=0;
        public int volume=0;

        public void aumentar_volume() {
            volume+=1;
        }

        public void diminuir_volume() {
            volume-=1;
        }

        public int alterar_canal(int c) {
            canal=c;
            return canal;
        }

    }
}
