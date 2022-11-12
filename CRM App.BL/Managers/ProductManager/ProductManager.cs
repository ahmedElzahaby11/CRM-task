
using AutoMapper;
using CRM_App.DAL;


namespace CRM_App.BL;

public class ProductManager : IProductManager
{
    private readonly IProductRebo _productRebo;
    private readonly IMapper _mapper;
    public ProductManager(IProductRebo productRebo, IMapper mapper)
    {
        _productRebo = productRebo;
        _mapper = mapper;
    }

    public List<ProductReadDTO> GetAllProduct()
    {
        var dbProduct = _productRebo.GetAll();
        var DTOList=_mapper.Map<List<ProductReadDTO>>(dbProduct);
        return DTOList;
    }

    public ProductReadDTO? GetProductById(Guid id)
    {
        var dbProduct=_productRebo.GetById(id);
        if(dbProduct is null)
        {
            return null;
        }
        return _mapper.Map<ProductReadDTO>(dbProduct);
    }
    public ProductReadDTO AddProduct(ProductWriteDTO productDTO)
    {
        var dbProduct=_mapper.Map<Product>(productDTO);
        dbProduct.ProductId = Guid.NewGuid();
        _productRebo.Add(dbProduct);
        _productRebo.SaveChanges();
        return _mapper.Map<ProductReadDTO>(dbProduct);
    }

 



    public bool UpdateProduct(ProductWriteDTO productDTO)
    {
        var dbProduct = _productRebo.GetById(productDTO.ProductId);
        if (dbProduct is null)
            return false;

        _mapper.Map(productDTO, dbProduct);
        _productRebo.Update(dbProduct);
        _productRebo.SaveChanges();

        return true;

    }
}
