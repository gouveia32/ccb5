using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelo
{
    public class TelefoneFornecedor
    {
        public long Id { get; set; }
        public string Telefone { get; set; }
        public long FornecedorId { get; set; }
        public int Status { get; set; }
    }
}
