using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> table = null;
        public GenericRepo(DataContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public void delete(object id)
        {
            T existing = GetByID(id);
            table.Remove(existing);
        }

        public IEnumerable<T> Getall()
        {
            return table.ToList();
        }

        public T GetByID(object id)
        {
            return table.Find(id);
        }

        public void insert(T entity)
        {
            table.Add(entity);
        }

        public void update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
