using System;

namespace Aula_40___Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //CLASSES VIRTUAIS

    sealed public class Selado {
        int n=5;
    }

    /*public class Erro : Selado {
        ESSA LINHA GERA ERRO, POIS CLASSES SEALEDS NÃO PODEM SER HERDADAS.
    }*/


    //MÉTODOS SEALEDS
    //Se você não quiser que seu método seja modificado pelos filhos, apenas não declare-o como virtual. Agora, se voce quer que ele seja herdado por apenas uma (pode ser mais também, o importante é fazer os passos descritos a seguir) classe filha, declare ele como virtual na MÃE da classe que voce quer modificá-lo, e na classe que você modificou ele, coloque-o como sealed. 

    public class A {
        virtual public void F() {
            System.Console.WriteLine("Posso ser modificado.");
        }
    }

    public class B : A {
        protected int b; 
        //Se você tentar modificar o método F aqui, não dará erro, pois o método está selado apenas para as filhas a partir de C.
    }

    public class C : B {
        sealed public override void F() {
            System.Console.WriteLine("Posso ser modificado apenas em B, e ficarei selado.");
        }
    }
}