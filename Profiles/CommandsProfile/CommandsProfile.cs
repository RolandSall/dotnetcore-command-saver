using AutoMapper;
using dotnetcore_command_saver.DTOs;
using dotnetcore_command_saver.DTOs.CommandDTOs;
using dotnetcore_command_saver.Models;

namespace dotnetcore_command_saver.Profiles.CommandsProfile {
    
    public class CommandsProfile: Profile {
        
        public CommandsProfile() {
            // <source, target>
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
