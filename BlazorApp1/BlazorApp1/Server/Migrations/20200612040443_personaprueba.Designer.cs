﻿// <auto-generated />
using System;
using BlazorApp1.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp1.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200612040443_personaprueba")]
    partial class personaprueba
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorApp1.Shared.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Entidades.GeneroPelicula", b =>
                {
                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("GeneroId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("GenerosPeliculas");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EnCartelera")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Lanzamiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resumen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Entidades.PeliculaActor", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PeliculaId", "PersonaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("PeliculasActores");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1000"
                        },
                        new
                        {
                            Id = 1001,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1001"
                        },
                        new
                        {
                            Id = 1002,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1002"
                        },
                        new
                        {
                            Id = 1003,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1003"
                        },
                        new
                        {
                            Id = 1004,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1004"
                        },
                        new
                        {
                            Id = 1005,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1005"
                        },
                        new
                        {
                            Id = 1006,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1006"
                        },
                        new
                        {
                            Id = 1007,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1007"
                        },
                        new
                        {
                            Id = 1008,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1008"
                        },
                        new
                        {
                            Id = 1009,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1009"
                        },
                        new
                        {
                            Id = 1010,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1010"
                        },
                        new
                        {
                            Id = 1011,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1011"
                        },
                        new
                        {
                            Id = 1012,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1012"
                        },
                        new
                        {
                            Id = 1013,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1013"
                        },
                        new
                        {
                            Id = 1014,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1014"
                        },
                        new
                        {
                            Id = 1015,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1015"
                        },
                        new
                        {
                            Id = 1016,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1016"
                        },
                        new
                        {
                            Id = 1017,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1017"
                        },
                        new
                        {
                            Id = 1018,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1018"
                        },
                        new
                        {
                            Id = 1019,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1019"
                        },
                        new
                        {
                            Id = 1020,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1020"
                        },
                        new
                        {
                            Id = 1021,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1021"
                        },
                        new
                        {
                            Id = 1022,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1022"
                        },
                        new
                        {
                            Id = 1023,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1023"
                        },
                        new
                        {
                            Id = 1024,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1024"
                        },
                        new
                        {
                            Id = 1025,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1025"
                        },
                        new
                        {
                            Id = 1026,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1026"
                        },
                        new
                        {
                            Id = 1027,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1027"
                        },
                        new
                        {
                            Id = 1028,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1028"
                        },
                        new
                        {
                            Id = 1029,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1029"
                        },
                        new
                        {
                            Id = 1030,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1030"
                        },
                        new
                        {
                            Id = 1031,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1031"
                        },
                        new
                        {
                            Id = 1032,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1032"
                        },
                        new
                        {
                            Id = 1033,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1033"
                        },
                        new
                        {
                            Id = 1034,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1034"
                        },
                        new
                        {
                            Id = 1035,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1035"
                        },
                        new
                        {
                            Id = 1036,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1036"
                        },
                        new
                        {
                            Id = 1037,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1037"
                        },
                        new
                        {
                            Id = 1038,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1038"
                        },
                        new
                        {
                            Id = 1039,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1039"
                        },
                        new
                        {
                            Id = 1040,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1040"
                        },
                        new
                        {
                            Id = 1041,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1041"
                        },
                        new
                        {
                            Id = 1042,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1042"
                        },
                        new
                        {
                            Id = 1043,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1043"
                        },
                        new
                        {
                            Id = 1044,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1044"
                        },
                        new
                        {
                            Id = 1045,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1045"
                        },
                        new
                        {
                            Id = 1046,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1046"
                        },
                        new
                        {
                            Id = 1047,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1047"
                        },
                        new
                        {
                            Id = 1048,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1048"
                        },
                        new
                        {
                            Id = 1049,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1049"
                        },
                        new
                        {
                            Id = 1050,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1050"
                        },
                        new
                        {
                            Id = 1051,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1051"
                        },
                        new
                        {
                            Id = 1052,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1052"
                        },
                        new
                        {
                            Id = 1053,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1053"
                        },
                        new
                        {
                            Id = 1054,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1054"
                        },
                        new
                        {
                            Id = 1055,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1055"
                        },
                        new
                        {
                            Id = 1056,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1056"
                        },
                        new
                        {
                            Id = 1057,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1057"
                        },
                        new
                        {
                            Id = 1058,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1058"
                        },
                        new
                        {
                            Id = 1059,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1059"
                        },
                        new
                        {
                            Id = 1060,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1060"
                        },
                        new
                        {
                            Id = 1061,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1061"
                        },
                        new
                        {
                            Id = 1062,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1062"
                        },
                        new
                        {
                            Id = 1063,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1063"
                        },
                        new
                        {
                            Id = 1064,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1064"
                        },
                        new
                        {
                            Id = 1065,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1065"
                        },
                        new
                        {
                            Id = 1066,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1066"
                        },
                        new
                        {
                            Id = 1067,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1067"
                        },
                        new
                        {
                            Id = 1068,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1068"
                        },
                        new
                        {
                            Id = 1069,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1069"
                        },
                        new
                        {
                            Id = 1070,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1070"
                        },
                        new
                        {
                            Id = 1071,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1071"
                        },
                        new
                        {
                            Id = 1072,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1072"
                        },
                        new
                        {
                            Id = 1073,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1073"
                        },
                        new
                        {
                            Id = 1074,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1074"
                        },
                        new
                        {
                            Id = 1075,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1075"
                        },
                        new
                        {
                            Id = 1076,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1076"
                        },
                        new
                        {
                            Id = 1077,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1077"
                        },
                        new
                        {
                            Id = 1078,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1078"
                        },
                        new
                        {
                            Id = 1079,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1079"
                        },
                        new
                        {
                            Id = 1080,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1080"
                        },
                        new
                        {
                            Id = 1081,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1081"
                        },
                        new
                        {
                            Id = 1082,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1082"
                        },
                        new
                        {
                            Id = 1083,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1083"
                        },
                        new
                        {
                            Id = 1084,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1084"
                        },
                        new
                        {
                            Id = 1085,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1085"
                        },
                        new
                        {
                            Id = 1086,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1086"
                        },
                        new
                        {
                            Id = 1087,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1087"
                        },
                        new
                        {
                            Id = 1088,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1088"
                        },
                        new
                        {
                            Id = 1089,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1089"
                        },
                        new
                        {
                            Id = 1090,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1090"
                        },
                        new
                        {
                            Id = 1091,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1091"
                        },
                        new
                        {
                            Id = 1092,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1092"
                        },
                        new
                        {
                            Id = 1093,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1093"
                        },
                        new
                        {
                            Id = 1094,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1094"
                        },
                        new
                        {
                            Id = 1095,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1095"
                        },
                        new
                        {
                            Id = 1096,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1096"
                        },
                        new
                        {
                            Id = 1097,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1097"
                        },
                        new
                        {
                            Id = 1098,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1098"
                        },
                        new
                        {
                            Id = 1099,
                            FechaNacimiento = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Nombre = "Persona 1099"
                        });
                });

            modelBuilder.Entity("BlazorApp1.Shared.Entidades.GeneroPelicula", b =>
                {
                    b.HasOne("BlazorApp1.Shared.Entidades.Genero", "Genero")
                        .WithMany("GeneroPeliculas")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp1.Shared.Entidades.Pelicula", "Pelicula")
                        .WithMany("GenerosPelicula")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorApp1.Shared.Entidades.PeliculaActor", b =>
                {
                    b.HasOne("BlazorApp1.Shared.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasActor")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp1.Shared.Entidades.Persona", "Persona")
                        .WithMany("PeliculasActor")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
