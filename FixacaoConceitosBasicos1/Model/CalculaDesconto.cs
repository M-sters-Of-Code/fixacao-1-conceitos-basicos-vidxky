using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class CalculaDesconto
    {
        public static void Executar()
        {
            Console.Write("Digite o valor do produto: ");
            double valorProduto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de desconto (%): ");
            double percentualDesconto = Convert.ToDouble(Console.ReadLine());

            double valorDesconto = valorProduto * (percentualDesconto / 100);
            double valorFinal = valorProduto - valorDesconto;

            Console.WriteLine("\n--- Informações do Desconto ---");
            Console.WriteLine($"Valor inicial: R$ {valorProduto:F2}");
            Console.WriteLine($"Percentual de desconto: {percentualDesconto}%");
            Console.WriteLine($"Valor do desconto: R$ {valorDesconto:F2}");
            Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
        }
    }
}
