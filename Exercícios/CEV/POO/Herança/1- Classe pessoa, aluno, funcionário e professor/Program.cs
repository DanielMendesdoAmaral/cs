using System;

namespace _1__Classe_pessoa__aluno__funcionário_e_professor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("João", 55, "Masculino");
            Aluno a = new Aluno("Daniel", 16, "Masculino", 1382740, "Técnico em Desenvolvimento de Sistemas");
            Professor prof = new Professor("Guanabara", 45, "Masculino", "Desenvolvimento", 4000);
            Funcionario f = new Funcionario("Juliana", 30, "Feminino", "Direção", false);
        }
    }

    public interface IPessoa {
        void FazerAniversario();
    }

    public class Pessoa : IPessoa {
        private string nome;
        private int idade;
        private string sexo;

        public Pessoa(string n, int i, string s) {
            SetNome(n);
            SetIdade(i);
            SetSexo(s);
        }

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

    public interface IAluno {
        void CancelarMatricula();
    }

    public class Aluno : Pessoa, IAluno{ 
        private int matricula;
        private string curso;

        public Aluno(string n, int i, string sexo,     int m, string c) : base(n, i, sexo) {
            SetMatricula(m);
            SetCurso(c);
        }

        public int GetMatricula() {
            return matricula;
        }
        public string GetCurso() {
            return curso;
        }

        public void SetMatricula(int m) {
            matricula=m;
        }
        public void SetCurso(string c) {
            curso=c;
        }

        public void CancelarMatricula() {
            matricula=0;
            curso="";
        }
    }

    public interface IProfessor {
        void ReceberAumento(double a);
    }

    public class Professor : Pessoa, IProfessor{
        private string especialidade;
        private double salario;

        public Professor(string n, int i, string sexo,     string e, double s) : base(n, i, sexo) {
            SetEspecialidade(e);
            SetSalario(s);
        }

        public string GetEspecialidade() {
            return especialidade;
        }
        public double GetSalario() {
            return salario;
        }

        public void SetEspecialidade(string e) {
            especialidade=e;
        }
        public void SetSalario(double s) {
            salario=s;
        }

        public void ReceberAumento(double a) {
            salario+=a;
        }
    }

    public interface IFuncionario {
        void MudarTrabalho(string t);
    }

    public class Funcionario : Pessoa, IFuncionario{
        private string setor;
        private bool trabalhando;

        public Funcionario(string n, int i, string sexo,     string s, bool t) : base(n, i, sexo) {
            SetSetor(s);
            SetTrabalhando(t);
        }

        public string GetSetor() {
            return setor;
        }
        public bool GetTrabalhando() {
            return trabalhando;
        }

        public void SetSetor(string s) {
            setor=s;
        }
        public void SetTrabalhando(bool t) {
            trabalhando=t;
        }

        public void MudarTrabalho(string t) {
            setor=t;
        }
    }
}