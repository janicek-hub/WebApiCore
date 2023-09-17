using WebApi.Model;
using WebApi.Model.Entities;

namespace WebApi.Repository.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// Begins transaction.
        /// </summary>
        Task BeginTransactionAsync();
        /// <summary>
        /// Commits transaction if exists.
        /// </summary>
        void CommitTransaction();
        /// <summary>
        /// Rollbacks transaction if exists.
        /// </summary>
        void RollbackTransaction();
        /// <summary>
        /// Adds record to DB.
        /// </summary>
        /// <typeparam name="T">Model from product repository.</typeparam>
        /// <param name="entity">Entity, that will be added.</param>
        /// <returns>Id of newly created record.</returns>
        Task<int> AddAsync<T>(T entity) where T : Product;

        /// <summary>
        /// Updates record in DB.
        /// </summary>
        /// <typeparam name="T">Model from product repository.</typeparam>
        /// <param name="entity">Entity, that will be updated.</param>
        Task UpdateAsync<T>(T entity) where T : Product;
        /// <summary>
        /// Return product entity by Id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T?> GetAsync<T>(int? id) where T : Product;
        /// <summary>
        /// Get pagination entities
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<ProductList> GetAsync<T>(int? from = 0, int? count = 10) where T : Product;
        /// <summary>
        /// Get all entities
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync<T>() where T : Product;
    }
}
