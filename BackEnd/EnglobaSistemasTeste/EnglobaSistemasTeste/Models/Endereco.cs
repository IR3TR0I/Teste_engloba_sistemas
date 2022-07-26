using System;
using System.Collections.Generic;

namespace EnglobaSistemasTeste.Models
{
    public partial class Endereco
    {
        public int IdEndereco { get; set; }
        public string Endereco1 { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public string? Complemento { get; set; }
        public string Bairro { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string? Referencia { get; set; }
    }
}
