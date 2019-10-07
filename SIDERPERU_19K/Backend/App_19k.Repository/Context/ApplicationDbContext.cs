using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using App_19k.Domain;
namespace App_19k.Repository.Context
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Entrega> Entregas { get; set; }
        public virtual DbSet<Administrador> Administradores{ get; set; }
        public virtual DbSet<DetalleSuministro> DetalleSuministros { get; set; }
        public virtual DbSet<Distribuidor> Distribuidores { get; set; }
        public virtual DbSet<Distrito> Distritos { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<Suministro> Suministros { get; set; }
        public virtual DbSet<Vendedor> Vendedores { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        if (!optionsBuilder.IsConfigured)
        //        {
        //            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //            optionsBuilder.UseSqlServer("Repository Source=localhost;Initial Catalog=App_19k;Persist Security Info=True;User ID=sa;Password=sa");
        //        }
        //    }
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder
        //                        .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
        //                        .HasAnnotation("Relational:MaxIdentifierLength", 128)
        //                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //        modelBuilder.Entity("App_19k.Domain.Departamento", b =>
        //        {
        //            b.Property<int>("DepartamentoId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //            b.Property<string>("NDepartamento");

        //            b.HasKey("DepartamentoId");

        //            b.ToTable("Departamentos");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.DetalleSuministro", b =>
        //        {
        //            b.Property<int>("DetalleSuministroId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //            b.Property<int>("NumCantidad");

        //            b.Property<int>("ProyectoId");

        //            b.Property<int>("SuministroId");

        //            b.Property<string>("TTipoCantidad");

        //            b.HasKey("DetalleSuministroId");

        //            b.HasIndex("ProyectoId");

        //            b.ToTable("DetalleSuministros");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Distribuidor", b =>
        //        {
        //            b.Property<int>("DistribuidorId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //            b.Property<string>("NDistribuidor");

        //            b.Property<string>("TEjecutivoComercial");

        //            b.HasKey("DistribuidorId");

        //            b.ToTable("Distribuidores");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Distrito", b =>
        //        {
        //            b.Property<int>("DistritoId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //            b.Property<string>("NDistrito");

        //            b.Property<int>("ProvinciaId");

        //            b.HasKey("DistritoId");

        //            b.HasIndex("ProvinciaId");

        //            b.ToTable("Distritos");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Provincia", b =>
        //        {
        //            b.Property<int>("ProvinciaId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);


        //            b.Property<int?>("DepartamentoId");

        //            b.Property<string>("NProvincia");

        //            b.HasKey("ProvinciaId");

        //            b.HasIndex("DepartamentoId");

        //            b.ToTable("Provincias");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Proyecto", b =>
        //        {
        //            b.Property<int>("ProyectoId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //            b.Property<DateTime>("DFechaFinalObra");

        //            b.Property<DateTime>("DInicioSuministro");

        //            b.Property<int>("DistritoId");

        //            b.Property<decimal>("MPrecioSolicitado");

        //            b.Property<string>("NConstructora");

        //            b.Property<string>("NProyecto");

        //            b.Property<decimal>("NumArea");

        //            b.Property<long>("NumLicencia");

        //            b.Property<int>("NumTiempoSuministro");

        //            b.Property<string>("TActividadEconomicaEmpresa");

        //            b.Property<string>("TDireccion");

        //            b.Property<string>("TEstatusProyecto");

        //            b.Property<string>("TMarcaProveedorActual");

        //            b.Property<string>("TRucConstructora");

        //            b.Property<string>("TTipoInversion");

        //            b.Property<string>("TTipoSolicitud");

        //            b.Property<int>("VendedorId");

        //            b.HasKey("ProyectoId");

        //            b.HasIndex("DistritoId");

        //            b.HasIndex("VendedorId");

        //            b.ToTable("Proyectos");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Suministro", b =>
        //        {
        //            b.Property<int>("SuministroId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //            b.Property<string>("NSuministro");

        //            b.HasKey("SuministroId");

        //            b.ToTable("Suministros");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Usuario", b =>
        //        {
        //            b.Property<int>("UsuarioId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //            b.Property<string>("TPassword");

        //            b.Property<string>("TUserName");

        //            b.HasKey("UsuarioId");

        //            b.ToTable("Usuarios");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Vendedor", b =>
        //        {
        //            b.Property<int>("VendedorId")
        //                .ValueGeneratedOnAdd()
        //                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //            b.Property<int>("DistribuidorId");

        //            b.Property<string>("NVendedor");

        //            b.Property<string>("TDni");

        //            b.Property<string>("TEstado");

        //            b.Property<int>("UsuarioId");

        //            b.HasKey("VendedorId");

        //            b.HasIndex("DistribuidorId");

        //            b.HasIndex("UsuarioId");

        //            b.ToTable("Vendedores");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.DetalleSuministro", b =>
        //        {
        //            b.HasOne("App_19k.Domain.Proyecto", "Proyecto")
        //                .WithMany()
        //                .HasForeignKey("ProyectoId")
        //                .OnDelete(DeleteBehavior.Cascade);
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Distrito", b =>
        //        {
        //            b.HasOne("App_19k.Domain.Provincia", "Provincia")
        //                .WithMany()
        //                .HasForeignKey("ProvinciaId")
        //                .OnDelete(DeleteBehavior.Cascade);
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Provincia", b =>
        //        {
        //            b.HasOne("App_19k.Domain.Departamento", "Departamento")
        //                .WithMany()
        //                .HasForeignKey("DepartamentoId");
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Proyecto", b =>
        //        {
        //            b.HasOne("App_19k.Domain.Distrito", "Distrito")
        //                .WithMany()
        //                .HasForeignKey("DistritoId")
        //                .OnDelete(DeleteBehavior.Cascade);

        //            b.HasOne("App_19k.Domain.Vendedor", "Vendedor")
        //                .WithMany()
        //                .HasForeignKey("VendedorId")
        //                .OnDelete(DeleteBehavior.Cascade);
        //        });

        //        modelBuilder.Entity("App_19k.Domain.Vendedor", b =>
        //        {
        //            b.HasOne("App_19k.Domain.Distribuidor", "Distribuidor")
        //                .WithMany()
        //                .HasForeignKey("DistribuidorId")
        //                .OnDelete(DeleteBehavior.Cascade);

        //            b.HasOne("App_19k.Domain.Usuario", "Usuario")
        //                .WithMany()
        //                .HasForeignKey("UsuarioId")
        //                .OnDelete(DeleteBehavior.Cascade);
        //        });
        //    }




        //}


    }
}
