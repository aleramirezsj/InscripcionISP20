using Data.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private InscripciondbContext context = new InscripciondbContext();
        private GenericRepository<Alumno> alumnoRepository;
        private GenericRepository<Aniocarrera> aniocarreraRepository;
        private GenericRepository<Carrera> carreraRepository;
        private GenericRepository<Ciclolectivo> ciclolectivoRepository;
        private GenericRepository<Inscripcion> inscripcionRepository;
        private GenericRepository<Materia> materiaRepository;
        private GenericRepository<Materiaciclolectivo> materiaciclolectivoRepository;


        public GenericRepository<Alumno> AlumnoRepository
        {
            get
            {

                if (this.alumnoRepository == null)
                {
                    this.alumnoRepository = new GenericRepository<Alumno>(context);
                }
                return alumnoRepository;
            }
        }
        public GenericRepository<Aniocarrera> AniocarreraRepository
        {
            get
            {

                if (this.aniocarreraRepository == null)
                {
                    this.aniocarreraRepository = new GenericRepository<Aniocarrera>(context);
                }
                return aniocarreraRepository;
            }
        }
        public GenericRepository<Carrera> CarreraRepository
        {
            get
            {

                if (this.carreraRepository == null)
                {
                    this.carreraRepository = new GenericRepository<Carrera>(context);
                }
                return carreraRepository;
            }
        }

        public GenericRepository<Ciclolectivo> CiclolectivoRepository
        {
            get
            {

                if (this.ciclolectivoRepository == null)
                {
                    this.ciclolectivoRepository = new GenericRepository<Ciclolectivo>(context);
                }
                return ciclolectivoRepository;
            }
        }
        public GenericRepository<Inscripcion> InscripcionRepository
        {
            get
            {

                if (this.inscripcionRepository == null)
                {
                    this.inscripcionRepository = new GenericRepository<Inscripcion>(context);
                }
                return inscripcionRepository;
            }
        }
        public GenericRepository<Materia> MateriaRepository
        {
            get
            {

                if (this.materiaRepository == null)
                {
                    this.materiaRepository = new GenericRepository<Materia>(context);
                }
                return materiaRepository;
            }
        }
        public GenericRepository<Materiaciclolectivo> MateriaciclolectivoRepository
        {
            get
            {

                if (this.materiaciclolectivoRepository == null)
                {
                    this.materiaciclolectivoRepository = new GenericRepository<Materiaciclolectivo>(context);
                }
                return materiaciclolectivoRepository;
            }
        }
 


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
