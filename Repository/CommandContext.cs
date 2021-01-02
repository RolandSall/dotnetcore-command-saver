using dotnetcore_command_saver.Configuration;
using dotnetcore_command_saver.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore_command_saver.Repository {
    
    public class CommandContext: DbContext {
        
        public CommandContext(DbContextOptions<CommandContext> options) : base(options) {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommandConfiguration());
        }

        public DbSet<Command> Commands { get; set; }
    }
}