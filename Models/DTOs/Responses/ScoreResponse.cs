namespace memory_game_backend.Models.DTOs.Responses;

public class ScoreResponse
{
    public class Create
    {
        public Guid ScoreId { get; set; }
        public int TotalMoves { get; set; }
        public int TotalSeconds { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    
    public class Get
    {
        public string Username { get; set; }
        public int TotalMoves { get; set; }
        public int TotalSeconds { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}