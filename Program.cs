using System;
using System.Collections.Generic;

namespace LojaDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaVeiculos = new List<Veiculos>();
            Console.WriteLine("-- Loja de CARROS de Paulo Carlos, Luciana Carla, Everton Rodrigues, Leandro José --");
            System.Console.WriteLine();

                //-------------------------------------------------------------------------            

            MenuPrincipal();

            void MenuPrincipal()
            {
                System.Console.WriteLine("Digite uma opção a seguir: ");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Cadastro de carros");
                System.Console.WriteLine("2 - Lista de carros");
                System.Console.WriteLine("3 - Comprar carro");
                System.Console.WriteLine("0 - Sair");

                var opçaoDesejada = Console.ReadLine();

                //-------------------------------------------------------------------------
                //Opções do menu

                while (opçaoDesejada != "0")
                {
                    switch (opçaoDesejada)
                    {
                        case "1":
                            var veiculo = CadastrarVeiculo();
                            listaVeiculos.Add(veiculo);
                            System.Console.WriteLine("Veículo cadastrado com sucesso!");
                            break;
                        case "2":
                            ListarVeiculos(listaVeiculos);
                            break;
                        case "3":
                            ComprarVeiculo(listaVeiculos);
                            break;
                        default:
                            Console.WriteLine("Fim do programa.");
                            break;
                    }
                    MenuPrincipal();
                    opçaoDesejada = Console.ReadLine();
                }
            }
            //-------------------------------------------------------------------------

            void ComprarVeiculo(List<Veiculos> veiculos)
            {
                System.Console.WriteLine("Escolha uma opção de veículo para compra a seguir: ");
                ListarVeiculos(veiculos);
                var opçao = int.Parse(Console.ReadLine());

                var veiculo = veiculos[opçao];

                veiculos.Remove(veiculo);

                System.Console.WriteLine("Veículo comprado com sucesso!");
            }

            //-------------------------------------------------------------------------
            void ListarVeiculos(List<Veiculos> veiculos)
            {
                for (var i = 0; i < veiculos.Count; i++)
                {
                    System.Console.WriteLine($"{i} - {veiculos[i].Montadora} - {veiculos[i].Modelo} - {veiculos[i].Ano} - R${veiculos[i].Valor}");
                }
            }
            //-------------------------------------------------------------------------
            Veiculos CadastrarVeiculo()
            {
                System.Console.Write("Digite a Montadora: ");
                var montadora = Console.ReadLine();

                System.Console.Write("Digite o Modelo: ");
                var modelo = Console.ReadLine();

                System.Console.Write("Digite o ano: ");
                var ano = int.Parse(Console.ReadLine());

                System.Console.Write("Digite o valor: R$ ");
                var valor = decimal.Parse(Console.ReadLine());
                return new Veiculos(
                    modelo,
                    montadora,
                    ano,
                    valor
                );
            }

            //-------------------------------------------------------------------------


        }
    }
}
