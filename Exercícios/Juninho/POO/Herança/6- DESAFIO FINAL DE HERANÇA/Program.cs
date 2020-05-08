/*

Uma universidade necessita de um sistema que facilite a sua gestão acadêmica. Implemente as classes de modo que obedeçam os relacionamentos apresentados no diagrama abaixo:

Sabe-se que um professor é um funcionário. Além de professores, há funcionários que são técnicos administrativos.
Para cada funcionário, independente de ser professor ou técnico, é necessário saber seu nome, endereço, telefone, cpf e salário.
Especificamente para professores, é necessário saber sua titulação e as disciplinas que ele leciona.
Especificamente para técnicos administrativos, é necessário saber seu cargo.
Para cada aluno é necessário saber seu nome, endereco, telefone, cpf e as disciplinas que ele cursa.
Para cada disciplina é necessário registrar seu nome.

*/

using System;
using System.Collections.Generic;

namespace _6__DESAFIO_FINAL_DE_HERANÇA
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Pessoa {
        private string nome;
        private string endereco;
        private string fone;
        private string cpf;

        public Pessoa(string n, string e, string f, string c) {
            SetNome(n);
            SetEndereco(e);
            SetFone(f);
            SetCpf(c);
        }

        public string GetNome() {
            return nome;
        }
        public void SetNome(string n) {
            nome=n;
        }
        public string GetEndereco() {
            return endereco;
        }
        public void SetEndereco(string e) {
            endereco=e;
        }
        public string GetFone() {
            return fone;
        }
        public void SetFone(string f) {
            fone=f;
        }
        public string GetCpf() {
            return cpf;
        }
        public void SetCpf(string c) {
            cpf=c;
        }
    }

    public interface IAluno {
        void IncluirDisciplina(Disciplina d);
    }

    public class Aluno : Pessoa, IAluno {
        private List<Disciplina> disciplina;

        public Aluno(string n, string e, string f, string c) : base(n, e, f, c) {

        }

        public List<Disciplina> GetDisciplina() {
            return disciplina;
        }
        public void SetDisciplina(Disciplina d) {
            disciplina.Add(d);
        }

        public void IncluirDisciplina(Disciplina d) {
            disciplina.Add(d);
        }
    }

    public class Funcionario : Pessoa {
        private double salario;

        public Funcionario(string n, string e, string f, string c, double s) : base(n, e, f, c) {
            SetSalario(s);
        }

        public double GetSalario() {
            return salario;
        }
        public void SetSalario(double s) {
            salario=s;
        }
    }

    public class Disciplina {
        private string nome;
        private double cargaHoraria;

        public Disciplina(string n, double c) {
            SetNome(n);
            SetCargaHoraria(c);
        }

        public string GetNome() {
            return nome;
        }
        public void SetNome(string n) {
            nome=n;
        }
        public double GetCargaHoraria() {
            return cargaHoraria;
        }
        public void SetCargaHoraria(double c) {
            cargaHoraria=c;
        }
    }

    public interface IProfessor {
        void IncluirDisciplina(Disciplina d);
    }

    public class Professor : Funcionario, IProfessor {
        private string titulacao;
        private List<Disciplina> disciplina;

        public Professor (string n, string e, string f, string c, double s, string t) : base(n, e, f, c, s) {
            SetTitulacao(t);
        }

        public string GetTitulacao() {
            return titulacao;
        }
        public void SetTitulacao(string t) {
            titulacao=t;
        }

        public void IncluirDisciplina(Disciplina d) {
            disciplina.Add(d);
        }
    }

    public class Tecnico : Funcionario {
        private string cargo;

        public Tecnico(string n, string e, string f, string c, double s, string car) : base(n, e, f, c, s) {
            SetCargo(car);
        }

        public string GetCargo() {
            return cargo;
        }
        public void SetCargo(string c) {
            cargo=c;
        }
    }
}