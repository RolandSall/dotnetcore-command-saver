using System;
using System.Collections.Generic;
using dotnetcore_command_saver.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dotnetcore_command_saver.Repository {
    
    public interface ICommandRepository
    {

        void UpdateCommand(Command command);
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(Guid id);
        Command CreateCommand(Command command);
    }
}