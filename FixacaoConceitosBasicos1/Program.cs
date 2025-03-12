
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */
//Primeira tarefa realizada

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Converter Metros para Milímetros");
            Console.WriteLine("2 - Calcular Aumento");
            Console.WriteLine("3 - Calcular Desconto");
            Console.WriteLine("4 - Calcular Aluguel do Carro");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    MetrosMilimetros.Executar();
                    break;
                case 2:
                    CalculaAumento.Executar();
                    break;
                case 3:
                    CalculaDesconto.Executar();
                    break;
                case 4:
                    AluguelCarro.Executar();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();
        }
    }
}

