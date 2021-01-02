using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_command_saver.Models{
    public class Command {
        
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Objective { get; set; }

        [Required]
        public string Line { get; set; }
        
        [Required]
        public string Platform { get; set; }
        
        public Command(Guid id, string objective, string line, string platform) {
            Id = id;
            Objective = objective;
            Line = line;
            Platform = platform;
        }

        public Command() {
        }
    }
}