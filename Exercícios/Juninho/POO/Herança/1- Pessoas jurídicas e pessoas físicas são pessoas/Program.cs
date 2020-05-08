/*

O diagrama abaixo fornece uma hierarquia de classes onde a classe Pessoa é a superclasse (classe mãe), e as classes PessoaFisica e PessoaJuridica são as subclasses (classes filhas).

Crie uma classe Pessoa com os atributos id e nome.
Crie uma classe PessoaJuridica que herda da classe Pessoa e acrescenta o atributo cnpj.
Crie uma classe PessoaFisica que herda da classe Pessoa e acrescenta os atributos rg e cpf.

Utilize o programa abaixo para testar as classes

print(pessoa1.id) # 1
print(pessoa1.nome) # Nome da Pessoa
print(p_juridica.id) # 2
print(p_juridica.nome) # Nome da Pessoa Juridica
print(p_juridica.cnpj) # 1111111111
print(p_fisica.id) # 3
print(p_fisica.nome) # Nome da Pessoa Fisica
print(p_fisica.rg) # 222222222
print(p_fisica.cpf) # 333333333 

*/

using System;

namespace _1__Pessoas_jurídicas_e_pessoas_físicas_são_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa(1, "Daniel");
            PessoaJuridica pessoa2 = new PessoaJuridica(2, "Juninho", "98.248.164/4956-17");
            PessoaFisica pessoa3 = new PessoaFisica(3, "Maria", "346.984.785-9", "136.156.489-08");

            System.Console.WriteLine($"{pessoa1.GetId()}\n{pessoa1.GetNome()}\n\n{pessoa2.GetId()}\n{pessoa2.GetNome()}\n{pessoa2.GetCnpj()}\n\n{pessoa3.GetId()}\n{pessoa3.GetNome()}\n{pessoa3.GetRg()}\n{pessoa3.GetCpf()}");
        }
    }

    public class Pessoa {
        private int id;
        private string nome;

        public Pessoa(int i, string n) {
            SetId(i);
            SetNome(n);
        }

        public int GetId() {
            return id;
        }
        public string GetNome() {
            return nome;
        }

        public void SetId(int i) {
            id=i;
        }
        public void SetNome(string n) {
            nome=n;
        }
    }

    public class PessoaJuridica : Pessoa {
        private string cnpj;

        public PessoaJuridica(int i, string n, string c) : base(i, n){
            SetCnpj(c);
        }

        public string GetCnpj() {
            return cnpj;
        }
        public void SetCnpj(string c) {
            cnpj=c;
        }
    }

    public class PessoaFisica : Pessoa {
        private string rg;
        private string cpf;

        public PessoaFisica(int i, string n, string r, string c) : base(i, n) {
            SetRg(r);
            SetCpf(c);
        }

        public string GetRg() {
            return rg;
        }
        public string GetCpf() {
            return cpf;
        }

        public void SetRg(string r) {
            rg=r;
        }
        public void SetCpf(string c) {
            cpf=c;
        }
    }
}
