using System;

namespace Aula_34___Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(true, 320, "Preto"); //Objeto carro com teto aberto
            Caminhao caminhao = new Caminhao(true, 180, "Vermelho"); //Objeto caminhao carregado
        }
    }

    //(Foram criados exemplos simples. Caminhão e carro são veículos, mas cada um tem suas peculiaridades.) Uma classe filha também pode ter uma filha.

    public class Veiculo {
        private int velocidadeMaxima;
        private string cor;

        public Veiculo(int v, string c) {
            velocidadeMaxima=v;
            cor=c;
        }

        public int GetVelocidadeMaxima() {
            return velocidadeMaxima;
        }
        public string GetCor() {
            return cor;
        }

        public void SetVelocidadeMaxima(int v) {
            velocidadeMaxima=v;
        }
        public void SetCor(string c) {
            cor=c;
        }
    }

    public interface ICaminhao {
        void Carregar();
        void Descarregar();
    }

    public class Caminhao : Veiculo, ICaminhao{ //A classe caminhão é filha de Veículo, e implementa a interface ICaminhao.
        private bool carregado;

        public Caminhao(bool c, int v, string cor) : base (v, cor) { //Precisa colocar isso para os construtores também. Assim, você irá relacionar os construtores da classe mãe com os da classe filha.
            SetCarregado(c);
        }

        public bool GetCarregado() {
            return carregado;
        }
        public void SetCarregado(bool c) {
            carregado=c;
        }

        public void Carregar() {
            SetCarregado(true);
        }

        public void Descarregar() {
            SetCarregado(false);
        }
    }

    public interface ICarro {
        void Fechar();
        void Abrir();
    }

    public class Carro : Veiculo, ICarro {
        private bool tetoSolarAberto;

        public Carro(bool t, int v, string c) : base(v, c) {
            SetTetoSolarAberto(t);
        }

        public bool GetTetoSolarAberto() {
            return tetoSolarAberto;
        }

        public void SetTetoSolarAberto(bool t) {
            tetoSolarAberto=t;
        }

        public void Fechar() {
            SetTetoSolarAberto(false);
        }

        public void Abrir() {
            SetTetoSolarAberto(true);
        }
    }
}
