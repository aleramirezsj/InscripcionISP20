using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            Inscripcions = new HashSet<Inscripcion>();
        }

        public int Id { get; set; }
        public string ApellidoNombre { get; set; }
        public int? Dni { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
