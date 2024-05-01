﻿// <auto-generated />
using System;
using Investigation.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Investigation.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Investigation.Shared.Entities.Actividad_Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActividadesInvestigacionesId")
                        .HasColumnType("int");

                    b.Property<int?>("RecursosEspecializadossId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadesInvestigacionesId");

                    b.HasIndex("RecursosEspecializadossId");

                    b.ToTable("Actividad_Recursos");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.ActividadesInvestigacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProyectoInvestigacionesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoInvestigacionesId");

                    b.ToTable("ActividadesInvestigaciones");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.Investigador_Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("InvestigadoressId")
                        .HasColumnType("int");

                    b.Property<int?>("ProyectoInvestigacionesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvestigadoressId");

                    b.HasIndex("ProyectoInvestigacionesId");

                    b.ToTable("Investigador_Proyectos");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.Investigadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProyectoInvestigacionId")
                        .HasColumnType("int");

                    b.Property<string>("afiliacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("especialidad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoInvestigacionId");

                    b.ToTable("Investigadoress");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.ProyectoInvestigacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre_Proyecto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ProyectoInvestigaciones");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.Publicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProyectosInvestigacionesId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ProyectosInvestigacionesId");

                    b.ToTable("Publicaciones");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.RecursosEspecializados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActividadesInvestigacionId")
                        .HasColumnType("int");

                    b.Property<float>("CantRequerida")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Proveedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProyectosInvestigacionesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadesInvestigacionId");

                    b.HasIndex("ProyectosInvestigacionesId");

                    b.ToTable("RecursosEspecializados");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.Actividad_Recurso", b =>
                {
                    b.HasOne("Investigation.Shared.Entities.ActividadesInvestigacion", "ActividadesInvestigaciones")
                        .WithMany("Actividad_Recursos")
                        .HasForeignKey("ActividadesInvestigacionesId");

                    b.HasOne("Investigation.Shared.Entities.RecursosEspecializados", "RecursosEspecializadoss")
                        .WithMany()
                        .HasForeignKey("RecursosEspecializadossId");

                    b.Navigation("ActividadesInvestigaciones");

                    b.Navigation("RecursosEspecializadoss");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.ActividadesInvestigacion", b =>
                {
                    b.HasOne("Investigation.Shared.Entities.ProyectoInvestigacion", "ProyectoInvestigaciones")
                        .WithMany("ActividadesInvestigaciones")
                        .HasForeignKey("ProyectoInvestigacionesId");

                    b.Navigation("ProyectoInvestigaciones");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.Investigador_Proyecto", b =>
                {
                    b.HasOne("Investigation.Shared.Entities.Investigadores", "Investigadoress")
                        .WithMany()
                        .HasForeignKey("InvestigadoressId");

                    b.HasOne("Investigation.Shared.Entities.ProyectoInvestigacion", "ProyectoInvestigaciones")
                        .WithMany()
                        .HasForeignKey("ProyectoInvestigacionesId");

                    b.Navigation("Investigadoress");

                    b.Navigation("ProyectoInvestigaciones");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.Investigadores", b =>
                {
                    b.HasOne("Investigation.Shared.Entities.ProyectoInvestigacion", "ProyectoInvestigacion")
                        .WithMany()
                        .HasForeignKey("ProyectoInvestigacionId");

                    b.Navigation("ProyectoInvestigacion");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.Publicacion", b =>
                {
                    b.HasOne("Investigation.Shared.Entities.ProyectoInvestigacion", "ProyectosInvestigaciones")
                        .WithMany("Publicaciones")
                        .HasForeignKey("ProyectosInvestigacionesId");

                    b.Navigation("ProyectosInvestigaciones");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.RecursosEspecializados", b =>
                {
                    b.HasOne("Investigation.Shared.Entities.ActividadesInvestigacion", null)
                        .WithMany("RecursosEspecializados")
                        .HasForeignKey("ActividadesInvestigacionId");

                    b.HasOne("Investigation.Shared.Entities.ProyectoInvestigacion", "ProyectosInvestigaciones")
                        .WithMany("RecursosEspecializados")
                        .HasForeignKey("ProyectosInvestigacionesId");

                    b.Navigation("ProyectosInvestigaciones");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.ActividadesInvestigacion", b =>
                {
                    b.Navigation("Actividad_Recursos");

                    b.Navigation("RecursosEspecializados");
                });

            modelBuilder.Entity("Investigation.Shared.Entities.ProyectoInvestigacion", b =>
                {
                    b.Navigation("ActividadesInvestigaciones");

                    b.Navigation("Publicaciones");

                    b.Navigation("RecursosEspecializados");
                });
#pragma warning restore 612, 618
        }
    }
}
