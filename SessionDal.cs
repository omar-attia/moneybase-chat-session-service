using ChatSession.Dal.Data.Entities;
using ChatSession.Dal.Data.Interfaces;
using ChatSession.Dal.Interfaces;
using ChatSession.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace ChatSession.Dal
{
    public class SessionDal(IChatSessionDbContext sessionDbContext) : ISessionDal
    {
        public async Task CreateSession(Session session)
        {
            await sessionDbContext.Sessions.AddAsync(session);
            await sessionDbContext.SaveChangesAsync();
        }

        public async Task<Session?> GetSession(Guid sessionId)
        {
            return await sessionDbContext.Sessions.AsNoTracking().FirstOrDefaultAsync(s => s.Id == sessionId);
        }

        public async Task<bool> UpdateSessionStatus(Guid sessionId, SessionStatus status)
        {
            var session = await sessionDbContext.Sessions.FirstOrDefaultAsync(s => s.Id == sessionId);
            if (session == null)
                return false;

            session.Status = status.ToString();
            await sessionDbContext.SaveChangesAsync();
            return true;
        }
    }
}
