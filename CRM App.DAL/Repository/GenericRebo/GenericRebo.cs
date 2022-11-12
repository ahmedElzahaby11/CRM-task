namespace CRM_App.DAL;

public class GenericRebo<T> : IGenericRebo<T> where T : class
{
    private readonly CRM_Context _context;
    public GenericRebo(CRM_Context context)
    {
        _context = context;
    }
    public void Add(T entity)
    {
      _context.Set<T>().Add(entity);     
    }

    public List<T> GetAll()
    {
       return _context.Set<T>().ToList();
    }

    public T? GetById(Guid id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Update(T entity)
    {
      
    }


    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
