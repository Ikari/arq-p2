using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLibRestFrontEndMVC.Models
{
    public class ClienteViewModel
    {
        public object Id { get; set; }
        public string OuterId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Nascimento { get; set; }
        public string Telefone { get; set; }
    }
}
