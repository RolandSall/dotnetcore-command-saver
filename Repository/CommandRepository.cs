using System.Collections.Generic;
using System.ComponentModel;
using dotnetcore_command_saver.Models;

namespace dotnetcore_command_saver.Repository {
    
    public class CommandRepository : ICommandRepository{
        public IEnumerable<Command> GetAppCommands() {
            var cmd = new Command(System.Guid.NewGuid(),"Desc", "Line", "Platform");
            var commands = new List<Command> {cmd, cmd};
            return commands;
        }

        public Command GetCommandById(int id)
        {
            var cmd = new Command(System.Guid.NewGuid(),"Desc", "Line", "Platform");
            return cmd;
        }
    }
}