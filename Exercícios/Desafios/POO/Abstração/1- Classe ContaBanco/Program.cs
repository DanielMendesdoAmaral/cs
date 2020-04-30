/*

Duas pessoas querem abrir uma conta no banco, o Jubileu e a Creusa. O Jubileu optou por abrir uma conta poupança, e irá depositar 300 reais na sua conta. A Creusa, possui mais dinheiro e quer depositar 500 reais em uma conta corrente. Para isso, eles precisam abrir uma conta no banco. Os atributos e métodos da ContaBanco estão expostos abaixo, com base nesse diagrama de classes.

Requisitos: 

(//+ numConta
 //# tipo
 //- dono
 //- saldo
 //- status
 //+ abrirConta()
 //+ fecharConta()
 //+ depositar()
 //+ sacar()
 //+ pagarMensalidade()
 //todos os métodos especiais (getter e setter) devem ser públicos 
)

//1. O tipo da conta só aceita dois caracteres, cc e cp. Conta corrente e conta poupança, respectivamente.
//2. Na hora de abrir conta, eu mudo o status de falso para verdadeiro. É nesse momento que decido qual conta vou abrir, e caso seja uma cp já recebe um presente de 150 reais, ou caso escolha abrir uma conta corrente, seu presente é de 50 reais.
//3. Para fechar conta, o Jubileu ou a Creusa não vão poder ter dinheiro dentro da sua conta, nem podem estar devendo.
//4. Para fazer um depósito ou sacar, a conta já deve ter sido aberta com status verdadeiro. No caso do saque, eu devo já ter dinheiro dentro, e o valor do saque não deve ser superior ao seu saldo.
//5. A mensalidade vai ser cobrada diretamente do saldo. Na hora que for chamado a mensalidade, o cliente com cc pagará 12 reais, e o cliente com cp pagará 20 reais de mensalidade.
//6. Você precisará usar o método getter e setter para TODOS os atributos.
//7.  É necessário ter um método construtor, onde o seu status será definido como falso e o saldo definido como zero, pois a conta está fechada.

*/

using System;

namespace _1__Classe_ContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco J = new ContaBanco();
            J.AbrirConta("CC", "Jubileu");
            J.Depositar(100);
            J.Sacar(50);
            J.PagarMensalidade();
            System.Console.WriteLine($"DONO: {J.GetDono()} \nNÚM. DA CONTA: {J.GetNumConta()} \nTIPO DA CONTA: {J.GetTipo()} \nSALDO: {J.GetSaldo()} \nSTATUS: {J.GetStatus()}");

            System.Console.WriteLine();

            ContaBanco C = new ContaBanco();
            C.AbrirConta("CP", "Creuza");
            C.Sacar(130);
            C.PagarMensalidade();
            C.Depositar(15);
            System.Console.WriteLine($"DONO: {C.GetDono()} \nNÚM. DA CONTA: {C.GetNumConta()} \nTIPO DA CONTA: {C.GetTipo()} \nSALDO: {C.GetSaldo()} \nSTATUS: {C.GetStatus()}");
        }
    }

    public class ContaBanco {
        public int numConta;
        protected string tipo;
        private string dono;
        private double saldo;
        private bool status;

        public ContaBanco() {
            saldo=0;
            status=false;
        }

        public void SetNumConta(int nC) {
            numConta=nC;
        }

        public int GetNumConta() {
            return numConta;
        }

        public void SetTipo(string t) {
            tipo=t;
        }

        public string GetTipo() {
            return tipo;
        }

        public void SetDono(string d) {
            dono=d;
        }

        public string GetDono() {
            return dono;
        }

        public void SetSaldo(double sal) {
            saldo=sal;
        }

        public double GetSaldo() {
            return saldo;
        }

        public void SetStatus(bool st) {
            status=st;
        }

        public bool GetStatus() {
            return status;
        }

        public void AbrirConta(string t, string d) {
            t=t.ToUpper();
            if ((t!="CC") && (t!="CP")) {
                System.Console.WriteLine("ERRO! TIPO DE CONTA INEXISTENTE.");
            }
            else {
                tipo=t;
            }

            if (tipo=="CC") {
                saldo=50;
            }
            else if (tipo=="CP") {
                saldo=150;
            }

            dono=d;

            status=true;
        }

        public void FecharConta() {
            if (saldo==0) {
                status=false;
            }
            else if (saldo>0) {
                System.Console.WriteLine("ERRO! PARA FECHAR UMA CONTA, NÃO DEVE HAVER NELA NENHUM TIPO DE SALDO.");
            }
            else if (saldo<0) {
                System.Console.WriteLine("ERRO! PARA FECHAR UMA CONTA, NÃO PODE ESTAR NA SITUAÇÃO DE DEVEDOR.");
            }
        }

        public void Depositar(double s) {
            if (status==false) {
                System.Console.WriteLine("ERRO! CONTA INEXISTENTE.");
            }
            else {
                saldo+=s;
            }
        }

        public void Sacar(double s) {
            if (status==false) {
                System.Console.WriteLine("ERRO! CONTA INEXISTENTE.");
            }
            else if (s>saldo) {
                System.Console.WriteLine("ERRO! VALOR INDISPONÍVEL PARA SAQUE.");
            }
            else if (s<saldo) {
                saldo-=s;
            }
        }

        public void PagarMensalidade() {
            if (tipo=="CC") {
                saldo-=12;
            }
            else {
                saldo-=20;
            }
        }
    }
}