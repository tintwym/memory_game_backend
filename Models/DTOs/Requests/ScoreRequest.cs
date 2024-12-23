namespace memory_game_backend.Models.DTOs.Requests;

public class ScoreRequest
{
    public class Create
    {
        public Guid UserId { get; set; }
        public int TotalMoves { get; set; }
        public int TotalSeconds { get; set; }
    }
}