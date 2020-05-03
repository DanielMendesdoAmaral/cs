/*

Teste de mesa:

exame01.imprimir_exame()
// Deve exibir relatório com os dados do exame (inclusive os do médico e do paciente)

*/

using System;

namespace _5__Um_exame__um_paciente_e_um_médico
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente("Maria", "111111111-11", 60);
            Medico medico = new Medico("Rita", "888888888-88", "Oncologista");
            Exame exame = new Exame(medico, paciente, "Ótimo", "Curada");
            exame.imprimirExame();
        }
    }

    public interface IExame {
        void imprimirExame();
    }

    public class Exame : IExame{
        private Medico medico;
        private Paciente paciente;
        private string descricao;
        private string resultado;

        public Exame(Medico m, Paciente p, string d, string r) {
            setMedico(m);
            setPaciente(p);
            setDescricao(d);
            setResultado(r);
        }

        public Medico getMedico() {
            return medico;
        }
        public Paciente getPaciente() {
            return paciente;
        }
        public string getDescricao() {
            return descricao;
        }
        public string getResultado() {
            return resultado;
        }

        public void setMedico(Medico m) {
            medico=m;
        }
        public void setPaciente(Paciente p) {
            paciente=p;
        }
        public void setDescricao(string d) {
            descricao=d;
        }
        public void setResultado(string r) {
            resultado=r;
        }

        public void imprimirExame() {
            System.Console.WriteLine($"DADOS DO PACIENTE\nNome: {paciente.getNome()}\nCPF: {paciente.getCpf()}\nIdade: {paciente.getIdade()}\n\nDADOS DO MÉDICO\nNome: {medico.getNome()}\nCRM: {medico.getCrm()}\nEspecialização: {medico.getEspecializacao()}\n\nRESULTADOS\nMédico: {medico.getNome()}\nPaciente: {paciente.getNome()}\nDescrição: {getDescricao()}\nResultado: {getResultado()}");
        }
    }

    public class Paciente {
        private string nome;
        private string cpf;
        private int idade;
 
        public Paciente(string n, string c, int i) {
            setNome(n);
            setCpf(c);
            setIdade(i);
        }

        public string getNome() {
            return nome;
        }
        public string getCpf() {
            return cpf;
        }
        public int getIdade() {
            return idade;
        }

        public void setNome(string n) {
            nome=n;
        }
        public void setCpf(string c) {
            cpf=c;
        }
        public void setIdade(int i) {
            idade=i;
        }
    }

    public class Medico {
        private string nome;
        private string crm;
        private string especializacao;

        public Medico(string n, string c, string e) {
            setNome(n);
            setCrm(c);
            setEspecializacao(e);
        }

        public string getNome() {
            return nome;
        }
        public string getCrm() {
            return crm;
        }
        public string getEspecializacao() {
            return especializacao;
        }

        public void setNome(string n) {
            nome=n;
        }
        public void setCrm(string c) {
            crm=c;
        }
        public void setEspecializacao(string e) {
            especializacao=e;
        }
    }
}