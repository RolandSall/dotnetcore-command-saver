using System.ComponentModel.DataAnnotations;

namespace dotnetcore_command_saver.DTOs.CommandDTOs
{
    public class CommandUpdateDto {
        
        [Required]
        [MaxLength(150)]
        public string Objective { get; set; }
       
        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
        
        public CommandUpdateDto(string objective, string line, string platform) {
            Objective = objective;
            Line = line;
            Platform = platform;
        }

        
    }
}