﻿// <auto-generated />
using System;
using Biblioteca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca.Data.Migrations
{
    [DbContext(typeof(bibliotecaDBContext))]
    partial class bibliotecaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteca.core.Liibros", b =>
                {
                    b.Property<int>("ID_libro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("ID_autor_libro")
                        .HasColumnType("int");

                    b.Property<int>("ID_estado")
                        .HasColumnType("int");

                    b.Property<int>("ID_idioma")
                        .HasColumnType("int");

                    b.Property<int>("ID_país")
                        .HasColumnType("int");

                    b.Property<int>("Idioma")
                        .HasColumnType("int");

                    b.Property<string>("Notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Paginas")
                        .HasColumnType("int");

                    b.Property<int>("Publicación")
                        .HasColumnType("int");

                    b.Property<string>("Resumen_del_documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Ubicación_física")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("editorial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pais")
                        .HasColumnType("int");

                    b.HasKey("ID_libro");

                    b.ToTable("Liibros");
                });

            modelBuilder.Entity("Prestamos.core.Prestams", b =>
                {
                    b.Property<int>("ID_prestamos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha_devolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_prestamo")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Estado")
                        .HasColumnType("int");

                    b.Property<int>("ID_libro")
                        .HasColumnType("int");

                    b.Property<int>("ID_usuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_prestamos");

                    b.ToTable("Prestams");
                });

            modelBuilder.Entity("Usuario.core.Users", b =>
                {
                    b.Property<int>("ID_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<int>("tardanzas")
                        .HasColumnType("int");

                    b.HasKey("ID_usuario");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
