using E_Commerce.Application.Contract;
using E_Commerce.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public class GenaricRepository<T> : IGenaricrepository<T> where T : class
    {
        private readonly EContext context;
        public readonly DbSet<T> dbset;


        public GenaricRepository(EContext _context)
        {
            context = _context;
            dbset = context.Set<T>();
           
            
        }
        public T create(T EX)
        {
            return dbset.Add(EX).Entity;
        }
        public T update(T EX)
        {
            dbset.Update(EX);
            
            return EX;
        }
        public void delete(T EX)
        {
            
            dbset.Remove(EX);
        }
        public T get(int id)
        {
            return dbset.Find(id);
        }

        public IQueryable<T> getAll()
        {
            return dbset;
        }

        public void Save()
        {
            try
            {

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException?.Message);

            }
        }

        public int SaveChanges()
        {

            return context.SaveChanges();
        }
    }
}
