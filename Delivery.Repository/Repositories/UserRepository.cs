using System;
using System.Linq;
using Delivery.Entities.Register;
using Delivery.Repository.DataAcess.Interfaces;
using Delivery.Repository.Repositories.Interfaces;

namespace Delivery.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDataAcess _dataAcess;

        public UserRepository(IDataAcess dataAcess) =>
            _dataAcess = dataAcess;

        public User Find(Func<User, bool> predicate) =>
            _dataAcess.Find(predicate);

        public User Insert(User user) =>
            _dataAcess.Insert(user);

        public IQueryable<User> Select() =>
            _dataAcess.DeliveryContext.Users;


        public User Update(User user) =>
            _dataAcess.Update(user);
    }
}
