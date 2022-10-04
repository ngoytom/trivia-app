using Microsoft.EntityFrameworkCore;

namespace TriviaAPI.Models
{
    public class TriviaDbContext:DbContext
    {
        public TriviaDbContext(DbContextOptions<TriviaDbContext> options) : base(options)
        { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
