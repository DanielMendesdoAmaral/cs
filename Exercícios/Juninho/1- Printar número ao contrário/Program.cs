using System;

namespace _1__Printar_número_ao_contrário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro de 0 a 9999: ");
            int numero = Int32.Parse(Console.ReadLine());
            int milhar = numero/1000;
            int centena = (numero-(milhar*1000))/100;
            int dezena = (numero-(milhar*1000)-(centena*100))/10;
            int unidade = (numero-(milhar*1000)-(centena*100)-(dezena*10));
            if ((numero/1000)>=1){
                Console.WriteLine("Aqui está o número que você digitou, ao contrário: " + unidade + dezena + centena + milhar);
            }
            else if ((numero/100)>=1){
                Console.WriteLine("Aqui está o número que você digitou, ao contrário: " + unidade + dezena + centena);
            }
            else if ((numero/10)>=1){
                Console.WriteLine("Aqui está o número que você digitou, ao contrário: " + unidade + dezena);
            }
            else {
                Console.WriteLine("Aqui está o número que você digitou, ao contrário: " + unidade);
            }
        }
    }
}
