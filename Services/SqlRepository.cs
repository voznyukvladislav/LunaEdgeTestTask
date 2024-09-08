using LunaEdgeTestTask.Interfaces;
using LunaEdgeTestTask.Models;

namespace LunaEdgeTestTask.Services
{
    public class SqlRepository : IRepository
    {
        public User? GetUser(Guid id)
        {
            throw new NotImplementedException();
        }
        public User? GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public User? GetUser(string login, string passwordHash)
        {
            throw new NotImplementedException();
        }

        
    }
}
