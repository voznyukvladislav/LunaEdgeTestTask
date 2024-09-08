using LunaEdgeTestTask.Models;

namespace LunaEdgeTestTask.Interfaces
{
    public interface IRepository
    {
        public User? GetUser(Guid id);
        public User? GetUser(string username);
        public User? GetUser(string login, string passwordHash);
    }
}
