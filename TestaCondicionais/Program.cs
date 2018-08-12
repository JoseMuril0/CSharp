using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCondicionais {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Testando Condicionais");

            int idade = 10, quatidadePessoas = 3;
            if (idade >= 18) {
                Console.WriteLine("Você é maior de 18, pode entrar!");
                Console.WriteLine("Seja bem vindo!");
            } else if(quatidadePessoas >= 2){
                Console.WriteLine("Você é menor de 18, mas está acompanhado, pode entrar!");
            } else {
                Console.WriteLine("Você é menor de 18, não pode entrar!");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
