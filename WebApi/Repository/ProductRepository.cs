using Microsoft.EntityFrameworkCore;
using System.Collections;
using WebApi.Model;
using WebApi.Model.Entities;
using WebApi.Repository.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebApiContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProductRepository(WebApiContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Begins transaction.
        /// </summary>
        public async Task BeginTransactionAsync()
        {
            if (context.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
            {
                await context.Database.BeginTransactionAsync();
            }
        }

        /// <summary>
        /// Commits transaction if exists.
        /// </summary>
        public void CommitTransaction()
        {
            if (context.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory" &&
                context.Database.CurrentTransaction != null)
            {
                context.Database.CommitTransaction();
            }
        }

        /// <summary>
        /// Rollbacks transaction if exists.
        /// </summary>
        public void RollbackTransaction()
        {
            if (context.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory" &&
                context.Database.CurrentTransaction != null)
            {
                context.Database.RollbackTransaction();
            }
        }

        /// <summary>
        /// Adds record to DB.
        /// </summary>
        /// <typeparam name="T">Model from interest repository.</typeparam>
        /// <param name="entity">Entity, that will be added.</param>
        /// <returns>Id of newly created record.</returns>
        public async Task<int> AddAsync<T>(T entity) where T : Product
        {
            try
            {
                var result = context.Add(entity);
                await context.SaveChangesAsync();
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Updates record in DB.
        /// </summary>
        /// <typeparam name="T">Model from claim repository.</typeparam>
        /// <param name="entity">Entity, that will be updated.</param>
        public async Task UpdateAsync<T>(T entity) where T : Product
        {
            try
            {
                context.Update(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Return record by id.
        /// </summary>
        /// <typeparam name="T">Model from commission repository.</typeparam>
        /// <param name="id">Id of record.</param>
        /// <returns>Found item.</returns>
        public async Task<T?> GetAsync<T>(int? id) where T : Product
        {
            try
            {
                if (id == null)
                {
                    return default;
                }

                var result = await context.FindAsync<T>(id);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Return a paged list of records from the DB
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public async Task<ProductList> GetAsync<T>(int? from = 0, int? count = 10) where T : Product
        {
            try
            {
                var set = context.Set<Product>();
                var rowCount = set.Count();
                var result = await set
                            .Skip(from.HasValue ? from.Value : 0)
                            .Take(count.HasValue ? count.Value : 0)
                            .Select(t => t)
                            .ToListAsync();
                return new ProductList((IEnumerable<T>)(result ?? new List<Product>()), rowCount);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Return all products from DB
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : Product
        {
            try
            {
                var result = await context.Products
                                            .Select(t => t)
                                            .ToListAsync();
                return (IEnumerable<T>)(result ?? new List<Product>());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
