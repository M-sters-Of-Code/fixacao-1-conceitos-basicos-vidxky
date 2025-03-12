using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{ 
class CalculaAumento
{
    public static void Executar()
    {
        Console.Write("Digite o salário atual: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o percentual de aumento (%): ");
        double percentual = Convert.ToDouble(Console.ReadLine());

        double aumento = salario * (percentual / 100);
        double novoSalario = salario + aumento;

        Console.WriteLine("\n--- Informações do Aumento ---");
        Console.WriteLine($"Salário inicial: R$ {salario:F2}");
        Console.WriteLine($"Percentual de aumento: {percentual}%");
        Console.WriteLine($"Valor do aumento: R$ {aumento:F2}");
        Console.WriteLine($"Novo salário: R$ {novoSalario:F2}");
    }
}
}
