//Classe: Molde que agrupa um conjunto de atributos.
//Objeto: Instanciado a partir de uma classe, herdando os atributos nela especificados. 

/* 

modificador-classe class NomeDaClasse {
    //Variáveis / propriedades
    especificador-acesso tipo nomePropriedade

    //Métodos
    especificador-acesso retorno NomeMétodo(arg1, ....) {
        //Bloco do método
    }
}


MODIFICADOR-CLASSE: Define a visibilidade da classe.
    //public: Sem restrição de visualização. Quando não se coloca nada antes da classe, subentende-se que ela é public.
    //abstract: Classe base para outras classes. Não podem instanciar objetos. 
    //sealed: Não pode ser herdada. 
    //static: Não podem instanciar objetos e seus membros devem ser igualmente statics. Estática. Uma vez tendo seu atributo definido, nunca mudará, é como uma variável constante.


ESPECIFICADOR-ACESSO: Onde um membro da classe pode ser acessado. 
    //public: Sem restrição de acesso. "UML +", orelhão.
    //private: Só podem ser acessados pela própria classe. "UML -", celular
    //protected: Podem ser acessadas pela própria classe e nas classes derivadas. "UML #", tel. fixo de casa
    //abstract: Os métodos não tem implementação, somente os cabeçalhos. 
    //sealed: O método não pode ser redefinido. 
    //virtual: O método pode ser redefinido em uma classe derivada. 
    //static: O método pode ser chamado mesmo sem a instanciação de um objeto. Uma vez tendo seu atributo definido, nunca mudará, é como uma variável constante.

*/

using System;

namespace Aula_28___Classes_e_objetos
{

    class Program
    {
        static void Main(string[] args)
        {
            Frutas f1 = new Frutas();
            f1.calorias = 100;
            f1.nome = "Abacaxi";
            System.Console.Write("Há quantos dias você foi à feira? ");
            int dias = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine( f1.EstragadoOuNão(dias) );
        }
    }


    class Frutas { //Essa classe é public por padrão. 
        public int calorias; //Esse atributo, por ser público, pode ser acessado por qualquer classe.
        public string nome;
        public string EstragadoOuNão (int d) { //Esse método é public por padrão.
            if (d>7) {
                return $"O(a) {nome} tem {calorias}kj calorias e por ter sido comprado há {d} dias, está estragado(a).";
            }

            else {
                return $"O(a) {nome} tem {calorias}kj calorias e por ter sido comprado há {d} dias, não está estragado(a).";
            }
        }
    }
}