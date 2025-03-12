using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class AluguelCarro
    {
        public static void Executar()
        {
            const double VALOR_DIARIA = 95.00;
            const double VALOR_POR_KM = 0.35;

            Console.Write("Digite o número de dias alugados: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quilometragem inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            double kmPercorridos = kmFinal - kmInicial;
            double custoTotal = (dias * VALOR_DIARIA) + (kmPercorridos * VALOR_POR_KM);

            Console.WriteLine("\n--- Informações do Aluguel ---");
            Console.WriteLine($"Dias alugados: {dias}");
            Console.WriteLine($"Quilômetros percorridos: {kmPercorridos:F2} km");
            Console.WriteLine($"Valor total a pagar: R$ {custoTotal:F2}");
        }
    }
}
