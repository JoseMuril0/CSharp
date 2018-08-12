using Polimorfismo.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public Autenticavel(string nome, string cpf, double salario, string funcao)
            : base(nome, cpf, salario, funcao)
        { }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }


    }
}
