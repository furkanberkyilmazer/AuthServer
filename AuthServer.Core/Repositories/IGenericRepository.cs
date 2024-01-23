using AuthServer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        //func ->delegate-> bir methodu işaret ediyor

        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        //product= productRepository.where(x=>x.id>5);
        // product.any

        //product.ToList()  -> dediğimde yukardakileri bir sorgu haline getirip veritabanına istek atar

        Task AddAsync(T entity);

        void Remove(T entity);

        T Update(T entity);
    }
}
