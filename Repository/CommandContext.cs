using dotnetcore_command_saver.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore_command_saver.Repository {
    
    public class CommanderContext: DbContext {
        
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options) {
            
        }
        
        public DbSet<Command> Commands { get; set; }
    }
}