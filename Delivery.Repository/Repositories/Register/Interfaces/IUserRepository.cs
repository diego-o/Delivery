using System;
using System.Linq;
using Delivery.Entities.Register;

namespace Delivery.Repository.Repositories.Register.Interfaces
{
    public interface IUserRepository
    {
        User Insert(User user);
        User Update(User user);
        User Find(Func<User, bool> predicate);
        IQueryable<User> Select();
    }
}
