using System;

namespace _2__Relacionamento_entre_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIANDO OS LUTADORES
            Lutador L1 = new Lutador("Pretty Boy", "França", 31, 1.75, 68.9, 11, 2, 1);
            Lutador L2 = new Lutador("Putscript", "Brasil", 29, 1.68, 57.8, 14, 2, 3);
            Lutador L3 = new Lutador("Snapshadow", "EUA", 35, 1.65, 80.9, 12, 2, 1);
            Lutador L4 = new Lutador("Dead Code", "Austrália", 28, 1.93, 81.6, 13, 0, 2);
            Lutador L5 = new Lutador("Ufocobol", "Brasil", 37, 1.70, 119.3, 5, 4, 3);
            Lutador L6 = new Lutador("Nerdaard", "EUA", 30, 1.81, 105.7, 12, 2, 4);

            //INSTANCIANDO A LUTA
            Luta UEC1 = new Luta();
            UEC1.marcarLuta(L3, L3);
            UEC1.lutar();

            UEC1.marcarLuta(L1, L2);
            UEC1.lutar();
        }
    }


    //INTERFACE LUTADOR
    public interface ILutador {
        void apresentar();
        void status();
        void ganharLuta();
        void perderLuta();
        void empatarLuta();
    }

    
    //CLASSE 1
    public class Lutador : ILutador {
        //ATRIBUTOS
        private string nome;
        private string nacionalidade;
        private int idade;
        private double altura;
        private double peso;
        private string categoria;
        private int vitorias;
        private int derrotas;
        private int empates;


        //MÉTODOS ESPECIAIS
        public Lutador(string no, string na, int i, double a, double p, int v, int d, int e) {
            setNome(no);
            setNacionalidade(na);
            setIdade(i);
            setAltura(a);
            setPeso(p);
            setVitorias(v);
            setDerrotas(d);
            setEmpates(e);
        }


        public string getNome() {
            return nome;
        }
        public string getNacionalidade() {
            return nacionalidade;
        }
        public int getIdade() {
            return idade;
        }
        public double getAltura() {
            return altura;
        }
        public double getPeso() {
            return peso;
        }
        public string getCategoria() {
            return categoria;
        }
        public int getVitorias() {
            return vitorias;
        }
        public int getDerrotas() {
            return derrotas;
        }
        public int getEmpates() {
            return empates;
        }


        private void setNome(string no) {
            nome=no;
        }
        private void setNacionalidade(string na) {
            nacionalidade=na;
        }
        private void setIdade(int i) {
            idade=i;
        }
        private void setAltura(double a) {
            altura=a;
        }
        private void setPeso(double p) {
            peso=p;
            setCategoria(); //A categoria é definida depois de receber o peso.
        }
        private void setCategoria() {
            if (peso<52.2) {
                categoria="Inválido";
            }
            else if (peso<=70.3) {
                categoria="Leve";
            }
            else if (peso<=83.9) {
                categoria="Médio";
            }
            else if (peso<=120.2) {
                categoria="Pesado";
            }
        }
        private void setVitorias(int v) {
            vitorias+=v;
        }
        private void setDerrotas(int d) {
            derrotas+=d;
        }
        private void setEmpates(int e) {
            empates+=e;
        }


        //OUTROS MÉTODOS
        public void apresentar() {
            System.Console.WriteLine($"Me chamo {nome}, e vim para ganhar!!!\n");
        }
        public void status() {
            System.Console.WriteLine($"NOME: {nome}\nNACIONALIDADE: {nacionalidade}\nIDADE: {idade}\nALTURA: {altura}m\nPESO: {peso}kg\nCATEGORIA: {categoria}\nVITÓRIAS: {vitorias}\nDERROTAS: {derrotas}\nEMPATES: {empates}\n");
        }
        public void ganharLuta() {
            setVitorias(1);
        }
        public void perderLuta() {
            setDerrotas(1);
        }
        public void empatarLuta() {
            setEmpates(1);
        }
    }


    //INTERFACE LUTA
    public interface ILuta {
        void marcarLuta(Lutador l1, Lutador l2);
        void lutar();
    }


    //CLASSE 2
    public class Luta : ILuta {
        //ATRIBUTOS
        private Lutador desafiado; //Tipo abstrato, para relacionar as classes por meio de objetos. Cada lutador disputa 0 ou mais lutas. Cada luta é disputada por vários lutadores. Quando você relacionar as classes utilizando o "tem", ela é de agregação.
        private Lutador desafiante;
        private int rounds;
        private bool aprovada;


        //MÉTODOS ESPECIAIS
        //Não criei o construtor pois as variáveis são inicializadas em outros métodos.
        public Lutador getDesafiado() {
            return desafiado;
        }
        public Lutador getDesafiante() {
            return desafiante;
        }
        public int getRounds() {
            return rounds;
        }
        public bool getAprovada() {
            return aprovada;
        }
        private void setDesafiado(Lutador l) {
            desafiado=l;
        }
        private void setDesafiante(Lutador l) {
            desafiante=l;
        }
        private void setRounds(int r) {
            rounds=r;
        }
        private void setAprovada(bool a) {
            aprovada=a;
        }


        //OUTROS MÉTODOS
        public void marcarLuta(Lutador l1, Lutador l2) {
            if ((l1.getCategoria()==l2.getCategoria()) && (l1!=l2)) {
                desafiado=l1;
                desafiante=l2;
                aprovada=true;
            }
            else {
                desafiado=null;
                desafiante=null;
                aprovada=false;
            }
        }
        public void lutar() {
            if (aprovada==true) {
                desafiado.apresentar();
                desafiado.status();
                desafiante.apresentar();
                desafiante.status();

                Random v = new Random();
                int vencedor=v.Next(0, 2); //Aqui, geramos valores aleatórios: 0, 1 ou 2. Se cair no 1, o lutador 1 ganha, se 2, o lutador 2 ganha, e se 0, há um empate. 

                switch (vencedor) {
                    case 0:
                        System.Console.WriteLine("EMPATOU\n");
                        desafiado.empatarLuta();
                        desafiante.empatarLuta();
                    break;
                    case 1:
                        System.Console.WriteLine($"{desafiado.getNome()} ganhou a luta.");
                        desafiado.ganharLuta();
                        desafiante.perderLuta();
                    break;
                    case 2:
                        System.Console.WriteLine($"{desafiante.getNome()} ganhou a luta.");
                        desafiante.ganharLuta();
                        desafiado.perderLuta();
                    break;
                }
            }
            else {
                System.Console.WriteLine("ERRO! A LUTA NÃO FOI APROVADA.\n");
            }
        }
    }
}