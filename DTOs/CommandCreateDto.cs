namespace dotnetcore_command_saver.DTOs {
    
    public class CommandCreateDto {

        public string Objective { get; set; }
       
        public string Line { get; set; }

        public string Platform { get; set; }
        
        public CommandCreateDto(string objective, string line, string platform) {
         
            Objective = objective;
            Line = line;
            Platform = platform;
        }
        
    }
}