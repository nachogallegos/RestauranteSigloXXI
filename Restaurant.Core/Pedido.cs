﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core
{
    public  class Pedido
    {
        public int IdPedido { get; set; }

        public int IdMesa { get; set; }

        public string IdEstadoMesa { get; set; }

        public DateTime fecha { get; set; } 

        public int subtotal { get; set; }

        public int propina { get; set; }

        public int total { get; set; }

    }
}
