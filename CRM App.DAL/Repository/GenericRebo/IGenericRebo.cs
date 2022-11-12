
namespace CRM_App.DAL;
public interface IGenericRebo<T> where T : class
{
    List<T> GetAll();
    T? GetById(Guid id);
    void Add(T entity);
    void Update(T entity);
    void SaveChanges();
}
