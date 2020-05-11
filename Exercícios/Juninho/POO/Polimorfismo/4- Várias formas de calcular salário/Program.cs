/*

Crie uma hierarquia de classes para representar os diferentes tipos de funcionários de um escritório que tem os seguintes cargos: gerente, assistente e vendedor.
Escreva uma classe base abstrata chamada Funcionario que declara um método abstrato
calcular_salario()
Essa classe também deve definir os seguintes atributos: nome, matricula e salario_base.
Essa classe abstrata deverá ser herdada pelas outras classes que são: Gerente, Assistente e
Vendedor.
Em cada classe filha deve-se sobrescrever o método calcular_salario(). Este método deve calcular
e retornar o salário de cada funcionário, da seguinte forma:
- O gerente recebe duas vezes o salário_base.
- O assistente recebe o salário_base.
- O vendedor recebe o salário_base mais uma comissão de 10%.
Implemente um programa principal que cria um objeto de cada tipo (gerente, assistente e vendedor)
e os armazena em uma lista
Percorra essa lista e imprima o salário de cada funcionário

*/

using System;
using System.Collections.Generic;

namespace _4__Várias_formas_de_calcular_salário
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Gerente g = new Gerente("Douglas", 0, 3000);
            Assistente a = new Assistente("Patrícia", 1, 1500);
            Vendedor v = new Vendedor("Luís", 2, 2000);

            funcionarios.Add(g);
            funcionarios.Add(a);
            funcionarios.Add(v);

            funcionarios[0].CalcularSalario();
            funcionarios[01].CalcularSalario();
            funcionarios[2].CalcularSalario();
        }
    }

    abstract public class Funcionario {
        private string nome;
        private int matricula;
        private double salarioBase;

        public Funcionario(string n, int m, double s) {
            SetNome(n);
            SetMatricula(m);
            SetSalarioBase(s);
        }

        public string GetNome() {
            return nome;
        }
        public void SetNome(string n) {
            nome=n;
        }
        public int GetMatricula() {
            return matricula;
        }
        public void SetMatricula(int m) {
            matricula=m;
        }
        public double GetSalarioBase() {
            return salarioBase;
        }
        public void SetSalarioBase(double s) {
            salarioBase=s;
        }

        abstract public void CalcularSalario();
    }

    public class Gerente : Funcionario {
        public Gerente(string n, int m, double s) : base(n, m, s) {}

        override public void CalcularSalario() {
            SetSalarioBase(GetSalarioBase()*2);
            System.Console.WriteLine($"SALÁRIO DE {GetNome()}: {GetSalarioBase()}");
        }
    }

    public class Assistente : Funcionario {
        public Assistente(string n, int m, double s) : base(n, m, s) {}

        override public void CalcularSalario() {
            System.Console.WriteLine($"SALÁRIO DE {GetNome()}: {GetSalarioBase()}");
        }
    }

    public class Vendedor : Funcionario {
        public Vendedor(string n, int m, double s) : base(n, m, s) {}

        override public void CalcularSalario() {
            SetSalarioBase(GetSalarioBase()+(0.1*GetSalarioBase()));
            System.Console.WriteLine($"SALÁRIO DE {GetNome()}: {GetSalarioBase()}");
        }
    }
}