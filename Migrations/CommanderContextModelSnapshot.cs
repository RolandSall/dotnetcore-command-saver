﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetcore_command_saver.Repository;

namespace dotnetcore_command_saver.Migrations
{
    [DbContext(typeof(CommandContext))]
    partial class CommanderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("2ed90ae5-dd1a-461d-ad13-5c1db2382719"),
                            Line = "dotnet ef migrations add <MigrationName>",
                            Objective = "Create Migration",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("d947f503-0ea0-4fa6-9837-596bf1442faa"),
                            Line = "dotnet ef migrations remove",
                            Objective = "Remove Last Migration",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("1f929bb1-c090-4179-860f-e29076b875af"),
                            Line = "dotnet ef database update",
                            Objective = "Update Migration",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("4302bfad-3654-415e-8fa8-1b9693b3a184"),
                            Line = "dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.0-alpha.2",
                            Objective = "How To Add Entity MySQl with .net core 5 package",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("f3db2cc7-1b9b-4b9d-b6ec-5437cd700973"),
                            Line = "dotnet add package Microsoft.AspNetCore.Hosting.Abstractions --version 2.2.0",
                            Objective = "How To Add Automatic Migration Packages",
                            Platform = "EF Core 5.0"
                        },
                        new
                        {
                            Id = new Guid("0d5b1696-9d9d-43bc-a0b0-d38d93364074"),
                            Line = "dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 8.1.0",
                            Objective = "How To Add Auto-Mappers",
                            Platform = ".Net Core 5.0"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
