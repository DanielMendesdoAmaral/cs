/*

Em sistemas complexos, você tem que escolher bem e montar classes para deixar seu programa seguro. Por exemplo, você não deixaria uma classe que guarda contas bancárias ser pública. Para isso servem as classes privadas. Você só pode instanciar objetos dentro dela, a menos que você utilize métodos getters (que pegam um valor, um atributo) e setters (que modificam atributos, valores). Na verdade, esses métodos devem ser usados para todos atributos, em todo tipo de visibilidade de classe. Assim, o código de sua classe ficará grande, mas será escrito apenas uma vez, e todo o seu código principal, na parte de instanciação de objetos, ficará mais clean e mais fácil de ser entendido. 

*/


using System;

namespace Aula_33___Private
{
    class Program
    {
        static void Main(string[] args)
        {
            Contas c1 = new Contas("Daniel", 1000);
            System.Console.WriteLine($"CONTA: {c1.GetNomeUsuario()}\nSALDO: {c1.GetSaldo()}\n"); //Escreve os valores iniciais passados
            c1.SetNomeUsuario("Juninho"); //Mudando o nome do objeto c1 com o setter
            c1.SetSaldo(2000); //Mudando o saldo do objeto c1 com o setter
            System.Console.WriteLine($"CONTA: {c1.GetNomeUsuario()}\nSALDO: {c1.GetSaldo()}"); //Escreve os novos valores passados
        }
    }

    public class Contas {
        private string nomeUsuario;
        private double saldo;

        //Método construtor
        public Contas(string n, double s) {
            nomeUsuario = n;
            saldo = s;
        }

        //Getter nome
        public string GetNomeUsuario() {
            return nomeUsuario;
        }

        //Setter nome
        public void SetNomeUsuario(string n) {
            nomeUsuario=n;
        }

        //Getter saldo
        public double GetSaldo() {
            return saldo;
        }

        //Setter saldo
        public void SetSaldo(double s) {
            saldo=s;
        }
    }
}
