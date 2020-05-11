/*

Um banco trabalha com três tipos de contas:
- conta corrente comum
- conta corrente com limite
- conta poupança
Em todos os casos é necessário guardar o número da conta, o nome do correntista e o saldo.
Para a conta poupança é necessário guardar o dia do aniversário da conta (quando são creditados
os juros).
Já para a conta com limite é necessário guardar o valor do limite.
As operações possíveis são: depósito, saque e impressão de saldo.
Essas operações devem ser definidas numa classe abstrata denominada Conta.
A operação de depósito e saldo são iguais para os três tipos de conta.
A operação de saque só é diferente na conta com limite, pois esta admite que o saldo fique
negativo até o limite estabelecido.
Nas demais contas o saque não pode ser realizado se não houver saldo suficiente.
Implemente a hierarquia de classes definida acima.

*/

using System;

namespace _5__Várias_formas_de_depositar__sacar_e_imprimir_saldo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract public class Conta {
        private int numeroConta;
        private string nomeCorrentista;
        private double saldo;

        public Conta(int n, string no, double s) {
            SetNumeroConta(n);
            SetNomeCorrentista(no);
            SetSaldo(s);
        }

        public int GetNumeroConta() {
            return numeroConta;
        }
        public void SetNumeroConta(int n) {
            numeroConta=n;
        }
        public string GetNomeCorrentista() {
            return nomeCorrentista;
        }
        public void SetNomeCorrentista(string n) {
            nomeCorrentista=n;
        }
        public double GetSaldo() {
            return saldo;
        }
        public void SetSaldo(double s) {
            saldo=s;
        }

        abstract public void Deposito(double v);
        abstract public void Saque(double v);
        abstract public void ImprimirSaldo();
    }

    public class CorrenteComum : Conta {
        public CorrenteComum(int n, string no, double s) : base(n, no, s) {}

        override public void Deposito(double v) {
            SetSaldo(GetSaldo()+v);
        }

        override public void Saque(double v) {
            if (v>GetSaldo())
                System.Console.WriteLine("ERRO! SALDO INSUFICIENTE.");
            else 
                SetSaldo(GetSaldo()-v);
        }

        override public void ImprimirSaldo() {
            System.Console.WriteLine($"SALDO: {GetSaldo()}");
        }
    }

    public class CorrenteLimite : Conta {
        private double limite;

        public CorrenteLimite(int n, string no, double s, double l) : base(n, no, s) {
            SetLimite(l);
        }

        public double GetLimite() {
            return limite;
        }
        public void SetLimite(double l) {
            limite=l;
        }

        override public void Deposito(double v) {
            SetSaldo(GetSaldo()+v);
        }

        override public void Saque(double v) {
            if (v>(GetSaldo()+GetLimite()))
                System.Console.WriteLine("ERRO! SALDO INSUFICIENTE.");
            else 
                SetSaldo(GetSaldo()-v);
        }

        override public void ImprimirSaldo() {
            System.Console.WriteLine($"SALDO: {GetSaldo()}");
        }
    }

    public class Poupanca : Conta {
        private int diaAniversario;

        public Poupanca(int n, string no, double s, int d) : base(n, no, s) {
            SetDiaAniversario(d);
        }

        public int GetDiaAniversario() {
            return diaAniversario;
        }
        public void SetDiaAniversario(int d) {
            diaAniversario=d;
        }

        override public void Deposito(double v) {
            SetSaldo(GetSaldo()+v);
        }

        override public void Saque(double v) {
            if (v>GetSaldo())
                System.Console.WriteLine("ERRO! SALDO INSUFICIENTE.");
            else 
                SetSaldo(GetSaldo()-v);
        }

        override public void ImprimirSaldo() {
            System.Console.WriteLine($"SALDO: {GetSaldo()}");
        }
    }
}
