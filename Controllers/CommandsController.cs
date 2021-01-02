using System;
using System.Collections;
using System.Collections.Generic;
using dotnetcore_command_saver.Models;
using dotnetcore_command_saver.Repository;
using dotnetcore_command_saver.Services.CommandService;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_command_saver.Controllers {
    
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommandService _commandService;
        public CommandsController(ICommandService commandService) {
            _commandService = commandService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands() {
            return Ok(_commandService.GetAllCommands());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(Guid id) {
            try {
                return Ok(_commandService.GetCommandById(id));  
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return NotFound(e.GetBaseException());
            }
        }
    }
}

