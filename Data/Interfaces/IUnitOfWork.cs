using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface IUnitOfWork
    {
        GenericRepository<Alumno> AlumnoRepository { get; }
        GenericRepository<Aniocarrera> AniocarreraRepository { get; }
        GenericRepository<Carrera> CarreraRepository { get; }
        GenericRepository<Ciclolectivo> CiclolectivoRepository { get; }
        GenericRepository<Inscripcion> InscripcionRepository { get; }
        GenericRepository<Materia> MateriaRepository { get; }
        GenericRepository<Materiaciclolectivo> MateriaciclolectivoRepository { get; }
        public void Save();
        void Dispose();
    }
}
