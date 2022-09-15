using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Inscripcion
    {
        public int Id { get; set; }
        public int? AlumnoId { get; set; }
        public int? MateriaCicloLectivoId { get; set; }
        public int AlumnoId1 { get; set; }
        public int MateriasCicloLectivoId { get; set; }

        public virtual Alumno AlumnoId1Navigation { get; set; }
        public virtual Materiaciclolectivo MateriasCicloLectivo { get; set; }
    }
}
