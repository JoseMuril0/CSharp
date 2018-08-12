using Polimorfismo.Funcionarios;
using System;
using Polimorfismo.Sistemas;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Sistemas
{
    public abstract class SistemaInterno : Funcionario
    {
       
        public SistemaInterno(string nome, string cpf, double salario, string funcao)
            : base(nome, cpf, salario, funcao) { }

        public static bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema = )");
                return true;
            }
            Console.WriteLine("Login inválido");
            return false;

        }

    }
}
