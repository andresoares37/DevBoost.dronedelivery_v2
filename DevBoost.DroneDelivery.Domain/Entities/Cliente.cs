using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.dronedelivery.Domain
{
    public class Cliente
    {
        public Cliente(){}
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

    }
}
