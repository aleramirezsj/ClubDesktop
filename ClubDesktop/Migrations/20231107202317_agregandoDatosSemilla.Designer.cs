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
    [Migration("20231107202317_agregandoDatosSemilla")]
    partial class agregandoDatosSemilla
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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