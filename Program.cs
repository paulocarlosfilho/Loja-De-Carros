using Loja_De_Carros;
using System;
using System.Collections.Generic;

namespace LojaDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------
            //Henreça e Polimorphismo -  Cada veículo registrado Pede uma habilitação. - E a lista fica na loja para as pessoas comprrarem.
            //Caso mude a ordem, o resultado muda. EX: Ao inves de começar em "Carro" for indicado que comece em "Caminhão"
            //a carteira de habilitação irá mudar.

            var listaVeiculos = new List<Veiculos>();
            listaVeiculos.Add(new Veiculos.Carro("Honda", "Civic", 2022, 75000));
            listaVeiculos.Add(new Veiculos.Moto("BMW", "10000", 2022, 50000));
            listaVeiculos.Add(new Veiculos.Onibus("Mercedes", "Top de Linha", 2022, 200000));
            listaVeiculos.Add(new Veiculos.Caminhao("Volvo", "Da Estrada", 2022, 300000));
            foreach (var veiculo in listaVeiculos)
            {
                veiculo.MostrarRequisitosParaDirigir();
            }

                //-------------------------------------------------------------------------            

            
            Console.WriteLine("-- Loja de CARROS de Paulo Carlos, Luciana Carla, Everton Rodrigues, Leandro José --");
            Console.WriteLine();

          
            MenuPrincipal();

            void MenuPrincipal()
            {
                Console.WriteLine("Digite uma opção a seguir: ");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastro de carros");
                Console.WriteLine("2 - Lista de carros");
                Console.WriteLine("3 - Comprar carro");
                Console.WriteLine("4 - Herança e Polimorfismo");
                Console.WriteLine("0 - Sair");

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
                    Console.WriteLine($"{i} - {veiculos[i].Montadora} - {veiculos[i].Modelo} - {veiculos[i].Ano} - R${veiculos[i].Valor}.");
                }
            }
            //-------------------------------------------------------------------------
            Veiculos CadastrarVeiculo()
            {
                Console.Write("Digite a Montadora: ");
                var montadora = Console.ReadLine();

                Console.Write("Digite o Modelo: ");
                var modelo = Console.ReadLine();

                Console.Write("Digite o ano: ");
                var ano = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor: R$ ");
                var valor = decimal.Parse(Console.ReadLine());
                return new Veiculos(
                    modelo,
                    montadora,
                    ano,
                    valor
                );
            }
        }

        }
    }

