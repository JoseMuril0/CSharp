namespace Polimorfismo.Funcionarios
{
    abstract public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public string Funcao { get; private set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario, string funcao)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            Funcao = funcao;
            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao();


        public abstract void AumentarSalario();
       
        public override string ToString()
        {
            return "Dados do funcionario: \n" +
                "Nome: " + Nome + "\n" +
                "CPF: " + Cpf + "\n" +
                "Salario: " + Salario.ToString("C2") + "\n" +
                "Função: " + Funcao + "\n" +
                "---------------------------------";
        }

    }
}
