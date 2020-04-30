/*
 _______________        ______________
| <<interface>> | <--- |ControleRemoto|
|  Controlador  |      |--------------|
|---------------|      |-volume       |
|+ligar()       |      |-ligado       |
|+desligar()    |      |-tocando      |
|+abrirMenu()   |      |--------------|
|+fecharMenu()  |      |IMPLEMENTAR TO|
|+maisVolume()  |      |DOS OS MÉTODOS|
|+menosVolume() |      |DA INTERFACE  |
|+ligarMudo()   |      |CONTROLADOR   |
|+desligarMudo()|      |E COLOCAR SET |
|+play()        |      |TERS E GETTERS|
|+pause()       |      |PRIVADOS PARA |
|---------------|      |TODO ATRIBUTO |
                       |--------------|

A UML acima indica que a classe ControleRemoto vai implementar a interface Controlador. Isso é importantíssimo para o encapsulamento, pois agora você não mais mexerá diretamente na classe, e ela ficará protegida. Também ficará mais fácil reutilizar o código em outro programa, etc. Setters e Getters podem e é até recomendado serem públicos. Mas para este exercício faça eles serem privados. Quando falamos de encapsulamento, sempre usamos atributos privados e no máximo protegidos, mas nunca públicos. 

*/                     

using System;

namespace _1__Classe_ControleRemoto
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleRemoto c = new ControleRemoto();
            c.ligar();
            c.abrirMenu();

            c.maisVolume();
            c.maisVolume();
            c.abrirMenu();

            c.menosVolume();
            c.menosVolume();
            c.menosVolume();
            c.abrirMenu();

            c.ligarMudo();
            c.abrirMenu();

            c.desligarMudo();
            c.abrirMenu();

            c.pause();
            c.abrirMenu();

            c.play();
            c.abrirMenu();

            c.desligar();
            c.abrirMenu();
        }
    }

    //INTERFACE
    public interface IControlador { //É uma boa prática nomear interfaces com um I no começo. Não tem bloco de código para os métodos daqui, pois é uma interface. 
        void ligar();
        void desligar();
        void abrirMenu();
        void fecharMenu();
        void maisVolume();
        void menosVolume();
        void ligarMudo();
        void desligarMudo();
        void play();
        void pause();
    }

    //CLASSE
    public class ControleRemoto:IControlador { //A classe implementa, ou, adquire a interface. Agora, você fará o bloco de código de cada método criado na interface.
        //ATRIBUTOS
        private int volume;
        private bool ligado;
        private bool tocando;


        //CONSTRUTOR
        public ControleRemoto() {
            volume=50;
            ligado=false;
            tocando=false;
        }


        //GETTERS/SETTERS
        private int getVolume() {
            return volume;
        }
        private void setVolume(int v) {
            volume=v;
        }
        private bool getLigado() {
            return ligado;
        }
        private void setLigado(bool l) {
            ligado=l;
        }
        private bool getTocando() {
            return tocando;
        }
        private void setTocando(bool t) {
            tocando=t;
        }


        //MÉTODOS DA INTERFACE
        public void ligar() {
            setLigado(true);
            setTocando(true);
        }
        public void desligar() {
            setLigado(false);
            setTocando(false);
        }
        public void abrirMenu() {
            System.Console.Write($"LIGADO: {ligado}\nVOLUME: {volume} ");
            for (int c=0; c<volume/10; c++) {
                System.Console.Write("|");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"TOCANDO: {tocando} \n");
        }
        public void fecharMenu() {
            Console.Clear();
            System.Console.WriteLine("MENU FECHADO \n");
        }
        public void maisVolume() {
            if ((getLigado()==true) && (volume<100)) {
                setVolume(volume+=10);
            }
        }
        public void menosVolume() {
            if ((getLigado()==true) && (volume>0)) {
                setVolume(volume-=10);
            }
        }
        public void ligarMudo() {
            if (getLigado()==true) {
                setVolume(0);
            }
        }
        public void desligarMudo() {
            if ((getLigado()==true) && (getVolume()==0)) {
                setVolume(50);
            }
        }
        public void play() {
            if ((getLigado()==true) && (getTocando()==false)) {
                setTocando(true);
            }
        }
        public void pause() {
            if ((getLigado()==true) && (getTocando()==true)) {
                setTocando(false);
            }
        }
    }
}