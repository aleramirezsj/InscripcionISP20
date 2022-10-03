using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Data.Models
{
    public partial class Materia
    {
        public Materia()
        {
            Materiasciclolectivos = new HashSet<Materiaciclolectivo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? AnioCarreraId { get; set; }
        public int AnioCarreraId1 { get; set; }
        [DisplayName("Año y Carrera")]
        public virtual Aniocarrera AnioCarreraId1Navigation { get; set; }
        public virtual ICollection<Materiaciclolectivo> Materiasciclolectivos { get; set; }
    }
}
