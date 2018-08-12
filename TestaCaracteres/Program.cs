using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa - Testando Caracteres");

            char letra = 'a';
            Console.WriteLine(letra);

            letra = (char)66;
            Console.WriteLine(letra);

            char valor = (char)(65 + 30);
            Console.WriteLine(valor);

            Console.WriteLine("Programa finalizado com sucesso. Tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
