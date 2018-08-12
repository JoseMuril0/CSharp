using System;

namespace Polimorfismo.Funcionarios
{
    public class Programador : Funcionario
    {

        public string Cetor { get; set; }

        public Programador(string nome, string cpf, string cetor) : base(nome, cpf, 3500, "Programador")
        { Cetor = cetor; } 

        public override void AumentarSalario()
        {
            Salario *= 1.20;
        }

        public override double GetBonificacao()
        {
            Console.WriteLine("Em cima desse salário: R$ "+base.Salario +
                " Ocorrerá a Bonificação: \nDe 10%:");
            return Salario *= 1.10;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                " CETOR: " + Cetor + "\n" +
                "---------------------------------" ;
        }
    }
}
