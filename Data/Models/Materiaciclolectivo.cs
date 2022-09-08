using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Materiaciclolectivo
    {
        public Materiaciclolectivo()
        {
            Inscripcions = new HashSet<Inscripcion>();
        }

        public int Id { get; set; }
        public int? CicloLectivoId { get; set; }
        public int? MateriaId { get; set; }
        public int CicloLectivoId1 { get; set; }
        public int MateriaId1 { get; set; }

        public virtual Ciclolectivo CicloLectivoId1Navigation { get; set; }
        public virtual Materia MateriaId1Navigation { get; set; }
        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
