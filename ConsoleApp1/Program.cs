using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] operacoesRealizadas = new string[100];
            string opcao = "";
            int contadorOperacoesRealizadas = 0;

            while (true)
            {
                MostraMenu();

                opcao = Console.ReadLine();

                if (EOpcaoInvalida(opcao)) //AND
                {

                    ApresMensagem("Opção inválida! Tente novamente");

                    continue;
                }

                if (EhOpcaoVizualizacao(opcao))
                {
                    Console.WriteLine();

                    if (contadorOperacoesRealizadas == 0)
                    {
                        MostrarMensagem("Nenhuma operação foi realizada ainda.Tente novamente");
                    }
                    else
                    {
                        for (int i = 0; i < operacoesRealizadas.Length; i++)
                        {
                            if (operacoesRealizadas[i] != null)
                                Console.WriteLine(operacoesRealizadas[i]);
                        }
                    }

                    Console.ReadLine();

                    Console.Clear();

                    continue;
                }

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
          }
                             private static void MostraMenu()


                               Console.WriteLine("Calculadora 1.7.1");

                Console.WriteLine();

                Console.WriteLine("Digite 1 para somar");

                Console.WriteLine("Digite 2 para subtrair");

                Console.WriteLine("Digite 3 para multiplicação");

                Console.WriteLine("Digite 4 para divisão");

                Console.WriteLine("Digite 5 para vizualizar as operações realizadas");

                Console.WriteLine();

                Console.WriteLine("Digite 5 para sair");
            }
        }

        private static void MostrarMensagem(string v)
        {
            throw new NotImplementedException();
        }

        private static void ApresMensagem(string v)
        {
            throw new NotImplementedException();
        }

        private static bool EhOpcaoVizualizacao(string opcao)
        {
            return opcao == "5";
        }

        private static void ApresentarMensagem(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(mensagem);

            Console.ResetColor();

            Console.ReadLine();

            Console.Clear();
        }

        private static bool EOpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3"
                                && opcao != "4" && opcao != "5"
                                && opcao != "S" && opcao != "s";
        }
    }
