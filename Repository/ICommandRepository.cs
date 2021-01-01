using System.Collections.Generic;
using dotnetcore_command_saver.Models;

namespace dotnetcore_command_saver.Repository {
    
    public interface ICommandRepository
    {

        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);

    }
}