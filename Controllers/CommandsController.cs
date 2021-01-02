using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using dotnetcore_command_saver.DTOs;
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
        private readonly IMapper _mapper;

        public CommandsController(ICommandService commandService, IMapper mapper) {
            _commandService = commandService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands() {
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(_commandService.GetAllCommands()));
        }
        
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(Guid id) {
            try
            {
                var commandResponse = _commandService.GetCommandById(id);
                if (commandResponse != null) {
                    return Ok(_mapper.Map<CommandReadDto>(commandResponse));
                }

                return NotFound("Command Not Found!");
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return Problem(e.GetBaseException().ToString());
            }
        }
    }
}

