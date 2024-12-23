namespace memory_game_backend.Repositories.Interfaces;

using Models.Entities;

public interface IScoreRepository
{
    public Task<Score> Create(Score score);
    public Task<List<Score>> Get();
}
