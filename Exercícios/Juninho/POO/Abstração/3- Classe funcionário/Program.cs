/*

Implemente uma classe Funcionario.
Atributos:
- nome
- salario
Métodos:
- aumentar_salario: recebe como parâmetro de entrada um percentual e altera o salário do
funcionário, de acordo com o percentual recebido.
Crie um programa que utilize esta classe. Ele deve pedir ao usuário o nome e o salário do
funcionário e criar um objeto. Depois, deve solicitar ao usuário o percentual de aumento e executar
o método aumentar salário. Na sequência deve imprimir o salário do funcionário atualizado.

*/

using System;

namespace _3__Classe_funcionário
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            System.Console.Write("Informe o nome do funcionário: ");
            f1.nome = Console.ReadLine();
            System.Console.Write("Informe o salário atual do funcionário: ");
            f1.salario = Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("Informe a porcentagem de aumento do salário que será dado ao funcionário: ");
            decimal porcentagemAumento = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();
            
            f1.aumentar_salario(porcentagemAumento);
        }
    }

    public class Funcionario {
        public string nome;
        public decimal salario;
        public void aumentar_salario(decimal p) {
            System.Console.WriteLine($"O novo salário do funcionário é de {salario+=p/100*salario:c}");
        }
    }
}