using ChatSession.Dal.Data.Entities;
using ChatSession.Dal.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChatSession.Dal.Data
{
    public class ChatSessionDbContext(DbContextOptions<ChatSessionDbContext> options) : DbContext(options), IChatSessionDbContext
    {
        public DbSet<Session> Sessions { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>()
                .HasIndex(agent => agent.ActorId)
                .HasDatabaseName("IX_Session_ActorId")
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
