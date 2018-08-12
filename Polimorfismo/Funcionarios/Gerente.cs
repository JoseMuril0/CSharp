using System;

namespace Polimorfismo.Funcionarios
{
    public class Gerente : Funcionario
    {
        public string Cetor { get; set; }

        public Gerente(string nome, string cpf, string cetor) : base(nome, cpf, 6000, "Gerente")
        { Cetor = cetor; }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        
        public override double GetBonificacao()
        {
            Console.WriteLine("Em cima desse salário: R$ " + base.Salario +
                " Ocorrerá a Bonificação: \nDe 50%:");
            return Salario *= 1.50;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                " CETOR: " + Cetor + "\n" +
                "---------------------------------";
        }
    }
}
