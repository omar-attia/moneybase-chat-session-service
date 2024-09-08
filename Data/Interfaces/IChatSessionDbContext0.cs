using ChatSession.Dal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatSession.Dal.Data.Interfaces
{
    public interface IChatSessionDbContext
    {
        DbSet<Session> Sessions { get; set; }
        Task<int> SaveChangesAsync();
    }
}
