using System.Collections.Generic;
using dotnetcore_command_saver.Models;
using dotnetcore_command_saver.Repository;

namespace dotnetcore_command_saver.Services.CommandService {
    
    public class CommandService: ICommandService {
        
        private readonly ICommandRepository _commandRepository;
        public CommandService(ICommandRepository commandRepository) {
            _commandRepository = commandRepository;
        }
        public IEnumerable<Command> GetAppCommands() {
            return _commandRepository.GetAppCommands();
        }

        public Command GetCommandById(int id) {
            return _commandRepository.GetCommandById(id);
        }
    }
}