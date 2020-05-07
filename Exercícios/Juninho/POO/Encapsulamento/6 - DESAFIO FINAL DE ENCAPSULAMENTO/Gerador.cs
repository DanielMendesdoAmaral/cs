using System;
using System.Collections.Generic;
using System.Text;

namespace _6___DESAFIO_FINAL_DE_ENCAPSULAMENTO
{
    class Gerador : IGerador
    {
        private Especificacao especificacoes;
        private string nome;
        private string status;
        private int combustivel;

        public Gerador(Especificacao e, string n, int c)
        {
            SetEspecificacoes(e);
            SetNome(n);
            SetStatus("Desligado");
            SetCombustivel(c);
        }

        public Especificacao GetEspecificacoes()
        {
            return especificacoes;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetStatus()
        {
            return status;
        }
        public int GetCombustivel()
        {
            return combustivel;
        }

        public void SetEspecificacoes(Especificacao e)
        {
            especificacoes = e;
        }
        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetStatus(string s)
        {
            status = s;
        }
        public void SetCombustivel(int c)
        {
            combustivel = c;
        }

        public void Ligar()
        {
            if (GetCombustivel()<50)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine($"    {GetNome()} não pode ser ligado por falta de combustível.");
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"    Retornando ao menu principal...");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                System.Console.Clear();
            }
            else
            {
                combustivel -= 50;
                SetStatus("Ligado");
                System.Console.WriteLine($"    {GetNome()} foi ligado com sucesso.");
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"    Retornando ao menu principal...");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                System.Console.Clear();
            }
        }
        public void Desligar()
        {
            SetStatus("Desligado");
            System.Console.WriteLine($"    {GetNome()} foi desligado com sucesso.");
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine($"    Retornando ao menu principal...");
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Threading.Thread.Sleep(2000);
            System.Console.Clear();
        }
        public void Abastecer(int c)
        {
            if (c+combustivel > especificacoes.GetTamanhoTanque())
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine($"    Erro! A quantidade inserida para abastecimento ultrapassa os limites do tanque.");
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"    Retornando ao menu principal...");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                System.Console.Clear();
            }
            else if (c<0)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine($"    Erro! A quantidade inserida é inválida.");
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"    Retornando ao menu principal...");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                System.Console.Clear();
            }
            else
            {
                combustivel += c;
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"    Abastecimento bem sucedido.");
                System.Console.WriteLine($"    Retornando ao menu principal...");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                System.Console.Clear();
            }
        }

        public void StatusGeradores()
        {
            if (GetStatus()=="Desligado")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine($"    {GetNome()} - {GetStatus()}");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
            else
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"    {GetNome()} - {GetStatus()}");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
        }

        public void StatusTanques()
        {
            if (combustivel < 0.2*especificacoes.GetTamanhoTanque())
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine($"    {combustivel}/{especificacoes.GetTamanhoTanque()}     (ABASTECER)");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
            else
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"    {combustivel}/{especificacoes.GetTamanhoTanque()}");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
        }

        public void DetalhesGerador()
        {
            for (int c=10; c>0; c--)
            {
                System.Console.WriteLine($"\n    DETALHES DO GERADOR\n    Nome: {GetNome()}\n    Potência: {especificacoes.GetPotencia()}\n    Capacidade de geração de energia: {especificacoes.GetCapacidadeGeracao()}\n    Tamanho do tanque: {especificacoes.GetTamanhoTanque()}\n    Status: {GetStatus()}");
                System.Console.Write("    Saindo do menu de detalhes do gerador em... ");
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.Write($"{c}s");
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Threading.Thread.Sleep(1000);
                System.Console.Clear();
            }
        }
    }
}