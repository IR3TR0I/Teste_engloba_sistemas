using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EnglobaSistemasTeste.Models;

namespace EnglobaSistemasTeste.Contexts
{
    public partial class EnglobaContext : DbContext
    {
        public EnglobaContext()
        {
        }

        public EnglobaContext(DbContextOptions<EnglobaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Endereco> Enderecos { get; set; } = null!;
        public virtual DbSet<Funcionario> Funcionarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-B9BU4K8\\SQLEXPRESS; initial catalog=EnglobaSistemas; user Id=sa; pwd=senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.IdEndereco)
                    .HasName("PK__Endereco__0B7C7F17A3A0B6D1");

                entity.ToTable("Endereco");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Numero)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Referencia)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK__Funciona__35CB052AB95448E8");

                entity.ToTable("Funcionario");

                entity.HasIndex(e => e.Rg, "UQ__Funciona__321537C8B062319F")
                    .IsUnique();

                entity.HasIndex(e => e.TituloEleitor, "UQ__Funciona__946BD9C16BECADB3")
                    .IsUnique();

                entity.HasIndex(e => e.Cpf, "UQ__Funciona__C1F897310562E886")
                    .IsUnique();

                entity.HasIndex(e => e.Cnh, "UQ__Funciona__C1FF67759AC68B02")
                    .IsUnique();

                entity.Property(e => e.Ativo).HasColumnName("ATIVO");

                entity.Property(e => e.Cnh)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CNH")
                    .IsFixedLength();

                entity.Property(e => e.Cpf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.Gestor).HasColumnName("GESTOR");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrgaoEmissor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RG");

                entity.Property(e => e.TituloEleitor)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
