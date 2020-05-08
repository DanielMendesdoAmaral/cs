/*

Crie a classe Motor que contém cilindrada e potencia.
Crie a classe Veiculo contendo ano de fabricação, preco e motor. Crie também o metodo exibir_dados para mostrar os dados do Veículo.
Crie a classe Carro, que herda da classe Veiculo e inclua os atributos cor e modelo. Crie também o metodo exibir_dados para mostrar os dados do Carro.
Crie a classe Caminhão, que herda da classe Veiculo e inclua o atributos comprimento (em metros). Crie também o metodo exibir_dados para mostrar os dados do Caminhão.

Utilize o programa abaixo para testar as classes
motor1 = Motor(1000, 500)
motor2 = Motor(8000, 900)
carro = Carro(2010, 20000, motor1, "branca", "gol")
caminhao = Caminhao(2015, 80000, motor2, 10)
carro.exibir_dados() # imprime os valores de todos os atributos do carro
caminhao.exibir_dados() # imprime os valores de todos os atributos do caminhão 

*/

using System;

namespace _5__Um_veículo_TEM_UM_motor__carro_e_caminhão_SÃO_veículos
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new Motor(1000, 500);
            Motor motor2 = new Motor(8000, 900);
            Carro carro = new Carro(2020, 20000, motor1, "Branco", "BMW");
            Caminhao caminhao = new Caminhao(2015, 80000, motor2, 10);

            carro.ExibirDados();
            caminhao.ExibirDados();
        }
    }

    public class Motor {
        private int cilindrada;
        private int potencia;

        public Motor(int c, int p) {
            SetCilindrada(c);
            SetPotencia(p);
        }

        public int GetCilindrada() {
            return cilindrada;
        }
        public int GetPotencia() {
            return potencia;
        }

        public void SetCilindrada(int c) {
            cilindrada=c;
        }
        public void SetPotencia(int p) {
            potencia=p;
        }
    }

    public interface IVeiculo {
        void ExibirDados();
    }

    public class Veiculo : IVeiculo {
        private int ano;
        private double preco;
        private Motor motor;

        public Veiculo(int a, double p, Motor m) {
            SetAno(a);
            SetPreco(p);
            SetMotor(m);
        }

        public int GetAno() {
            return ano;
        }
        public double GetPreco() {
            return preco;
        }
        public Motor GetMotor() {
            return motor;
        }

        public void SetAno(int a) {
            ano=a;
        }
        public void SetPreco(double p) {
            preco=p;
        }
        public void SetMotor(Motor m) {
            motor=m;
        }

        virtual public void ExibirDados() {
            System.Console.Write($"ANO: {GetAno()}\nPREÇO: {GetPreco()}\nCARACTERÍSTICAS DO MOTOR\nCILINDRADA: {motor.GetCilindrada()}\nPOTÊNCIA: {motor.GetPotencia()}\n\n");
        }
    }

    public interface ICarro {
        void ExibirDados();
    }

    public class Carro : Veiculo, ICarro {
        private string cor;
        private string modelo;

        public Carro(int a, double p, Motor m, string c, string model) : base(a, p, m) {
            SetCor(c);
            SetModelo(model);
        }

        public string GetCor() {
            return cor;
        }
        public string GetModelo() {
            return modelo;
        }

        public void SetCor(string c) {
            cor=c;
        }
        public void SetModelo(string m) {
            modelo=m;
        }

        override public void ExibirDados() {
            System.Console.Write($"ANO: {GetAno()}\nPREÇO: {GetPreco()}\nCARACTERÍSTICAS DO MOTOR\nCILINDRADA: {GetMotor().GetCilindrada()}\nPOTÊNCIA: {GetMotor().GetPotencia()}\nCOR: {GetCor()}\nMODELO: {GetModelo()}\n\n");
        }
    }

    public interface ICaminhao {
        void ExibirDados();
    }

    public class Caminhao : Veiculo, ICaminhao {
        private double comprimento;

        public Caminhao(int a, double p, Motor m, double c) : base(a, p, m) {
            SetComprimento(c);
        }

        public double GetComprimento() {
            return comprimento;
        }
        public void SetComprimento(double c) {
            comprimento=c;
        }

        override public void ExibirDados() {
            System.Console.Write($"ANO: {GetAno()}\nPREÇO: {GetPreco()}\nCARACTERÍSTICAS DO MOTOR\nCILINDRADA: {GetMotor().GetCilindrada()}\nPOTÊNCIA: {GetMotor().GetPotencia()}\nCOMPRIMENTO: {GetComprimento()}\n\n");
        }
    }
}