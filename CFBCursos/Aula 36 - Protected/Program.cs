using System;

namespace Aula_36___Protected
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //Foram criadas classes simples e sem métodos especiais apenas por praticidade, mas você deve sempre usá-los. Também, sempre use membros privados, no máximo, na pior das hipóteses, use protected.

    public class Base {
        public int n1=0;
        protected int n2=1;
        private int n3=2;

        public int GetN3() {
            return n3;
        }
    }

    public class Derivada1 : Base {
        public int Somar() {
            int soma = n1+n2+GetN3(); //n1 é público, portanto, visível para todos. n2 é protegido, portanto, visível apenas para seus filhos. n3 é privado, portanto, só pode ser acessado pela mãe, a menos que você use métodos especiais.
            return soma;
        }
    }
}
