using dotnetcore_command_saver.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnetcore_command_saver.Configuration {
    public class CommandConfiguration: IEntityTypeConfiguration<Command> {
        
        public void Configure(EntityTypeBuilder<Command> builder) {

            builder.HasData(
                new Command(System.Guid.NewGuid(), "Create Migration", "dotnet ef migrations add <MigrationName>", "EF Core 5.0"),
                new Command(System.Guid.NewGuid(), "Remove Last Migration", "dotnet ef migrations remove", "EF Core 5.0"),
                new Command(System.Guid.NewGuid(), "Update Migration", "dotnet ef database update", "EF Core 5.0"),
                new Command(System.Guid.NewGuid(), "How To Add Entity MySQl with .net core 5 package", "dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.0-alpha.2", "EF Core 5.0"),
                new Command(System.Guid.NewGuid(), "How To Add Automatic Migration Packages", "dotnet add package Microsoft.AspNetCore.Hosting.Abstractions --version 2.2.0", "EF Core 5.0")
            );
        }
    }
}