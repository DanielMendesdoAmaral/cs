/*

CLASSES STATICS -> Não podem instanciar objetos; Não tem construtores; Atributos e métodos devem ser igualmente statics.

MÉTODOS E ATRIBUTOS STATICS -> Imagine um atributo bool da classe pública "sentimento" denominado "presente em animais". Se fosse um atributo público, cada objeto poderia gerar o seu próprio valor relacionado a esse atributo. Agora, se esse atributo for static, todos objetos terão o mesmo valor desse atributo. Por exemplo, se o atributo receber false, todos os objetos receberão false para esse atributo. Isso ocorre por que statics não permitem gerar espaços novos na memória, eles são estáticos, já tem uma posição definida na memória. É como se fosse uma variável global.

*/

using System;

namespace Aula_31___Classes__atributos_e_métodos_statics
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1: Classe static (atributos e métodos devem ser igualmente statics)
            Filme.imprimir("Jhon Wick", 2019); //Só isso. Esse é o valor guardado, eternamente, a menos que seja atualizado. 

            System.Console.WriteLine();

            //EX2: Classe public com atributo static. 
            Carros.cor="preto"; //Definido para todos objetos. 
            Carros c1 = new Carros("BMW");
            Carros c2 = new Carros("Jetta");
            Carros c3 = new Carros("Civic");
        }

        //EX1: Classe static (atributos e métodos devem ser igualmente statics)
        static public class Filme {
            static public string nome;
            static public int lancamento;
            static public void imprimir(string n, int l) {
                nome=n;
                lancamento=l;
                System.Console.WriteLine($"FILME: {nome}\nANO DE LANÇAMENTO: {lancamento}");
            }
        }

        //EX2: Classe public com atributo static. 
        public class Carros {
            static public string cor;
            public string modelo;
            public Carros(string m) {
                modelo=m;
                System.Console.WriteLine($"Seu carro {modelo} é {cor}.");
            }
        }
    }
}
