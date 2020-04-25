using System;

namespace _3__Verificando_as_primeiras_letras_de_um_texto__com_tratamento_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Só será verdade se o nome da cidade começar com "Santo"

            System.Console.Write("Em que cidade você nasceu? ");
            string cidade = Console.ReadLine();
            cidade = cidade.TrimStart(); cidade = cidade.TrimEnd(); //Remove espaços do começo e do final, respectivamente
            string[] nomes = cidade.Split(" ");
            nomes[0] = nomes[0].ToLower();
            bool trueFalse = nomes[0] == "santo";
            System.Console.WriteLine(trueFalse);
        }
    }
}
