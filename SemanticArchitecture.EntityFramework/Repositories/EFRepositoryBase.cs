using Microsoft.EntityFrameworkCore;
using SemanticArchitecture.DataAccess.EntityFramework.Context;
using SemanticArchitecture.Domain.Core.Repository_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SemanticArchitecture.DataAccess.EntityFramework.Repositories
{
    public class EFRepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly EntityFrameworkContext _context;

        public EFRepositoryBase(EntityFrameworkContext context)
        {
            _context = context;
        }

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual void Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
