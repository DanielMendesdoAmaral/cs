using System;

namespace _4__Média_ponderada
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2 = 0, p3 = 0, frequencia = 0;

            do {
                System.Console.Write("NOTA DA PROVA 1: ");
                p1 = Double.Parse(Console.ReadLine());
                if (p1<0){
                    System.Console.WriteLine("ERRO! NOTA DEVE SER MAIOR QUE ZERO!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Clear();
                } 
                else if (p1>10) {
                    System.Console.WriteLine("ERRO! NOTA DEVE SER MENOR QUE 10!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Clear();                    
                }
            } while ((p1<0) || (p1>10));
            System.Threading.Thread.Sleep(250);
            System.Console.Clear();

            do {
                System.Console.Write("NOTA DA PROVA 2: ");
                p2 = Double.Parse(Console.ReadLine());
                if  (p2<0){
                    System.Console.WriteLine("ERRO! NOTA DEVE SER MAIOR QUE ZERO!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Clear();                    
                }
                else if (p2>10) {
                    System.Console.WriteLine("ERRO! NOTA DEVE SER MENOR QUE 10!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Clear();                    
                }
            } while ((p2<0) || (p2>10));
            System.Threading.Thread.Sleep(250);
            System.Console.Clear();

            do {
                System.Console.Write("NOTA DA PROVA 3: ");
                p3 = Double.Parse(Console.ReadLine());
                if  (p3<0){
                    System.Console.WriteLine("ERRO! NOTA DEVE SER MAIOR QUE ZERO!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Clear();                    
                }
                else if (p3>10) {
                    System.Console.WriteLine("ERRO! NOTA DEVE SER MENOR QUE 10!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Clear();                    
                }
            } while ((p3<0) || (p3>10));
            System.Threading.Thread.Sleep(250);
            System.Console.Clear();

            do {
                System.Console.Write("FREQUÊNCIA: ");
                frequencia = Double.Parse(Console.ReadLine());
                if  (frequencia<0){
                    System.Console.WriteLine("ERRO! FREQUÊNCIA DEVE SER MAIOR QUE ZERO!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Clear();
                }
                else if (frequencia>1) {
                    System.Console.WriteLine("ERRO! FREQUÊNCIA DEVE SER MENOR QUE 1!");
                    System.Threading.Thread.Sleep(1000);
                    System.Console.Clear();
                }
            } while ((frequencia<0) || (frequencia>1));
            System.Threading.Thread.Sleep(250);
            System.Console.Clear();

            double mediaPonderada = (double) Math.Round((((p1*2) + (p2*2) + (p3*3))/(2+2+3)), 1);
            frequencia *= 100;
            
            System.Console.WriteLine("MÉDIA FINAL: " + mediaPonderada + ".");
            System.Console.WriteLine("FREQUÊNCIA: " + frequencia + "%.");
            System.Console.Write("SITUAÇÃO: ");
            if (frequencia<75){
                System.Console.WriteLine("Aluno reprovado por faltas.");
            } 
            else if (mediaPonderada>9){
                System.Console.WriteLine("Aluno aprovado com louvor.");
            }
            else if ((mediaPonderada>=6) && (mediaPonderada<=9)){
                System.Console.WriteLine("Aluno aprovado.");
            }
            else if ((mediaPonderada>=4) && (mediaPonderada<6)){
                System.Console.WriteLine("Aluno de recuperação.");
            }
            else if (mediaPonderada<4) {
                System.Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
