using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelo
{
    public class Empregado
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public long CodigoEndereco { get; set; }
        public int Status { get; set; }
        public string DataNascimento { get; set; }
        public string DataAdmissao { get; set; }
        public string DataDemissao { get; set; }
    }
}
