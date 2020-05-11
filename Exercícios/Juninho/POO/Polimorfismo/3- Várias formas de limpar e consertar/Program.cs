/*

Crie uma estrutura hierárquica que contenha as seguintes classes:
- Veiculo (classe abstrata)
- Bicicleta
- Automovel
Os métodos da classe Veiculo são todos e abstratos e devem ser implementados nas classes
filhas:
- limpar - imprime a mensagem “Bicicleta/Automóvel foi limpo”
- consertar - imprime a mensagem “Bicicleta/Automóvel foi consertado”
Acrescentar na classe Automovel o método:
- trocar_oleo - imprime a mensagem “O óleo foi trocado”
Ao consertar o carro, deve ser exibida também a mensagem de que o óleo foi trocado.

OBS.: As classes não possuem atributos.

Exemplo de programa principal
bike = Bicicleta()
carro = Automovel()
bike.limpar()
bike.consertar()
carro.limpar()
carro.consertar()
carro.trocar_oleo() 

*/

using System;

namespace _3__Várias_formas_de_limpar_e_consertar
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicicleta bike = new Bicicleta();
            Automovel carro = new Automovel();
            bike.Limpar();
            bike.Consertar();
            carro.Limpar();
            carro.Consertar();
            carro.TrocarOleo();
        }
    }

    abstract public class Veiculo {
        abstract public void Limpar();
        abstract public void Consertar();
    }

    public class Bicicleta : Veiculo {
        override public void Limpar() {
            System.Console.WriteLine("Bicicleta limpa!");
        }

        override public void Consertar() {
            System.Console.WriteLine("Bicicleta consertada!");
        }
    }

    public class Automovel : Veiculo {
        override public void Limpar() {
            System.Console.WriteLine("Automóvel limpo!");
        }

        override public void Consertar() {
            System.Console.WriteLine("Automóvel consertado, óleo trocado!");
        }

        public void TrocarOleo() {
            System.Console.WriteLine("Óleo trocado!");
        }
    }
}
