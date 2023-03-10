﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.Contexto;

#nullable disable

namespace Persistencia.migracion
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230310140411_migracion2")]
    partial class migracion2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Entidades.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadPaginas")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("Creadopor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editorial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TituloLibro")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Libros", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
