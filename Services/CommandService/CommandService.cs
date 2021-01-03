using System;
using System.Collections.Generic;
using AutoMapper;
using dotnetcore_command_saver.Models;
using dotnetcore_command_saver.Repository;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dotnetcore_command_saver.Services.CommandService {
    
    public class CommandService: ICommandService {
        

        private readonly ICommandRepository _commandRepository;
        public CommandService(ICommandRepository commandRepository) {
            _commandRepository = commandRepository;
        }
        public IEnumerable<Command> GetAllCommands() {
            return _commandRepository.GetAllCommands();
        }

        public Command GetCommandById(Guid id) {
            return _commandRepository.GetCommandById(id);
        }

        public Command CreateCommand(Command command) {
            if (command == null) {
                throw new ArgumentException(nameof(command));
            }
            command.Id = Guid.NewGuid();
            return _commandRepository.CreateCommand(command);
        }

        public void UpdateCommand(Command command) { 
            _commandRepository.UpdateCommand(command);
      
        }

        public void DeletedCommandById(Command command) {
            if (command == null) {
                throw new ArgumentException(nameof(command));
            }

            _commandRepository.DeletedCommandById(command);
        }
    }
}