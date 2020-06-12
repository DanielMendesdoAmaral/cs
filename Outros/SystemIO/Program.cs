using System;
using System.IO;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = "file.txt"; //Grava o nome do arquivo na variável.
            using (StreamReader sr = File.OpenText(arquivo)) { //Use o using pois assim que terminar ele fecha o arquivo. A variável sr abre o arquivo.
                Console.WriteLine(sr.ReadLine()); //Imprimimos a primeira linha do arquivo no console.
            }

            arquivo = "twofile.html"; //Sobrescrevemos a variável, guardando um novo nome de arquivo.
            //Aqui usamos um método para escrever. Parâmetro 1: O nome do arquivo que voce irá escrever.. Parâmetro 2: O texto que você quer escrever.
            File.WriteAllText(arquivo, "<!DOCTYPE html>\n<html lang='pt-br'>\n    <head>\n        <meta charset='UTF-8'>\n        <title>HTML com C#</title>\n    </head>\n    <body>\n        <h1>Hello, World!</h1>\n    </body>\n</html>");
        }
    }
}