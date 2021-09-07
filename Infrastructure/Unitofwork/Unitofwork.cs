using Core.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Unitofwork
{
    public class Unitofwork<T> : IUnitofwork<T> where T : class
    {
        private readonly DataContext _context;
        private IGenericRepo<T> _entity;
        public Unitofwork(DataContext context)
        {
            _context = context;
        }
        public IGenericRepo<T> entity 
        {
            get
            {
                return _entity ?? (_entity = new GenericRepo<T>(_context));
            }
        }

        

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
