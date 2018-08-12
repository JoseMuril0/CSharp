using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaEscopo {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Testando Escopo");

            double salario = 3300.0;

            if (salario >= 1900.00 && salario <= 2800.00) {
                Console.WriteLine("O IR é de 7.5% podemos deduzir na declaração no " +
                    "valor de R$ 142");
            } else if (salario > 2800.00 && salario <= 3751.0) {
                Console.WriteLine("O IR é de 15% podemos deduzir na declaração no " +
                    "valor de R$ 350");
            } else if (salario > 3751.00 && salario <= 4664.00) {
                Console.WriteLine("O IR é de 22.5% podemos deduzir na declaração no " +
                    "valor de R$ 636");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
