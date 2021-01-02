using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetcore_command_saver.Migrations
{
    public partial class InitialMigrationWithSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Objective = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Line = table.Column<string>(type: "longtext", nullable: false),
                    Platform = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Line", "Objective", "Platform" },
                values: new object[,]
                {
                    { new Guid("a298cae7-3734-4448-9153-799399e7f0d9"), "dotnet ef migrations add <MigrationName>", "Create Migration", "EF Core 5.0" },
                    { new Guid("e5c99419-879f-4ec4-8599-d4246a8ae8f4"), "dotnet ef migrations remove", "Remove Last Migration", "EF Core 5.0" },
                    { new Guid("bfd082c9-d9ea-4167-bcc7-1380c2d90cb7"), "dotnet ef database update", "Update Migration", "EF Core 5.0" },
                    { new Guid("4c3f5ae9-4976-4847-b025-0c2d24ad098f"), "dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.0-alpha.2", "How To Add Entity MySQl with .net core 5 package", "EF Core 5.0" },
                    { new Guid("99f9bade-ce27-464e-91a4-5893cb77ee73"), "dotnet add package Microsoft.AspNetCore.Hosting.Abstractions --version 2.2.0", "How To Add Automatic Migration Packages", "EF Core 5.0" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commands");
        }
    }
}
