using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence
{
    public class BaseRepository<T> : IGenericRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _set;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        IOperationResult<T> IGenericRepository<T>.Create(T entity)
        {
            try
            {
                _set.Add(entity);
                _context.SaveChanges();
                _context.Entry(entity).State = EntityState.Detached;
                return BasicOperationResult<T>.Ok(entity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BasicOperationResult<T>.Fail(e.ToString());
            }
        }

        T IGenericRepository<T>.Find(Expression<Func<T, bool>> predicate)
            => _set.AsNoTracking().FirstOrDefault(predicate);

        IEnumerable<T> IGenericRepository<T>.FindAll(Expression<Func<T, bool>> predicate)
            => _set.Where(predicate);

        IEnumerable<T> IGenericRepository<T>.Get()
            => _set.AsNoTracking().AsEnumerable();

        IOperationResult<T> IGenericRepository<T>.Remove(T entity)
        {
            try
            {
                _set.Remove(entity);
                _context.SaveChanges();
                _context.Entry(entity).State = EntityState.Detached;
                return BasicOperationResult<T>.Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BasicOperationResult<T>.Fail("Fail to delete the object");
            }
        }

        IOperationResult<T> IGenericRepository<T>.Update(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                _context.Entry(entity).State = EntityState.Detached;
                return BasicOperationResult<T>.Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BasicOperationResult<T>.Fail(e.ToString());
            }

        }

        bool IGenericRepository<T>.Exists(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> queryable = _set.AsQueryable();

            return queryable.AsNoTracking().Any(predicate);
        }

        void IGenericRepository<T>.Save()
            => _context.SaveChanges();
    }

}
