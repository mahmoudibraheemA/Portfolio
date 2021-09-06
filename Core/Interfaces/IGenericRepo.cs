using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IGenericRepo <T> where T:class 
    {
        IEnumerable<T> Getall();
        T GetByID(object id);
        void insert(T entity);
        void update(T entity);
        void delete(object id);

    }
}
