using System;
using Delivery.Repository.DataAcess.Interfaces;

namespace Delivery.Repository.DataAcess
{
    public class DataAcess : IDataAcess
    {
        private readonly IDeliveryContext _deliveryContext;

        public IDeliveryContext DeliveryContext => _deliveryContext;

        public DataAcess(IDeliveryContext deliveryContext) =>
            _deliveryContext = deliveryContext;

        public TEntity Insert<TEntity>(TEntity entity) where TEntity : class
        {
            _deliveryContext.Set<TEntity>().Add(entity);
            _deliveryContext.SaveChanges();
            return entity;
        }

        public TEntity Update<TEntity>(TEntity entity) where TEntity : class
        {
            _deliveryContext.Set<TEntity>().Update(entity);
            _deliveryContext.SaveChanges();
            return entity;
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            _deliveryContext.Set<TEntity>().Remove(entity);
            _deliveryContext.SaveChanges();
        }

        public TEntity Find<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return _deliveryContext.Set<TEntity>().Find(predicate);
        }
    }
}
