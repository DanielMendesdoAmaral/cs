using System;

namespace _3__Cédulas_e_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um valor em dinheiro: R$");
            decimal valor = Decimal.Parse(Console.ReadLine()); 
            decimal resto = 0, restoInteiro = 0;
            Console.Clear();

            decimal notasCem = (int) valor/100;
            resto = valor%100;
            decimal notasCinquenta = (int) resto/50;
            resto = resto - notasCinquenta*50;
            decimal notasVinte = (int) resto/20;
            resto = resto - notasVinte*20;
            decimal notasDez = (int) resto/10;
            resto = resto - notasDez*10;
            decimal notasCinco = (int) resto/5;
            resto = resto - notasCinco*5;
            decimal notasDois = (int) resto/2;
            resto = resto - notasDois*2;
            decimal moedaUm = (int) resto/1;
            restoInteiro = (resto - moedaUm*1)*100;
            decimal moedaCinq = (int) restoInteiro/50;
            restoInteiro = restoInteiro - moedaCinq*50;
            decimal moedaVinteCinco = (int) restoInteiro/25;
            restoInteiro = restoInteiro - moedaVinteCinco*25;
            decimal moedaDez = (int) restoInteiro/10;
            restoInteiro = restoInteiro - moedaDez*10;
            decimal moedaCinco = (int) restoInteiro/5;
            restoInteiro = restoInteiro - moedaCinco*5;
            decimal moedaUmCentavo = (int) restoInteiro/1;

            if (notasCem!=0){
                System.Console.WriteLine(notasCem + " nota(s) de R$100,00.");
            }
            if (notasCinquenta!=0){
                System.Console.WriteLine(notasCinquenta + " nota(s) de R$50,00.");
            }
            if (notasVinte!=0){
                System.Console.WriteLine(notasVinte + " nota(s) de R$20,00.");
            }
            if (notasDez!=0){
                System.Console.WriteLine(notasDez + " nota(s) de R$10,00.");
            }
            if (notasCinco!=0){
                System.Console.WriteLine(notasCinco + " nota(s) de R$5,00.");
            }
            if (notasDois!=0){
                System.Console.WriteLine(notasDois + " nota(s) de R$2,00.");
            }
            if (moedaUm!=0){
                System.Console.WriteLine(moedaUm + " moeda(s) de R$1,00.");
            }
            if (moedaCinq!=0){
                System.Console.WriteLine(moedaCinq + " moeda(s) de R$0,50.");
            }
            if (moedaVinteCinco!=0){
                System.Console.WriteLine(moedaVinteCinco + " moeda(s) de R$0,25.");
            }
            if (moedaDez!=0){
                System.Console.WriteLine(moedaDez + " moeda(s) de R$0,10.");
            }
            if (moedaCinco!=0){
                System.Console.WriteLine(moedaCinco + " moeda(s) de R$0,05.");
            }
            if (moedaUmCentavo!=0){
                System.Console.WriteLine(moedaUmCentavo + " moeda(s) de R$0,01.");
            }
        }
    }
}
