using System.Collections;
using System.Collections.Generic;
using dotnetcore_command_saver.Models;
using dotnetcore_command_saver.Repository;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_command_saver.Controllers {
    
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommandRepository _commandRepository;
        public CommandsController(ICommandRepository commandRepository) {
            _commandRepository = commandRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            return Ok(_commandRepository.GetAppCommands());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) {
            return Ok(_commandRepository.GetCommandById(id));  
        }
    }
}

