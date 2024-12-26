using memory_game_backend.Constants;

namespace memory_game_backend.Repositories.Implementations;

using Microsoft.EntityFrameworkCore;
using Data.Databases;
using Interfaces;
using Models.Entities;

public class ScoreRepository : IScoreRepository
{
    private readonly AppDbContext _context;
   
    public ScoreRepository(AppDbContext context)
    {
        _context = context;
    }
   
    public async Task<Score> Create(Score score)
    {
        // Add the score to the database
        await _context.Scores.AddAsync(score);
       
        // Save the changes
        await _context.SaveChangesAsync();
       
        // Return the score
        return score;
    }

    public async Task<List<Score>> Get()
    {
        // Get top N scores ordered by points in descending order
        return await _context.Scores
            .OrderBy(s => s.TotalSeconds)
            .Take(ScoreConstants.MAX_LEADERBOARD_LIMIT)
            .Include(s => s.User)
            .ToListAsync();

    }
}
