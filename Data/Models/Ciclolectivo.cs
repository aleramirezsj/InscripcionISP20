using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Ciclolectivo
    {
        public Ciclolectivo()
        {
           
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
