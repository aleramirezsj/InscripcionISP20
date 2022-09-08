using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Aniocarrera
    {
        public Aniocarrera()
        {
            Materias = new HashSet<Materia>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? CarreraId { get; set; }
        public int CarreraId1 { get; set; }

        public virtual Carrera CarreraId1Navigation { get; set; }
        public virtual ICollection<Materia> Materias { get; set; }
    }
}
