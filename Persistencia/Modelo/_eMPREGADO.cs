using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelo
{
    public class _Empregado
    {
        public string nome { get; set; }
        public string funcao { get; set; }
        public DateTime? nascimento { get; set; }
        public DateTime? admissao { get; set; }
        public DateTime? demissao { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string telefone3 { get; set; }
        public string email { get; set; }

    }
}
