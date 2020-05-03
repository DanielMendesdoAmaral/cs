/*

Implemente as classes Produto e Pedido.

Classe Pedido:
Atributos:
- produtos: Lista de objetos do classe Produto
Métodos:
- adicionar_produto: recebe um objeto Produto e o adiciona na lista de produtos.
- calcular_valor: deve retornar o valor total do pedido (soma dos valores de todos os
produtos do pedido)


Classe Produto:
Atributos:
- nome: nome do produto
- preco: preço do produto
- quantidade: quantidade de itens do produto
Métodos:
- Não possui


Você pode utilizar o programa abaixo para testar as suas classes:

cafe = Produto('Café Solúvel', 5.50, 1)
arroz = Produto('Arroz Integral', 4.90, 2)
feijao = Produto('Feijão Preto', 2.80, 2)
meu_pedido = Pedido()
meu_pedido.adicionar_produto(cafe)
meu_pedido.adicionar_produto(arroz)
meu_pedido.adicionar_produto(feijao)
print('O valor total é: ', meu_pedido.calcular_valor()) // imprime 20.90

*/

using System;
using System.Collections.Generic;

namespace _2__Um_pedido_possui_uma_lista_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto c = new Produto("Café Solúvel", 5.50, 1);
            Produto a = new Produto("Arroz Integral", 4.90, 2);
            Produto f = new Produto("Feijão Preto", 2.80, 2);

            Pedido meuPedido = new Pedido();

            meuPedido.adicionarProduto(c);
            meuPedido.adicionarProduto(a);
            meuPedido.adicionarProduto(f);

            System.Console.WriteLine($"O valor total é: {meuPedido.calcularValor()}");
        }
    }

    public interface IPedido {
        void adicionarProduto(Produto p);
        double calcularValor();
    }

    public class Pedido : IPedido{
        private List<Produto> produtos = new List<Produto>();

        public List<Produto> getProdutos() {
            return produtos;
        }
        private void setProdutos(int i, Produto p) {
            produtos[i]=p;
        }

        public void adicionarProduto(Produto p) {
            produtos.Add(p);
        }
        public double calcularValor() {
            double valorTotal=0;
            for (int c=0; c<produtos.Count; c++) {
                valorTotal += produtos[c].getPreco() * produtos[c].getQuantidade();
            }
            return valorTotal;
        }
    }

    public class Produto {
        string nome; 
        double preco;
        int quantidade;

        public Produto(string n, double p, int q) {
            setNome(n);
            setPreco(p);
            setQuantidade(q);
        }

        public string getNome() {
            return nome;
        }
        public double getPreco() {
            return preco;
        }
        public int getQuantidade() {
            return quantidade;
        }

        public void setNome(string n) {
            nome=n;
        }
        public void setPreco(double p) {
            preco=p;
        }
        public void setQuantidade(int q) {
            quantidade=q;
        }
    }
}