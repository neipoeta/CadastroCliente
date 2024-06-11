using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Registro { get; set; }
        public string Telefone { get; set; }
        public int AnoNascimento { get; set; }
        public Endereco Endereco { get; set; }

        public string RetornaEnderecoString()
        {
            return Endereco.RetornaEnderecoString();
        }

    }
}
