//1- Uma sobrecarga de construtores acontece quando você coloca vários construtores com parâmetros diferentes, deixando seu programa mais inteligente. Por exemplo: A função de um construtor é obrigar o usuário a instanciar o objeto com os atributos seguindo regras. Por exemplo, você não aceitaria em seu sistema que cadastra funcionários um funcionário sem nome. Então, o construtor serve para obrigar o usuário a digitar um nome. Mas não seria totalmente necessário o usuário informar a religião do funcionário, a menos que ele quisesse. Assim, você precisaria de dois construtores, que daria ao usuário 2 opções: Um que obriga o usuário colocar o nome do funcionário, mas que não seja necessário colocar a religião dele, e outro que também obriga o usuário a entrar com o nome, e dessa vez, aceita a religião do funcionário também. Assim, se você colocar somente o nome, o programa iria obedecer o construtor 1, se vc colocar o nome e a religião, ele ignoraria o construtor 1 e iria para o construtor 2.

//2- O mesmo acontece com os métodos. Você pode criar opções de acordo com o número de parâmetros. Isso é uma sobrecarga de métodos.

using System;

namespace Aula_30___Sobrecarga_de_construtores_e_de_métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Juninho");
            Pessoa p2 = new Pessoa("Daniel", "M");
            Pessoa p3 = new Pessoa("Juninho", "M", 28);

            p1.Info(p1.nome, p1.sexo);
            p2.Info(p2.nome, p2.sexo);
            p3.Info(p3.nome, p3.sexo, p3.idade);
        }
    }

    public class Pessoa {
        public string nome;
        public string sexo;
        public int idade;

        //Construtor 1, ou, opção 1 - Nome da pessoa (Sempre obrigatório).
        public Pessoa(string n) {
            nome=n;
            sexo="Indefinido";
            idade=18;
        }

        //Construtor 2 - Nome e sexo. 
        public Pessoa(string n, string s) {
            nome=n;
            sexo=s;
            idade=18;
        }

        //Construtor 3 - Todas as opções. 
        public Pessoa (string n, string s, int i) {
            nome=n;
            sexo=s;
            idade=i;
        }

        //O método info apresenta as informações digitadas. Método 1 - Se o usuário não inserir a idade, ele escreve uma mensagem diferente. 
        public void Info (string n, string s) {
            System.Console.WriteLine($"NOME: {nome}\nSEXO: {sexo}\nIDADE: Idade maior ou igual à 18 anos.\n");
        }

        //Método 2 - Se o usuário inserir a idade, ele escreve uma mensagem diferente. 
        public void Info (string n, string s, int i) {
            System.Console.WriteLine($"NOME: {nome}\nSEXO: {sexo}\nIDADE: {idade}\n");
        }
    }
}
