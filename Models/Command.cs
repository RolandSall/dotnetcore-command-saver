namespace dotnetcore_command_saver.Models{
    public class Command {
        
        public int Id { get; set; }

        public string Objective { get; set; }

        public string Line { get; set; }

        public string Platform { get; set; }
        
        public Command(int id, string objective, string line, string platform)
        {
            Id = id;
            Objective = objective;
            Line = line;
            Platform = platform;
        }
    }
}