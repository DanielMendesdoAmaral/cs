/*

Crie uma classe Produto que possua os atributos nome, preco e descricao. Crie um método exibir_descricao que exibe a descrição do produto.
Crie duas classes filhas de Produto, a classe Mouse com o atributo tipo e a classe Livro com o atributo autor. Crie o método exibir_descricao nas classes filhas, que deve exibir a descrição do produto e o atributo adicional que a classe tiver (“autor” no caso de livro e “tipo” no caso de mouse).
No programa principal você deve simular a compra de vários mouses e livros, e inserir todos eles em uma lista chamada carrinho. Chame o método exibir_descricao para cada objeto do carrinho.

*/

using System;
using System.Collections.Generic;

namespace _2__Várias_formas_de_descrever
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> carrinho = new List<Produto>();

            Mouse m1 = new Mouse("Razer 015H-9.", 299.99, "Agilidade e conforto.", "Com fio.");
            Mouse m2 = new Mouse("Logitech Lion.", 99.99, "Praticidade.", "Sem fio.");

            Livro l1 = new Livro("Um estudo em vermelho.", 89.99, "Romance/Enigmas.", "Arthur Conan Doyle.");
            Livro l2 = new Livro("O homem que calculava.", 49.99, "Enigmas/Aventura.", "Malba Tahan.");

            carrinho.Add(m1);
            carrinho.Add(m2);
            carrinho.Add(l1);
            carrinho.Add(l2);

            Console.Clear();

            carrinho[0].ExibirDescricao();
            carrinho[1].ExibirDescricao();
            carrinho[2].ExibirDescricao();
            carrinho[3].ExibirDescricao();
        }
    }

    public interface IProduto {
        void ExibirDescricao();
    }

    public class Produto : IProduto {
        private string nome;
        private double preco;
        private string descricao;

        public Produto(string n, double p, string d) {
            SetNome(n);
            SetPreco(p);
            SetDescricao(d);
        }

        public string GetNome() {
            return nome;
        }
        public void SetNome(string n) {
            nome=n;
        }
        public double GetPreco() {
            return preco;
        }
        public void SetPreco(double p) {
            preco=p;
        }
        public string GetDescricao() {
            return descricao;
        }
        public void SetDescricao(string d) {
            descricao=d;
        }

        virtual public void ExibirDescricao() {
            System.Console.WriteLine($"NOME: {GetNome()}\nPREÇO: {GetPreco()}\nDESCRIÇÃO: {GetDescricao()}");
        }
    }

    public class Mouse : Produto {
        private string tipo;

        public Mouse(string n, double p, string d, string t) : base(n, p, d) {
            SetTipo(t);
        }

        public string GetTipo() {
            return tipo;
        }
        public void SetTipo(string t) {
            tipo=t;
        }

        override public void ExibirDescricao() {
            base.ExibirDescricao(); //Pega o primeiro método, e junta com esse. Assim, você não precisa escrever tudo de novo. É como o super do Python e do Java.
            System.Console.WriteLine($"TIPO: {GetTipo()}\n");
        }
    }

    public class Livro : Produto {
        private string autor;

        public Livro(string n, double p, string d, string a) : base(n, p, d) {
            SetAutor(a);
        }

        public string GetAutor() {
            return autor;
        }
        public void SetAutor(string a) {
            autor=a;
        }

        override public void ExibirDescricao() {
            base.ExibirDescricao();
            System.Console.WriteLine($"AUTOR: {GetAutor()}\n");
        }
    }
}
