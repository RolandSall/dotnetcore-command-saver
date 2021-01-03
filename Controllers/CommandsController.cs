using System;
using System.Collections.Generic;
using AutoMapper;
using dotnetcore_command_saver.DTOs.CommandDTOs;
using dotnetcore_command_saver.Models;
using dotnetcore_command_saver.Services.CommandService;
using Microsoft.AspNetCore.JsonPatch;
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
        
        [HttpGet("{id}", Name="GetCommandById")]
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

        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto) {
            var command = GetCommandFromRequest(commandCreateDto);
            var commandReadDto = GetCommandReadDtoFromDbResponse(command);
            return CreatedAtRoute(nameof(GetCommandById), new {commandReadDto.Id}, commandReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCommand(Guid id, CommandUpdateDto commandUpdateDto)
        {
            var commandToBeUpdated = _commandService.GetCommandById(id);
            if (commandToBeUpdated == null)
            {
                return NotFound("Command Not Found!");
            }
            _mapper.Map(commandUpdateDto, commandToBeUpdated);
            _commandService.UpdateCommand(commandToBeUpdated);
            return NoContent();
        }

  
        
        [HttpPatch("{id}")]
        public ActionResult PathUpdateCommand(Guid id, JsonPatchDocument<CommandUpdateDto> patchDocument) {
            var commandToBeUpdated = _commandService.GetCommandById(id);
            if (commandToBeUpdated == null)
            {
                return NotFound("Command Not Found!");
            }

            var commandToBePatched = _mapper.Map<CommandUpdateDto>(commandToBeUpdated);
            patchDocument.ApplyTo(commandToBePatched, ModelState);
            if (!TryValidateModel(commandToBePatched))
            {
                return ValidationProblem(ModelState);
            }
            
            _mapper.Map(commandToBePatched, commandToBeUpdated);
            _commandService.UpdateCommand(commandToBeUpdated);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletedCommandById(Guid id) {
            var commandToBeUpdated = _commandService.GetCommandById(id);
            if (commandToBeUpdated == null)
            {
                return NotFound("Command Not Found!");
            }
            _commandService.DeletedCommandById(commandToBeUpdated);
            return Ok(id);
        }
        
        
        private CommandReadDto GetCommandReadDtoFromDbResponse(Command command) {
            return _mapper.Map<CommandReadDto>(_commandService.CreateCommand(command));
        }

        private Command GetCommandFromRequest(CommandCreateDto commandCreateDto) {
            return _mapper.Map<Command>(commandCreateDto);
        }
        
    }
}

