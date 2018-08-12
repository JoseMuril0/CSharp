using Polimorfismo.Sistemas;
using System;


namespace Polimorfismo.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public string Cetor { get; set; }

        public Diretor(string nome, string cpf, string cetor):base(nome, cpf, 10000.0, "Diretor")
        {
            Cetor = cetor;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.30;
        }
        public override double GetBonificacao()
        {
            Console.WriteLine("Em cima desse salário: R$ " + Salario +
             " Ocorrerá a Bonificação: \nDe 20%:");
            return Salario *= 1.20;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                " CETOR: " + Cetor + "\n" +
                "---------------------------------";
        }

    }
}
