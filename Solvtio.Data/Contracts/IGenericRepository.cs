using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solvtio.Data.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> Get(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        //IEnumerable<T> GetAll(IEnumerable<string> listInclude = null);

        //IQueryResult<T> GetAll(IQueryPredicate<T> predicate, IEnumerable<string> listInclude = null);

        //IEnumerable<T> GetAll(Expression<Func<T, bool>> filter, IEnumerable<string> listInclude = null);

        //IQueryResult<T> GetBy(DataTableDto dataTableDto, IEnumerable<string> listInclude = null);


        //
        //
        //void AddRange(IEnumerable<T> entities);
        ////
        //

        //EntityEntry GetChanges(T entity);


    }
}
