using System;

namespace _1__Classe_pessoa__aluno__funcionário_e_professor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IPessoa {
        void FazerAniversario();
    }

    public class Pessoa : IPessoa {
        private string nome;
        private int idade;
        private string sexo;

        public string GetNome() {
            return nome;
        }
        public int GetIdade() {
            return idade;
        }
        public string GetSexo() {
            return sexo;
        }

        public void SetNome(string n) {
            nome=n;
        }
        public void SetIdade(int i) {
            idade=i;
        }
        public void SetSexo(string s) {
            sexo=s;
        }

        public void FazerAniversario() {
            idade++;
        }
    }


    public class Aluno : Pessoa { 
        
    }

}