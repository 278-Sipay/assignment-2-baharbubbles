using System.Linq.Expressions;

namespace Assigment2.Repositories;

public interface IGenericRepository<T> where T : class
{
    public List<T> Where(Expression<Func<T, bool>> expression);
}

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly List<T> _list;

    public GenericRepository()
    {
        _list = new List<T>();
    }

    public List<T> Add(T entity)
    {
        _list.Add(entity);
        return _list;
    }

    public List<T> Where(Expression<Func<T, bool>> expression)
    {
        return _list.Where(expression.Compile()).ToList();
    }
}