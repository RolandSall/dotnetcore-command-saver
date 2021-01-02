﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetcore_command_saver.Repository;

namespace dotnetcore_command_saver.Migrations
{
    [DbContext(typeof(CommanderContext))]
    [Migration("20210102152101_InitialMigrationWithSeeds")]
    partial class InitialMigrationWithSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("dotnetcore_command_saver.Models.Command", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Line")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Objective")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Commands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a298cae7-3734-4448-9153-799399e7f0d9"),
                            Line = "dotnet ef migrations add <MigrationName>",
                            Objective = "Create Migration",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("e5c99419-879f-4ec4-8599-d4246a8ae8f4"),
                            Line = "dotnet ef migrations remove",
                            Objective = "Remove Last Migration",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("bfd082c9-d9ea-4167-bcc7-1380c2d90cb7"),
                            Line = "dotnet ef database update",
                            Objective = "Update Migration",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("4c3f5ae9-4976-4847-b025-0c2d24ad098f"),
                            Line = "dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.0-alpha.2",
                            Objective = "How To Add Entity MySQl with .net core 5 package",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("99f9bade-ce27-464e-91a4-5893cb77ee73"),
                            Line = "dotnet add package Microsoft.AspNetCore.Hosting.Abstractions --version 2.2.0",
                            Objective = "How To Add Automatic Migration Packages",
                            Platform = "EF Core 5.0"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}