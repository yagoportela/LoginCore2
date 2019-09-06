using product.back.Data;
using product.back.Models;
using product.back.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace product.back.Services
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity

    {     
         ApplicationDbContext context;
        public BaseRepository(ApplicationDbContext db)
        {
            context = db;
        }

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }
        
        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }

        public IList<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }

        public T Select(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}