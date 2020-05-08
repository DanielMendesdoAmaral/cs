/*

Implemente o diagrama de classes.

Em seguida:
- Crie um objeto do tipo cachorro e faça-o pedir comida.
- Crie um objeto do tipo gato e faça-o pedir comida.

A tabela a seguir fornece a mesagem que deve ser impressa pelos métodos das classes.

        |  emitir_som()             |   pedir_comida()            
--------|---------------------------|------------------------------
Animal  |  Imprime o som do animal  |
        |  (armazenado no atributo  |
        |  som)                     |
--------|---------------------------|------------------------------
Cachorro|                           |  Chama o método emitir_som 
        |                           |  e depois imprime "Cachorro
        |                           |  abana o rabo".
--------|---------------------------|------------------------------
Gato    |                           |  Chama o método emitir_som e 
        |                           |  depois imprime "Gato faz
        |                           |  olhar triste".
--------|---------------------------|------------------------------
*/

using System;

namespace _4__Cachorro_e_gato_são_animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("Pitoco", "Au", "Vira-Lata");
            cachorro.PedirComida();

            Gato gato = new Gato("Sheik", "Miau", "Branco");
            gato.PedirComida();
        }
    }

    public interface IAnimal {
        void EmitirSom();
    }

    public class Animal : IAnimal {
        private string nome;
        private string som;

        public Animal(string n, string s) {
            SetNome(n);
            SetSom(s);
        }

        public string GetNome() {
            return nome;
        }
        public string GetSom() {
            return som;
        }

        public void SetNome(string n) {
            nome=n;
        }
        public void SetSom(string s) {
            som=s;
        }

        public void EmitirSom() {
            System.Console.Write($"{som}, {som}! ");
        }
    }

    public interface ICachorro {
        void PedirComida();
    }

    public class Cachorro : Animal, ICachorro {
        private string raca;

        public Cachorro(string n, string s, string r) : base(n, s) {
            SetRaca(r);
        }

        public string GetRaca() {
            return raca;
        }
        public void SetRaca(string r) {
            raca=r;
        }

        public void PedirComida() {
            EmitirSom();
            System.Console.Write("Cachorro abana o rabo!\n\n");
        }
    }

    public interface IGato {
        void PedirComida();
    }

    public class Gato : Animal, IGato {
        private string cor;

        public Gato(string n, string s, string c) : base(n, s) {
            SetCor(c);
        }

        public string GetCor() {
            return cor;
        }
        public void SetCor(string c) {
            cor=c;
        }

        public void PedirComida() {
            EmitirSom();
            System.Console.Write("Gato faz olhar triste!\n\n");
        }
    }
}
