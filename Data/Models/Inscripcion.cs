using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Inscripcion
    {
        public int Id { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public int CicloLectivoId { get; set; }
        public Ciclolectivo CicloLectivo { get; set; }

    }
}
