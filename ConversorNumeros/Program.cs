using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumeros {
    class Program {
        static void Main(string[] args)
        {

            double salario = 1250.30;
            string salarioDigitos = salario.ToString("0.00");

            Console.WriteLine("Seu salário é " + salario.ToString("C2"));

            Console.WriteLine("Progradama finalizado, tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
