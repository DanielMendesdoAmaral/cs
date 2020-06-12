using System;

namespace Aula_29___Construtores_e_destrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o nome do jogo 1: ");
            string nome = Console.ReadLine();
            System.Console.Write("Digite o gênero do jogo 1: ");
            string genero = Console.ReadLine();
            System.Console.Write("Digite a data de lançamento do jogo 1: ");
            int lancamento = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            
            Games j1 = new Games(nome, genero, lancamento);
        }
    }

    public class Games 
    {
        public string nome;
        public string genero;
        public int lancamento;
        
        //Um construtor é um método que inicializa os atributos. Pode se inicializar fora dele, mas não é o recomendado. Pode passar parâmetros a ele também, assim obriga o usuário digitar valores seguindo determinadas regras. O método construtor tem que ter o mesmo nome da classe, e não pode ter nenhum tipo de retorno.

        public Games(string n, string g, int l) {
            System.Console.WriteLine($"JOGO: {nome=n} \nGÊNERO: {genero=g} \nDATA DE LANÇAMENTO: {lancamento=l}");
        }

        //Um destrutor é aquele que é executado após a execução do programa. Tem que ter um ~ antes, e não precisa da visibilidade do método. Precisa ter o mesmo nome do método. Serve para limpar a memória após a execução, útil em sistemas robustos.

        ~ Games () {
            Console.WriteLine($"Jogo {nome} destruído.");
        }
    }
}