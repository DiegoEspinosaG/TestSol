using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestSol_API.ModelsTestSol;

public partial class TestSolContext : DbContext
{
    public TestSolContext()
    {
    }

    public TestSolContext(DbContextOptions<TestSolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CABRIPC\\SQLEXPRESS; Database=TestSol; Trusted_Connection=True;Trust Server Certificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.Property(e => e.AreaId)
                .HasMaxLength(50)
                .HasColumnName("AreaID");
            entity.Property(e => e.Area1)
                .HasMaxLength(50)
                .HasColumnName("Area");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.Property(e => e.EmpleadoId)
                .HasMaxLength(50)
                .HasColumnName("EmpleadoID");
            entity.Property(e => e.ApellidoMaterno).HasMaxLength(50);
            entity.Property(e => e.ApellidoPaterno).HasMaxLength(50);
            entity.Property(e => e.AreaId)
                .HasMaxLength(50)
                .HasColumnName("AreaID");
            entity.Property(e => e.CreadoPor).HasMaxLength(50);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.Area).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_Empleados_Areas");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
