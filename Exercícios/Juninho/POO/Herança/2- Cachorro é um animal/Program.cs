/*

Crie a classe Animal com os atributos nome, cor e numero_patas. Crie também o método exibir_dados, que imprime na tela uma espécie de relatório informando os dados do animal.
Crie uma classe Cachorro que herde da classe Animal e que possui como atributo adicional a raça do cachorro. Crie também o método exibir_dados, que imprime na tela os dados do cachorro (nome, cor, numero de patas e raça).

*/

using System;

namespace _2__Cachorro_é_um_animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Sheik", "Branco", 4);
            Cachorro cachorro = new Cachorro("Pitoco", "Branco/Preto", 4, "Vira-Lata");

            animal.ExibirDados();
            cachorro.ExibirDados(); //Note que sobrescrevemos o método herdado. Para ficar tudo dentro dos conformes, use o virtual e o override. 
        }
    }

    public interface IAnimal {
        void ExibirDados();
    }

    public class Animal : IAnimal {
        private string nome;
        private string cor;
        private int numeroPatas;

        public Animal(string n, string c, int nP) {
            SetNome(n);
            SetCor(c);
            SetNumeroPatas(nP);
        }

        public string GetNome() {
            return nome;
        }
        public string GetCor() {
            return cor;
        }
        public int GetNumeroPatas() {
            return numeroPatas;
        }

        public void SetNome(string n) {
            nome=n;
        }
        public void SetCor(string c) {
            cor=c;
        }
        public void SetNumeroPatas(int nP) {
            numeroPatas=nP;
        }

        virtual public void ExibirDados() {
            System.Console.WriteLine($"NOME: {GetNome()}\nCOR: {GetCor()}\nNÚMERO DE PATAS: {GetNumeroPatas()}\n");
        }
    }

    public interface ICachorro {
        void ExibirDados();
    }

    public class Cachorro : Animal, ICachorro {
        private string raca;

        public Cachorro(string n, string c, int nP, string r) : base(n, c, nP) {
            SetRaca(r);
        }

        public string GetRaca() {
            return raca;
        }
        public void SetRaca(string r) {
            raca=r;
        }

        override sealed public void ExibirDados() {
            System.Console.Write($"NOME: {GetNome()}\nCOR: {GetCor()}\nNÚMERO DE PATAS: {GetNumeroPatas()}\nRAÇA: {GetRaca()}");
        }
    }
}