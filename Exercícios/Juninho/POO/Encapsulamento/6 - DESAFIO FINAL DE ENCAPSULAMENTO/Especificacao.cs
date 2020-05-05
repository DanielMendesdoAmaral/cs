using System;
using System.Collections.Generic;
using System.Text;

namespace _6___DESAFIO_FINAL_DE_ENCAPSULAMENTO
{
    class Especificacao
    {
        private int tamanhoTanque;
        private int capacidadeGeracao;
        private int potencia;

        public Especificacao(int t, int c, int p)
        {
            SetTamanhoTanque(t);
            SetCapacidadeGeracao(c);
            SetPotencia(p);
        }

        public int GetTamanhoTanque()
        {
            return tamanhoTanque;
        }
        public int GetCapacidadeGeracao()
        {
            return capacidadeGeracao;
        }
        public int GetPotencia()
        {
            return potencia;
        }

        public void SetTamanhoTanque(int t)
        {
            tamanhoTanque = t;
        }
        public void SetCapacidadeGeracao(int c)
        {
            capacidadeGeracao = c;
        }
        public void SetPotencia(int p)
        {
            potencia = p;
        }
    }
}