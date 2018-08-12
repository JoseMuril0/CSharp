using System;
using Polimorfismo.Funcionarios;
using Polimorfismo.Sistemas;


namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();

            Console.ReadLine();
            
        }

        public static void UsarSistema()
        {
            Programador matheus = new Programador("Matheus neon", "892.322.372-39", "Web");
            Diretor marco = new Diretor("Marco Reus", "834.422.334-13", "Geral");
            marco.Senha = "123";

            SistemaInterno.Logar(marco, "222");

            Console.WriteLine(matheus);
        }
    }
}
