using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor2 {
    class Program {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero: ");
            int Numero = int.Parse(Console.ReadLine());


            for (int i = Numero; i == Numero; i++) {
                for (int j = 0; j <= 10; j++) {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
            }

            Console.WriteLine("Programa finazilado, tecle ENTER para sair . . .");
            Console.ReadLine();
        }
    }
}
