using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisClinica.Classes
{
    public abstract class Pessoa
    {
        
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public int id { get; set; }
    }
}
