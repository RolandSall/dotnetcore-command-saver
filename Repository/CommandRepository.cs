﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using dotnetcore_command_saver.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dotnetcore_command_saver.Repository {
    
    public class CommandRepository : ICommandRepository {

        private readonly CommandContext _commandContext;

        public CommandRepository(CommandContext commandContext)
        {
            _commandContext = commandContext;
        }

        public void UpdateCommand(Command command)
        {
            _commandContext.SaveChanges();
        }

        public IEnumerable<Command> GetAllCommands() {
            return _commandContext.Commands.ToList();
        }

        public Command GetCommandById(Guid id) {
            return _commandContext.Commands.FirstOrDefault(command => command.Id.Equals(id));
        }

        public Command CreateCommand(Command command) {
            var commandResponse = _commandContext.Add(command).Entity;
            _commandContext.SaveChanges();
            return commandResponse;
        }

        public void DeletedCommandById(Command command) {
            _commandContext.Remove(command);
            _commandContext.SaveChanges();
        }
    }
}