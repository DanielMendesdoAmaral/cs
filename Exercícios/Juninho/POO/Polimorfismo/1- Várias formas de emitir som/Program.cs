/*

Crie uma hierarquia de classes conforme o diagrama. Os atributos em comum devem ficar na classe Animal e cada tipo de animal deve emitir um som diferente. No programa principal, crie objetos dos 3 tipos de animais e execute o método que emite o som de cada um. Implemente a seguir uma classe Veterinario que contenha o método examinar() cujo parâmetro de entrada é um animal. O veterinário deve examinar cada um dos animais. Quando o animal for examinado ele também deve emitir o som do animal.

Veja um exemplo de programa principal

dog = Cachorro("Rex", 3)
horse = Cavalo("Horse", 6)
cat = Gato("Tina", 1)
dog.emitir_som() # exibe o som do cachorro
horse.emitir_som() # exibe o som do cavalo
cat.emitir_som() # exibe o som do gato
vet = Veterinario()
vet.examinar(dog) # exibe o som do cachorro
vet.examinar(horse) # exibe o som do cavalo
vet.examinar(cat) # exibe o som do gato 

*/

using System;

namespace _1__Várias_formas_de_emitir_som
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro dog = new Cachorro("Pitoco", 3);
            Cavalo horse = new Cavalo("Trovão", 6);
            Gato cat = new Gato("Sheik", 1);

            Veterinario vet = new Veterinario();

            System.Console.WriteLine(dog.EmitirSom());
            System.Console.WriteLine(horse.EmitirSom());
            System.Console.WriteLine(cat.EmitirSom());

            vet.Examinar(dog);
            vet.Examinar(horse);
            vet.Examinar(cat);
        }
    }

    abstract public class Animal {
        private string nome;
        private int idade;

        public Animal(string n, int i) {
            SetNome(n);
            SetIdade(i);
        }

        public string GetNome() {
            return nome;
        }
        public void SetNome(string n) {
            nome=n;
        }
        public int GetIdade() {
            return idade;
        }
        public void SetIdade(int i) {
            idade=i;
        }

        abstract public string EmitirSom();
    }

    public class Veterinario { //Polimorfismo por sobrecarga
        public void Examinar(Cachorro c) {
            System.Console.WriteLine($"Examinando o {c.GetNome()}...");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine($"{c.EmitirSom()}\n");
        }
        public void Examinar(Gato g) {
            System.Console.WriteLine($"Examinando o {g.GetNome()}...");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine($"{g.EmitirSom()}\n");
        }
        public void Examinar(Cavalo c) {
            System.Console.WriteLine($"Examinando o {c.GetNome()}...");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine($"{c.EmitirSom()}\n");
        }
    }

    public class Cachorro : Animal { //Cada classe a seguir implementa o polimorfismo por sobreposição a partir de uma classe abstrata. 
        public Cachorro(string n, int i) : base(n, i) {}

        override public string EmitirSom() {
            return "Au, au!";
        }
    }

    public class Gato : Animal {
        public Gato(string n, int i) : base(n, i) {}

        override public string EmitirSom() {
            return "Miau, miau!";
        }
    }

    public class Cavalo : Animal {
        public Cavalo(string n, int i) : base(n, i) {}

        override public string EmitirSom() {
            return "hiin in in hinir";
        }
    }
}