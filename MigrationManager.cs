using System;
using dotnetcore_command_saver.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace dotnetcore_command_saver {
    
    public static class MigrationManager {

        public static IHost MigrateDatabase(this IHost host) {
            
            using (var scope = host.Services.CreateScope()) {
                
                using (var appContect = scope.ServiceProvider.GetRequiredService<CommandContext>()) {

                    try {
                            appContect.Database.Migrate();
                    }
                    catch (Exception e) {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }
            return host;
        }
    }
}