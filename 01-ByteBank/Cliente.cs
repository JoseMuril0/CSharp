using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank {
    class Cliente {
        public string nome;
        public string cpf;
        public string profissao;

        public override string ToString()
        {
            return "-x-\nDados do cliente: \n" +
                "Nome: " + this.nome +
                "\nCPF: " + this.cpf +
                "\nPROFISSÃO: " + this.profissao + "\n-x-\n";
        }
    }
}
