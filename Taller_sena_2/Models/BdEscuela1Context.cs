using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Taller_sena_2.Models;

public partial class BdEscuela1Context : DbContext
{
    public BdEscuela1Context()
    {
    }

    public BdEscuela1Context(DbContextOptions<BdEscuela1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Hp_Pavilion-96\\SQLEXPRESS; database=bd_escuela1; integrated security=true;TrustServerCertificate=True;");
    */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.CarCod).HasName("PK__cargo__34FC28359EF36484");

            entity.ToTable("cargo");

            entity.Property(e => e.CarCod)
                .ValueGeneratedNever()
                .HasColumnName("car_cod");
            entity.Property(e => e.CarDes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("car_des");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuCod).HasName("PK__usuario__D8E8AEAC3A26B95A");

            entity.ToTable("usuario");

            entity.Property(e => e.UsuCod)
                .ValueGeneratedNever()
                .HasColumnName("usu_cod");
            entity.Property(e => e.CarCod).HasColumnName("car_cod");
            entity.Property(e => e.UsuNom)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("usu_nom");

            entity.HasOne(d => d.CarCodNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CarCod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuario__car_cod__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
