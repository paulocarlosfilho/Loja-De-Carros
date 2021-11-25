
using Loja_De_Carros;
using System.Collections.Generic;

namespace LojaDeCarros
{
    public class Veiculos : IVeiculos
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
        
        //Herança e Polimorfismo
        //-----------------------------------------------------------------------------
        public virtual void MostrarRequisitosParaDirigir() 
        {
            System.Console.WriteLine("");
        }

        //------------------------------------------------------------------------------
        public class Carro : Veiculos
        {
            public Carro(string montadora, string modelo, int ano, decimal valor) : base(montadora, modelo, ano, valor)
            {
            }
            public override void MostrarRequisitosParaDirigir()
            {
                System.Console.WriteLine("Categoria CNH 'B'");
            }
        }
        //------------------------------------------------------------------------------
        public class Moto : Veiculos
        {
            public Moto(string montadora, string modelo, int ano, decimal valor) : base(montadora, modelo, ano, valor)
            {
            }
            public override void MostrarRequisitosParaDirigir()
            {
                System.Console.WriteLine("Categoria CNH 'A'");
            }
        }

        //------------------------------------------------------------------------------
        public class Caminhao : Veiculos
        {
            public Caminhao(string montadora, string modelo, int ano, decimal valor) : base(montadora, modelo, ano, valor)
            {
            }
            public override void MostrarRequisitosParaDirigir()
            {
                System.Console.WriteLine("Categoria CNH 'C'");
            }
        }

        //------------------------------------------------------------------------------
        public class Onibus : Veiculos
        {
            public Onibus(string montadora, string modelo, int ano, decimal valor) : base(montadora, modelo, ano, valor)
            {
            }
            public override void MostrarRequisitosParaDirigir()
            {
                System.Console.WriteLine("Categoria CNH 'D'");
            }
        }
        //------------------------------------------------------------------------------
    }
}