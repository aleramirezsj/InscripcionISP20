using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Models
{
    public partial class InscripciondbContext : DbContext
    {
        public InscripciondbContext()
        {
        }

        public InscripciondbContext(DbContextOptions<InscripciondbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<Aniocarrera> Aniocarreras { get; set; }
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Ciclolectivo> Ciclolectivos { get; set; }
        public virtual DbSet<Inscripcion> Inscripcions { get; set; }
        public virtual DbSet<Materiaciclolectivo> Materiasciclolectivos { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseMySQL("Server=127.0.0.1;Database=inscripciondb;Uid=root;Pwd=milton;");
                optionsBuilder.UseMySql("Server=184.175.77.148;Database=smartsof_inscripciondb;Uid=smartsof_gestion2022;Pwd=gestion2022;", ServerVersion.AutoDetect("Server=184.175.77.148;Database=smartsof_inscripciondb;Uid=smartsof_gestion2022;Pwd=gestion2022;"),
                    options => options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: System.TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.ToTable("alumno");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ApellidoNombre)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dni)
                    .HasColumnType("int(11)")
                    .HasColumnName("DNI");
                   

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Aniocarrera>(entity =>
            {
                entity.ToTable("aniocarrera");

                entity.HasIndex(e => e.CarreraId1, "fk_AnioCarrera_Carrera1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CarreraId)
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarreraId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Carrera_Id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.CarreraId1Navigation)
                    .WithMany(p => p.Aniocarreras)
                    .HasForeignKey(d => d.CarreraId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AnioCarrera_Carrera1");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.ToTable("carrera");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Ciclolectivo>(entity =>
            {
                entity.ToTable("ciclolectivo");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Inscripcion>(entity =>
            {
                entity.ToTable("inscripcion");

                entity.HasIndex(e => e.AlumnoId1, "fk_Inscripcion_Alumno1_idx");

                entity.HasIndex(e => e.MateriasCicloLectivoId, "fk_Inscripcion_MateriasCicloLectivo1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AlumnoId)
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlumnoId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Alumno_Id");

                entity.Property(e => e.MateriaCicloLectivoId)
                    .HasColumnType("int(11)");

                entity.Property(e => e.MateriasCicloLectivoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MateriasCicloLectivo_Id");

                entity.HasOne(d => d.AlumnoId1Navigation)
                    .WithMany(p => p.Inscripcions)
                    .HasForeignKey(d => d.AlumnoId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Inscripcion_Alumno1");

                entity.HasOne(d => d.MateriasCicloLectivo)
                    .WithMany(p => p.Inscripcions)
                    .HasForeignKey(d => d.MateriasCicloLectivoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Inscripcion_MateriasCicloLectivo1");
            });

            modelBuilder.Entity<Materiaciclolectivo>(entity =>
            {
                entity.ToTable("materiasciclolectivo");

                entity.HasIndex(e => e.CicloLectivoId1, "fk_MateriasCicloLectivo_CicloLectivo1_idx");

                entity.HasIndex(e => e.MateriaId1, "fk_MateriasCicloLectivo_Materia1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CicloLectivoId)
                    .HasColumnType("int(11)");

                entity.Property(e => e.CicloLectivoId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("CicloLectivo_Id");

                entity.Property(e => e.MateriaId)
                    .HasColumnType("int(11)");

                entity.Property(e => e.MateriaId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Materia_Id");

                entity.HasOne(d => d.CicloLectivoId1Navigation)
                    .WithMany(p => p.Materiasciclolectivos)
                    .HasForeignKey(d => d.CicloLectivoId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MateriasCicloLectivo_CicloLectivo1");

                entity.HasOne(d => d.MateriaId1Navigation)
                    .WithMany(p => p.Materiasciclolectivos)
                    .HasForeignKey(d => d.MateriaId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MateriasCicloLectivo_Materia1");
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.ToTable("materia");

                entity.HasIndex(e => e.AnioCarreraId1, "fk_Materia_AnioCarrera1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AnioCarreraId)
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnioCarreraId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("AnioCarrera_Id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.AnioCarreraId1Navigation)
                    .WithMany(p => p.Materias)
                    .HasForeignKey(d => d.AnioCarreraId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Materia_AnioCarrera1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
