﻿// <auto-generated />
using Bulky.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240608184448_CreateAgentTableToDB")]
    partial class CreateAgentTableToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAvailable = true,
                            Name = "Hugo",
                            Number = 1,
                            Team = "Coordenação"
                        },
                        new
                        {
                            Id = 2,
                            IsAvailable = true,
                            Name = "Marco",
                            Number = 1,
                            Team = "Coordenação"
                        },
                        new
                        {
                            Id = 5,
                            IsAvailable = true,
                            Name = "Giovani",
                            Number = 1,
                            Team = "Instrução"
                        },
                        new
                        {
                            Id = 6,
                            IsAvailable = true,
                            Name = "João",
                            Number = 1,
                            Team = "Coordenação"
                        },
                        new
                        {
                            Id = 7,
                            IsAvailable = true,
                            Name = "Cleiton",
                            Number = 1,
                            Team = "Sor 1"
                        },
                        new
                        {
                            Id = 8,
                            IsAvailable = true,
                            Name = "Davidson",
                            Number = 1,
                            Team = "Sor 2"
                        },
                        new
                        {
                            Id = 9,
                            IsAvailable = true,
                            Name = "Tharik",
                            Number = 1,
                            Team = "Sor 2"
                        },
                        new
                        {
                            Id = 10,
                            IsAvailable = true,
                            Name = "Ailton",
                            Number = 1,
                            Team = "Sor 1"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Comedy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}