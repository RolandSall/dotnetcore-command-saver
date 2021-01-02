using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using dotnetcore_command_saver.Models;

namespace dotnetcore_command_saver.Repository {
    
    public class CommandRepository : ICommandRepository
    {

        private readonly CommandContext _commandContext;

        public CommandRepository(CommandContext commandContext)
        {
            _commandContext = commandContext;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _commandContext.Commands.ToList();
        }

        public Command GetCommandById(Guid id)
        {
            return _commandContext.Commands.FirstOrDefault(command => command.Id.Equals(id));
        }
    }
}