using System;

namespace Aula_52_e_53___Exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO 1 - Básico
            Console.Clear();
            
            try { //Ele vai tentar executar esse bloco. Se der certo, ok. Se não, ele vai executar o bloco catch. 
                System.Console.Write("Digite um número: ");
                int n1 = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Digite outro número: ");
                int n2 = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine($"{n1}/{n2} = {n1/n2}");
            }   
            catch {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("ERRO!");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
            
            Console.Clear();
            
            //EXEMPLO 2 - Gravar o erro
            try { 
                System.Console.Write("Digite um número: ");
                int n1 = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Digite outro número: ");
                int n2 = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine($"{n1}/{n2} = {n1/n2}");
            }   
            catch (Exception e) { //O erro fica gravado em e. Você pode chamar vários métodos, pois e faz parte da classe exception e é repleta de métodos.
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("ERRO! " + e.Message);
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }

            Console.Clear();
            
            //EXEMPLO 3 - Finally
            try { 
                System.Console.Write("Digite um número: ");
                int n1 = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Digite outro número: ");
                int n2 = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine($"{n1}/{n2} = {n1/n2}");
            }   
            catch (Exception e) {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("ERRO! " + e.Message);
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
            finally { //Se der erro, ou não, ele vai executar o finally.
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine("Obrigado por utilizar nosso sistema.");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }

            Console.Clear();

            //EXEMPLO 4 - Forçando um erro.

            try {
                System.Console.Write("Informe a largura do quadrado: ");
                double largura = Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write("Informe a altura do quadrado: ");
                double altura = Convert.ToDouble(System.Console.ReadLine());

                if ((largura<=0) || (altura<=0)) {
                    throw new Exception("Base ou altura tem que ser maior que zero.");
                }
                else {
                    System.Console.WriteLine($"A área do qaudrado é: {largura*altura}");
                }
            }catch {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("ERRO! Base ou altura tem que ser maior que zero.");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
        }
    }
}