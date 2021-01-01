using System.Collections.Generic;
using dotnetcore_command_saver.Models;

namespace dotnetcore_command_saver.Services.CommandService
{
    public interface ICommandService
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}