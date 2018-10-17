using DDD.Domain.Entities;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);
        void Update(User user);
        bool EmailExist(string email);
        bool DocumentExists(Document document);
    }
}
