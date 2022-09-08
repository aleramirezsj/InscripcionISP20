using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Ciclolectivo
    {
        public Ciclolectivo()
        {
            Materiasciclolectivos = new HashSet<Materiaciclolectivo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Materiaciclolectivo> Materiasciclolectivos { get; set; }
    }
}
