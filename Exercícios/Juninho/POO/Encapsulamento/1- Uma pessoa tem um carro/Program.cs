/*

Implemente as classes Pessoa e Carro.

Classe Pessoa:
Atributos:
- nome: nome da pessoa (valor inicial definido no construtor)
- idade: idade da pessoa (valor inicial definido no construtor)
- carro: objeto da classe Carro (valor inicial None)
Métodos:
- comprar_carro: recebe um objeto Carro e associa esse objeto ao atributo carro.


Classe Carro:
Atributos:
- marca: marca do carro (valor inicial definido no construtor)
- modelo: modelo do carro (valor inicial definido no construtor)
- placa: placa do carro (valor inicial definido no construtor)
- ano: ano de fabricação do carro (valor inicial definido no construtor)
Métodos:
- Não possui


Você pode utilizar o trecho de programa abaixo para testar as suas classes:

meucarro = Carro('Volkswagen', 'Gol', 'AAA-1111', 2015)
eu = Pessoa('João', 25)
eu.comprar_carro(meucarro)
print('Meu nome: ', eu.nome) // imprime João
print('Modelo do meu carro: ', eu.carro.modelo) // imprime Gol
print('Placa do meu carro: ', eu.carro.placa) // imprime AAA-1111

*/

using System;

namespace _1__Uma_pessoa_tem_um_carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa eu = new Pessoa("João", 25);
            Carro meuCarro = new Carro("Volkswagen", "Gol", "AAA-1111", 2015);
            eu.comprarCarro(meuCarro);
            System.Console.WriteLine($"Meu nome: {eu.getNome()}\nModelo do meu carro: {meuCarro.getModelo()}\nPlaca do meu carro: {meuCarro.getPlaca()}");
        }
    }

    public interface IPessoa {
        void comprarCarro(Carro carro);
    }

    public class Pessoa : IPessoa {
        private string nome;
        private int idade;
        private Carro carro;

        public Pessoa(string n, int i) {
            setNome(n);
            setIdade(i);
        }

        public string getNome() {
            return nome;
        }
        public int getIdade() {
            return idade;
        }
        public Carro GetCarro() {
            return carro;
        }

        private void setNome(string n) {
            nome=n;
        }
        private void setIdade(int i) {
            idade=i;
        }
        private void setCarro(Carro c) {
            carro=c;
        }

        public void comprarCarro(Carro c) {
            setCarro(c);
        }
    }

    public class Carro {
        string marca;
        string modelo;
        string placa;
        int ano;

        public Carro(string mar, string mod, string p, int a) {
            setMarca(mar);
            setModelo(mod);
            setPlaca(p);
            setAno(a);
        }

        public string getMarca() {
            return marca;
        }
        public string getModelo() {
            return modelo;
        }
        public string getPlaca() {
            return placa;
        }
        public int getAno() {
            return ano;
        }

        private void setMarca(string m) {
            marca=m;
        }
        private void setModelo(string m) {
            modelo=m;
        }
        private void setPlaca(string p) {
            placa=p;
        }
        private void setAno(int a) {
            ano=a;
        }
    }
}