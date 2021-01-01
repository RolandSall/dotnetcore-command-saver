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

        private readonly CommandRepository _repository = new CommandRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            return Ok(_repository.GetAppCommands());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) {
            return Ok(_repository.GetCommandById(id));  
        }
    }
}

