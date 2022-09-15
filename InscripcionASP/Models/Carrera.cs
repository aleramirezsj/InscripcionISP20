using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Aniocarreras = new HashSet<Aniocarrera>();
        }
        [DisplayName("Código")]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Aniocarrera> Aniocarreras { get; set; }
    }
}
