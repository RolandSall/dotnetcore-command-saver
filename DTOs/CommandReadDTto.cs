using System;

namespace dotnetcore_command_saver.DTOs
{
    public class CommandReadDto
    {
        public Guid Id { get; set; }

        public string Objective { get; set; }
       
        public string Line { get; set; }

        public string Platform { get; set; }
        
        public CommandReadDto(Guid id, string objective, string line, string platform) {
            Id = id;
            Objective = objective;
            Line = line;
            Platform = platform;
        }
    }
}