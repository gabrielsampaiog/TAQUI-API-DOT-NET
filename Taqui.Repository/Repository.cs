﻿
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Taqui.Database;

namespace Taqui.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly FIAPDBContext _context;

        private readonly DbSet<T> _dbSet;

        public Repository(FIAPDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Add(entity);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int? id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T existingEntity, T entity)
        {
            
            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
            
        }
    }
}
