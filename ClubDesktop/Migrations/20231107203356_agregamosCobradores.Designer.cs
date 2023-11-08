﻿// <auto-generated />
using ClubDesktop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClubDesktop.Migrations
{
    [DbContext(typeof(ClubDesktopContext))]
    [Migration("20231107203356_agregamosCobradores")]
    partial class agregamosCobradores
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClubDesktop.Models.Actividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Horarios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actividades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Costo = 2500m,
                            Horarios = "Lunes y miércoles 20hs",
                            Nombre = "Ajedrez"
                        },
                        new
                        {
                            Id = 2,
                            Costo = 2000m,
                            Horarios = "Martes y Jueves 20hs",
                            Nombre = "Folklore"
                        });
                });

            modelBuilder.Entity("ClubDesktop.Models.Cobrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cobradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Oscar Rodriguez"
                        });
                });

            modelBuilder.Entity("ClubDesktop.Models.Socio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApellidoNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Socios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApellidoNombre = "Juan Perez",
                            Dirección = "9 de julio 2323",
                            Teléfono = "123456"
                        },
                        new
                        {
                            Id = 2,
                            ApellidoNombre = "Fulano DeTal",
                            Dirección = "Av Iriondo 2123",
                            Teléfono = "345678"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
