using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApplication.Contracts
{
    public interface IRepository<T> where T:class
    {
        List<T> getAll();
        void insert(T obj);
        void Update(T obj);
        void delete(T obj);
        T getById(int id);
    }
}