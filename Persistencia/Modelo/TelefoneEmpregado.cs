using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelo
{
    public class TelefoneEmpregado
    {
        public long Id { get; set; }
        public string Telefone { get; set; }
        public long EmpregadoId { get; set; }
        public int Status { get; set; }
    }
}
