/*

Classe Emprego
Atributos:
- cargo
- salario
- bonus: percentual de bonificação a ser acrescentado ao salário do funcionário, de
acordo com a quantidade de dependentes. Por exemplo, se o bônus for de 2%, e o
funcionário tiver 3 dependentes, ele receberá 6% de acréscimo sobre o salário.
Métodos:
- não possui


Classe Pessoa
Atributos:
- nome
- fone
- email
- emprego: objeto do tipo Emprego
- dependentes: lista de objetos do tipo Pessoa
Métodos:
- calcular_salario: retorna o valor do salário do funcionário, de acordo com o
percentual de bonificação e quantidade de dependentes.


Você pode utilizar o programa a seguir para testar as suas classes:

emprego = Emprego("Programador", "TI", 1000, 5)
pessoa1 = Pessoa("Paulo", "11-99999999", "paulo@email.com", emprego)
// dois dependentes (o dependente também é um objeto Pessoa)
dep1 = Pessoa("Maria", "", "", None)
dep2 = Pessoa("Joao", "", "", None)
// adiciona dependentes na lista de dependentes da pessoa1
pessoa1.dependentes.append(dep1)
pessoa1.dependentes.append(dep2)
print("Salario: ", pessoa1.calcular_salario()) # imprime 1100.0

*/

using System;
using System.Collections.Generic;

namespace _4__Uma_pessoa_tem_um_emprego
{
    class Program
    {
        static void Main(string[] args)
        {
            Emprego emprego = new Emprego("Programador", "TI", 1000, 5);
            Pessoa pessoa1 = new Pessoa("Paulo", "11 99999-9999", "paulo@email.com", emprego);
            Pessoa dep1 = new Pessoa("Maria", "", "", null);
            Pessoa dep2 = new Pessoa("João", "", "", null);
            
            pessoa1.setDependentes(dep1);
            pessoa1.setDependentes(dep2);
            System.Console.WriteLine($"Salario: {pessoa1.calcularSalario()}");
        }
    }

    public interface IPessoa {
        double calcularSalario();
    }

    public class Pessoa : IPessoa {
        private string nome;
        private string fone;
        private string email;
        private Emprego emprego;
        private List<Pessoa> dependentes = new List<Pessoa>();

        public Pessoa(string n, string f, string ema, Emprego emp) {
            setNome(n);
            setFone(f);
            setEmail(ema);
            setEmprego(emp);
        }

        public string getNome() {
            return nome;
        }
        public string getFone() {
            return fone;
        }
        public string getEmail() {
            return email;
        }
        public Emprego getEmprego() {
            return emprego;
        }
        public List<Pessoa> getDependentes() {
            return dependentes;
        }

        private void setNome(string n) {
            nome=n;
        }
        private void setFone(string f) {
            fone=f;
        }
        private void setEmail(string e) {
            email=e;
        }
        private void setEmprego(Emprego e) {
            emprego=e;
        }
        public void setDependentes(Pessoa d) {
            dependentes.Add(d);
        }

        public double calcularSalario() {
            double totalSalario=0;
            totalSalario=dependentes.Count*emprego.getBonus();
            totalSalario=(totalSalario/100*emprego.getSalario())+emprego.getSalario();
            emprego.setSalario(totalSalario);
            return totalSalario;
        }
    }

    public class Emprego {
        private string cargo;
        private string area;
        private double salario;
        private int bonus;

        public Emprego(string c, string a, double sa, int b) {
            setCargo(c);
            setArea(a);
            setSalario(sa);
            setBonus(b);
        }

        public string getCargo() {
            return cargo;
        }
        public string getArea() {
            return area;
        }
        public double getSalario() {
            return salario;
        }
        public double getBonus() {
            return bonus;
        }

        private void setCargo(string c) {
            cargo=c;
        }
        private void setArea(string a) {
            area=a;;
        }
        public void setSalario(double s) {
            salario=s;
        }
        private void setBonus(int b) {
            bonus=b;
        }
    }
}