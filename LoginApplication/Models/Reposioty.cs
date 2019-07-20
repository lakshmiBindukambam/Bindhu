using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginApplication.Models
{
    public class Reposioty<T> : LoginApplication.Contracts.IRepository<T> where T : class
    {
        LoginApplication.Models.LoginApp lAp;
        DbSet<T> dbSet;
        public Reposioty(LoginApp lAp )
            {
            this.lAp = lAp;
            dbSet = lAp.Set<T>();
            }

        public void delete(T obj)
        {
            dbSet.Remove(obj);
        }

        public List<T> getAll()
        {
            return dbSet.ToList();
        }

        public T getById(int id)
        {
            return dbSet.Find(id);
        }

        public void insert(T obj)
        {
            dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            lAp.Entry(obj).State = EntityState.Modified;
        }
    }
}