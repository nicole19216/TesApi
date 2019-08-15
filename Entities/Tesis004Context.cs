using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Entities.Models;

namespace Entities
{
    public partial class Tesis004Context : DbContext
    {
        public Tesis004Context()
        {
        }

        public Tesis004Context(DbContextOptions<Tesis004Context> options)
            : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual DbSet<tCategoria> tCategoria { get; set; }
        public virtual DbSet<tCategoriaProducto> tCategoriaProducto { get; set; }
        public virtual DbSet<tCliente> tCliente { get; set; }
        public virtual DbSet<tCompras> tCompras { get; set; }
        public virtual DbSet<tDetalleCompra> tDetalleCompra { get; set; }
        public virtual DbSet<tDireccion> tDireccion { get; set; }
        public virtual DbSet<tImagen> tImagen { get; set; }
        public virtual DbSet<tImpuesto> tImpuesto { get; set; }
        public virtual DbSet<tLotes> tLotes { get; set; }
        public virtual DbSet<tMarca> tMarca { get; set; }
        public virtual DbSet<tNumero> tNumero { get; set; }
        public virtual DbSet<tPerfil> tPerfil { get; set; }
        public virtual DbSet<tPersona> tPersona { get; set; }
        public virtual DbSet<tPresentacion> tPresentacion { get; set; }
        public virtual DbSet<tPrivilegio> tPrivilegio { get; set; }
        public virtual DbSet<tProducto> tProducto { get; set; }
        public virtual DbSet<tProveedor> tProveedor { get; set; }
        public virtual DbSet<tRepresentante> tRepresentante { get; set; }
        public virtual DbSet<tRol> tRol { get; set; }
        public virtual DbSet<tRolPerfil> tRolPerfil { get; set; }
        public virtual DbSet<tUbicacion> tUbicacion { get; set; }
        public virtual DbSet<tUsuario> tUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<tCategoria>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<tCategoriaProducto>(entity =>
            {
                entity.HasKey(e => new { e.IdCategoria, e.IdProducto });

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.tCategoriaProducto)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCategoriaProducto_tCategoria");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.tCategoriaProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCategoriaProducto_tProducto");
            });

            modelBuilder.Entity<tCliente>(entity =>
            {
                entity.Property(e => e.Tipo).IsUnicode(false);

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.tCliente)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tCliente_tPersona");
            });

            modelBuilder.Entity<tCompras>(entity =>
            {
                entity.Property(e => e.Factura).IsUnicode(false);

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.tCompras)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_tCompras_tProveedor");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.tCompras)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tCompras_tUsuario");
            });

            modelBuilder.Entity<tDetalleCompra>(entity =>
            {
                entity.HasKey(e => new { e.IdCompra, e.IdProducto });

                entity.Property(e => e.IdDetalleCompra).ValueGeneratedOnAdd();

                entity.Property(e => e.UnidadCompra).IsUnicode(false);

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.tDetalleCompra)
                    .HasForeignKey(d => d.IdCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDetalleCompra_tCompras");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.tDetalleCompra)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDetalleCompra_tProducto1");
            });

            modelBuilder.Entity<tDireccion>(entity =>
            {
                entity.Property(e => e.Departamento).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Municipio).IsUnicode(false);

                entity.Property(e => e.Pais).IsUnicode(false);

                entity.Property(e => e.Provincia).IsUnicode(false);

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.tDireccion)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tDireccion_tPersona");
            });

            modelBuilder.Entity<tImagen>(entity =>
            {
                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.tImagen)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tImagen_tProducto1");
            });

            modelBuilder.Entity<tImpuesto>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<tLotes>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.tLotes)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_tLotes_tProducto");
            });

            modelBuilder.Entity<tMarca>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<tNumero>(entity =>
            {
                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.tNumero)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tNumero_tPersona");
            });

            modelBuilder.Entity<tPerfil>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.HasOne(d => d.IdPrivilegioNavigation)
                    .WithMany(p => p.tPerfil)
                    .HasForeignKey(d => d.IdPrivilegio)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tPerfil_tPrivilegio");
            });

            modelBuilder.Entity<tPersona>(entity =>
            {
                entity.Property(e => e.Ci).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Nit).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<tPresentacion>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.tPresentacion)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tPresentacion_tProducto1");
            });

            modelBuilder.Entity<tPrivilegio>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<tProducto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK_tProducto_1");

                entity.Property(e => e.CodigoBarras).IsUnicode(false);

                entity.Property(e => e.CodigoRapido).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.HasOne(d => d.IdImagenNavigation)
                    .WithMany(p => p.tProducto)
                    .HasForeignKey(d => d.IdImagen)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tProducto_tImpuesto");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.tProducto)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tProducto_tMarca");

                entity.HasOne(d => d.IdUbicacionNavigation)
                    .WithMany(p => p.tProducto)
                    .HasForeignKey(d => d.IdUbicacion)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tProducto_tUbicacion");
            });

            modelBuilder.Entity<tProveedor>(entity =>
            {
                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.tProveedor)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tProveedor_tPersona");
            });

            modelBuilder.Entity<tRepresentante>(entity =>
            {
                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.tRepresentante)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_tRepresentante_tPersona");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.tRepresentante)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tRepresentante_tProveedor1");
            });

            modelBuilder.Entity<tRol>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<tRolPerfil>(entity =>
            {
                entity.HasKey(e => new { e.IdRol, e.IdPerfil })
                    .HasName("PK_tRolPerfil_1");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.tRolPerfil)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tRolPerfil_tPerfil");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.tRolPerfil)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tRolPerfil_tRol");
            });

            modelBuilder.Entity<tUbicacion>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<tUsuario>(entity =>
            {
                entity.Property(e => e.Contraseña).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.tUsuario)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tUsuario_tPersona");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.tUsuario)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tUsuario_tRol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}