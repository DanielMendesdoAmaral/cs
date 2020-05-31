using System;
using System.Data.SqlTypes;

namespace Aula_41___Acessors_GET_e_SET
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cao = new Cachorro();
            cao.c = "Branco"; //Aqui ele usa o set
            System.Console.WriteLine(cao.c); //Aqui ele usa o get
        }
    }
}