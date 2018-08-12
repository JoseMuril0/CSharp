using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMult3 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa - Numeros multiplos de 3");
            for (int i = 0; i <= 100; i++) {
                if (i % 3 == 0) {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Programa finazilado, tecle ENTER para sair . . .");
            Console.ReadLine();
        }
    }
}
