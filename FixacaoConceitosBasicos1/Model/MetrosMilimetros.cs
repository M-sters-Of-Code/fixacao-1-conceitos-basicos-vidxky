using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class MetrosMilimetros
    {
        public static void Executar()
        {
            Console.Write("Digite um valor em metros: ");
            double metros = Convert.ToDouble(Console.ReadLine());

            double milimetros = metros * 1000;

            Console.WriteLine($"{metros} metros equivalem a {milimetros} milímetros.");
        }
    }
}
