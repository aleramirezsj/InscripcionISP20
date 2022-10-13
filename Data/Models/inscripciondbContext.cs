using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Models
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
        public virtual DbSet<Materia> Materias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseMySQL("Server=127.0.0.1;Database=inscripciondb;Uid=root;Pwd=milton;");
                optionsBuilder.UseMySQL("Server=184.175.77.148;Database=smartsof_inscripciondb;Uid=smartsof_gestion2022;Pwd=gestion2022;");
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

                

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AlumnoId)
                    .HasColumnType("int(11)");

                

                

                

                

               
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
