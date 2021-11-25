
using System.Collections.Generic;

namespace LojaDeCarros
{
    public class Veiculos
    {
        //---------------------------------------------------------------------------
        public Veiculos(string montadora, string modelo, int ano, decimal valor)
        {
            Montadora = montadora;
            Modelo = modelo;
            Ano = ano;
            Valor = valor;
        }

        public string Montadora { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public decimal Valor { get; private set; }
    }
}