using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelo
{
    public class TelefoneCliente
    {
        public long Id { get; set; }
        public string Telefone { get; set; }
        public long ClienteId { get; set; }
        public int Status { get; set; }
    }
}
