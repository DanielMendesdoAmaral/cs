/*

Implemente uma classe Aluno.
Atributos:
- nome
- tempo_sem_dormir (em horas. O valor inicial deve ser zero).
Métodos:
- estudar: recebe como parâmetro de entrada a quantidade de horas de estudo e
acrescenta ao atributo tempo_sem_dormir
- dormir: recebe como parâmetro de entrada a quantidade de horas de sono e reduz do
atributo tempo_sem_dormir
Faça um programa para criar objeto da classe Aluno e utilize os métodos estudar e dormir. Ao final
exiba quanto tempo o aluno está sem dormir. Veja abaixo um trecho de programa que utiliza a
classe:
aluno1 = Aluno()
aluno1.nome = "Luizinho"
aluno1.estudar(3)
aluno1.dormir(2)
aluno1.estudar(4)
aluno1.dormir(2)
print('O aluno', aluno1.nome, 'está a', aluno1.tempo_sem_dormir, 'horas sem
dormir')
// deve imprimir: "O aluno Luizinho está a 3 horas sem dormir"

*/

using System;

namespace _4__Classe_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            aluno1.nome = "Luizinho";
            aluno1.estudar(3);
            aluno1.dormir(2);
            aluno1.estudar(4);
            aluno1.dormir(2);  

            System.Console.WriteLine($"O aluno {aluno1.nome} está a {aluno1.tempoSemDormir} horas sem dormir.");
            
        }
    }

    public class Aluno
    {
        public string nome;
        public int tempoSemDormir=0;
        public void estudar(int h) {
            tempoSemDormir+=h;
        }

        public void dormir(int h) {
            tempoSemDormir-=h;
        }
    }
}
