using System;
using System.Collections.Generic;

namespace EnglobaSistemasTeste.Models
{
    public partial class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public string Rg { get; set; } = null!;
        public string OrgaoEmissor { get; set; } = null!;
        public string TituloEleitor { get; set; } = null!;
        public string Cnh { get; set; } = null!;
        public bool Ativo { get; set; }
        public bool Gestor { get; set; }
    }
}
