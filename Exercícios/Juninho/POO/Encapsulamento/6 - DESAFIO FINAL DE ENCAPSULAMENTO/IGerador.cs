using System;
using System.Collections.Generic;
using System.Text;

namespace _6___DESAFIO_FINAL_DE_ENCAPSULAMENTO
{
    interface IGerador
    {
        void Ligar();
        void Desligar();
        void Abastecer(int c);
        void StatusGeradores();
        void StatusTanques();
        void DetalhesGerador();
    }
}