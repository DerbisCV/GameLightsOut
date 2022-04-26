using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Data.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //protected readonly DbContext _context;
        internal readonly SolvtioDbContext _context;
        protected readonly DbSet<T> _dbSet;
        

        public GenericRepository(SolvtioDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = context.Set<T>();
        }

        public virtual async Task<T> Get(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }




        //public void Update(T entity, Func<T, bool> filter)
        //{
        //    var existing = _dbSet.Where(filter).SingleOrDefault();
        //    if (existing != null)
        //    {
        //        _context.Entry(existing).CurrentValues.SetValues(entity);
        //        _context.Entry(existing).State = EntityState.Modified;
        //    }

        //}
    }
}
