using System;

namespace Aula_39___Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mae m = new Mae();      <--- Esta linha gera um erro, pois objetos de classes abstratas não podem ser instanciadas. 
        }
    }

    abstract public class Mae { //Classes abstratas não podem ser instanciadas. Só servem de base para outras classes.
        public void NaoAbstrato() { 
            System.Console.WriteLine("Não sou abstrato. Por isso, tenho que ser implementado aqui.");
        }

        abstract public void Abstrato(); //Esse método, por ser abstrato, precisa ser implementado na filha. Entenda, por implementar, você definir o que um método faz.
    }

    public class Filha : Mae {
        override public void Abstrato() { //Precisa por override, pois você está sobrescrevendo o método e o implementando.
            System.Console.WriteLine("Aqui, sou implementado.");
        }
    }
}
