
namespace CRM_App.BL;

public interface IProductManager
{
    public List<ProductReadDTO> GetAllProduct();
    ProductReadDTO GetProductById(Guid id);
    ProductReadDTO AddProduct(ProductWriteDTO product);
    bool UpdateProduct(ProductWriteDTO customer);

}
