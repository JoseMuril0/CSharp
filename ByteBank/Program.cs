using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank {
    class Program {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.cliente.nome = "Murilo";
            conta.cliente.cpf = "893.382.938.02";
            conta.cliente.profissao = "Desenvolvedor .NET";



            Console.WriteLine("Programa finalizado, tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
