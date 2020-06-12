using System;

namespace Aula_38___Virtual_e_override
{
    class Program
    {
        static void Main(string[] args)
        {
            Mae m = new Mae();
            Filha f = new Filha();

            m.MesmoMetodo();
            f.MesmoMetodo();
        }
    }

    //Para sobrecrever um método:

    public class Mae {
        virtual public void MesmoMetodo() { //Crie um método na classe mãe. Tem que ser virtual. 
            System.Console.WriteLine("Original");
        }
    }

    public class Filha : Mae{ //Na classe filha (precisa ser filha), coloque o método com o mesmo nome, e sobrescreva. Precisa colocar override antes. 
        override public void MesmoMetodo() {
            System.Console.WriteLine("Método sobrescrito");
        }
    } 

    //É útil pois ás vezes você não quer um método igual foi declarado na mãe, entao você pode modificá-lo. Você pode sobrescrever nas filhas das filhas também.
}
