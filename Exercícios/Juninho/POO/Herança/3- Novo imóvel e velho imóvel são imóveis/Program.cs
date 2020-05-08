/*

Crie a classe Imovel, que possui um endereço e um preço.
Crie uma classe Novo, que herda de Imovel e possui um adicional no preço.
Crie uma classe Velho, que herda de Imovel e possui um desconto no preço.

Utilize o programa abaixo para testar as classes
imovel = Imovel("Rua Silva, 123", 300000.0)
imovel_novo = Novo("Rua Joaquim, 999", 250000.0, 20000)
imovel_velho = Velho("Rua Consolação, 777", 500000, 35000)
print(imovel.endereco) # Rua Silva, 123
print(imovel.preco) # 300000.0
print(imovel_novo.endereco) # Rua Joaquim, 999
print(imovel_novo.preco) # 270000.0
print(imovel_velho.endereco) # Rua Consolação, 777
print(imovel_velho.preco) # 465000 

*/

using System;

namespace _3__Novo_imóvel_e_velho_imóvel_são_imóveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Imovel imovel = new Imovel("Rua Silva, 123", 300000.0);
            Novo imovelNovo = new Novo("Rua Joaquim, 999", 250000.0, 20000);
            Velho imovelVelho = new Velho("Rua Consolação, 777", 500000, 35000);

            System.Console.Write($"{imovel.GetEndereco()}\n{imovel.GetPreco()}\n\n{imovelNovo.GetEndereco()}\n{imovelNovo.GetPreco()}\n\n{imovelVelho.GetEndereco()}\n{imovelVelho.GetPreco()}");
        }
    }

    public class Imovel {
        private string endereco;
        private double preco;

        public Imovel(string e, double p) {
            SetEndereco(e);
            SetPreco(p);
        }

        public string GetEndereco() {
            return endereco;
        }
        public double GetPreco() {
            return preco;
        }

        public void SetEndereco(string e) {
            endereco=e;
        }
        public void SetPreco(double p) {
            preco=p;
        }
    }

    public class Novo : Imovel {
        private double adicional;

        public Novo(string e, double p, double a) : base(e, p) {
            SetAdicional(a);
        }

        public double GetAdicional() {
            return adicional;
        }
        public void SetAdicional(double a) {
            adicional = a;
            SetPreco(GetPreco()+adicional);
        }
    }

    public class Velho : Imovel {
        private double desconto;

        public Velho(string e, double p, double d) : base(e, p) {
            SetDesconto(d);
        }

        public double GetDesconto() {
            return desconto;
        }
        public void SetDesconto(double d) {
            desconto=d;
            SetPreco(GetPreco()-desconto);
        }
    }
}