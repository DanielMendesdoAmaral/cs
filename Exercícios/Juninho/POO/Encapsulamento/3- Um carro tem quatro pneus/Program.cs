/*

Classe Carro:
Atributos:
- ligado: valor booleano que indica se o carro está ligado ou desligado (deve iniciar
com o valor False)
- pneu1, pneu2, pneu3, pneu4: objetos do tipo Pneu que representa cada um dos
pneus do carro (devem receber os valores no construtor).
Métodos:
- ligar: altera o valor do atributo ligado para True
- desligar: altera o valor do atributo ligado para False
- verificar_pneu: se o carro estiver ligado, esse método deve exibir a pressão de cada
um dos pneus. Se o carro estiver desligado, o método deve exibir a mensagem
‘Carro Desligado'


Classe Pneu:
Atributos:
- pressao: valor inteiro que indica a pressão de ar do pneu (inicializado no construtor)
Métodos:
- furar(): simula um pneu furado, alterando o valor do atributo pressao para zero.


Você pode utilizar o trecho de programa abaixo para testar as suas classes.

p1 = Pneu(32)
p2 = Pneu(32)
p3 = Pneu(36)
p4 = Pneu(36)
meucarro = Carro(p1, p2, p3, p4)
meucarro.ligar()
meucarro.pneu3.furar()
meucarro.verificar_pneu() // exibir a pressão de cada pneu.
meucarro.desligar()
meucarro.verificar_pneu() // exibir mensagem que o carro está desligado

*/

using System;

namespace _3__Um_carro_tem_quatro_pneus
{
    class Program
    {
        static void Main(string[] args)
        {
            Pneu p1 = new Pneu(32);
            Pneu p2 = new Pneu(32);
            Pneu p3 = new Pneu(36);
            Pneu p4 = new Pneu(36);

            Carro meuCarro = new Carro(p1, p2, p3, p4);

            meuCarro.ligar();
            meuCarro.getPneu3().furar();
            meuCarro.verificarPneu();
            meuCarro.desligar();
            meuCarro.verificarPneu();
        }
    }

    public interface ICarro {
        void ligar();
        void desligar();
        void verificarPneu();
    }

    public class Carro : ICarro {
        private bool ligado;
        private Pneu pneu1;
        private Pneu pneu2;
        private Pneu pneu3;
        private Pneu pneu4;

        public Carro(Pneu p1, Pneu p2, Pneu p3, Pneu p4) {
            setPneu1(p1);
            setPneu2(p2);
            setPneu3(p3);
            setPneu4(p4);
        }

        public bool getLigado() {
            return ligado;
        }
        public Pneu getPneu1() {
            return pneu1;
        }
        public Pneu getPneu2() {
            return pneu2;
        }
        public Pneu getPneu3() {
            return pneu3;
        }
        public Pneu getPneu4() {
            return pneu4;
        }
        
        private void setLigado(bool l) {
            ligado=l;
        }
        private void setPneu1(Pneu p) {
            pneu1=p;
        }
        private void setPneu2(Pneu p) {
            pneu2=p;
        }
        private void setPneu3(Pneu p) {
            pneu3=p;
        }
        private void setPneu4(Pneu p) {
            pneu4=p;
        }

        public void ligar() {
            setLigado(true);
        }
        public void desligar() {
            setLigado(false);
        }
        public void verificarPneu() {
            if (ligado==true) {
                System.Console.WriteLine($"PRESSÃO DOS PNEUS\nPneu 1: {pneu1.getPressao()}\nPneu 2: {pneu2.getPressao()}\nPneu 3: {pneu3.getPressao()}\nPneu 4: {pneu4.getPressao()}");
            }
            else {
                System.Console.WriteLine("Carro desligado.");
            }
        }
    }

    public interface IPneu {
        void furar();
    }

    public class Pneu : IPneu{
        private int pressao;

        public Pneu(int p) {
            pressao=p;
        }

        public int getPressao() {
            return pressao;
        }
        public void setPressao(int p) {
            pressao=p;
        }

        public void furar() {
            pressao=0;
        }
    }
}