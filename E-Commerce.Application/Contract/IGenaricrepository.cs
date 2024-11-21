using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contract
{
    public interface IGenaricrepository<T>
    {
        public T create(T EX);
        public T update(T EX);
        public void delete(T idEX);
        public T get(int id);
        void Save();
        public IQueryable<T> getAll();
        public int SaveChanges();

    }
}
