using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetcore_command_saver.Migrations
{
    public partial class AdditionalInitialSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("4c3f5ae9-4976-4847-b025-0c2d24ad098f"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("99f9bade-ce27-464e-91a4-5893cb77ee73"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("a298cae7-3734-4448-9153-799399e7f0d9"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("bfd082c9-d9ea-4167-bcc7-1380c2d90cb7"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("e5c99419-879f-4ec4-8599-d4246a8ae8f4"));

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Line", "Objective", "Platform" },
                values: new object[,]
                {
                    { new Guid("2ed90ae5-dd1a-461d-ad13-5c1db2382719"), "dotnet ef migrations add <MigrationName>", "Create Migration", "EF Core 5.0" },
                    { new Guid("d947f503-0ea0-4fa6-9837-596bf1442faa"), "dotnet ef migrations remove", "Remove Last Migration", "EF Core 5.0" },
                    { new Guid("1f929bb1-c090-4179-860f-e29076b875af"), "dotnet ef database update", "Update Migration", "EF Core 5.0" },
                    { new Guid("4302bfad-3654-415e-8fa8-1b9693b3a184"), "dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.0-alpha.2", "How To Add Entity MySQl with .net core 5 package", "EF Core 5.0" },
                    { new Guid("f3db2cc7-1b9b-4b9d-b6ec-5437cd700973"), "dotnet add package Microsoft.AspNetCore.Hosting.Abstractions --version 2.2.0", "How To Add Automatic Migration Packages", "EF Core 5.0" },
                    { new Guid("0d5b1696-9d9d-43bc-a0b0-d38d93364074"), "dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 8.1.0", "How To Add Auto-Mappers", ".Net Core 5.0" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("0d5b1696-9d9d-43bc-a0b0-d38d93364074"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("1f929bb1-c090-4179-860f-e29076b875af"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("2ed90ae5-dd1a-461d-ad13-5c1db2382719"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("4302bfad-3654-415e-8fa8-1b9693b3a184"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("d947f503-0ea0-4fa6-9837-596bf1442faa"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("f3db2cc7-1b9b-4b9d-b6ec-5437cd700973"));

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
    }
}
