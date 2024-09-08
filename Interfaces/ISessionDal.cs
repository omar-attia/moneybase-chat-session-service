using ChatSession.Dal.Data.Entities;
using ChatSession.Models.Enums;

namespace ChatSession.Dal.Interfaces
{
    public interface ISessionDal
    {
        Task CreateSession(Session session);
        Task<Session?> GetSession(Guid sessionId);
        Task<bool> UpdateSessionStatus(Guid sessionId, SessionStatus status);
    }
}
