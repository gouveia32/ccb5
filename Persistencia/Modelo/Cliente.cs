﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelo
{
    public class Cliente
    {
        public long Id{get; set;}
        public string Email { get; set; }
        public long EnderecoId { get; set; }
        public int Status { get; set; }
    }
}
