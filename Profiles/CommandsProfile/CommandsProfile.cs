using AutoMapper;
using dotnetcore_command_saver.DTOs;
using dotnetcore_command_saver.Models;

namespace dotnetcore_command_saver.Profiles.CommandsProfile {
    
    public class CommandsProfile: Profile {
        
        public CommandsProfile() {
            CreateMap<Command, CommandReadDto>();
        }
    }
}
