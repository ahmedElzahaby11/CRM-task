using CRM_App.BL;
using Microsoft.AspNetCore.Mvc;

namespace CRM_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        public readonly IProductManager _productManager;
       
        public ProductController( IProductManager productManager)
        {
     
            _productManager = productManager;
            
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDTO>> GetProducts()
        {
            return _productManager.GetAllProduct();
        }
        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<ProductReadDTO> GetProduct(Guid id)
        {
            var product = _productManager.GetProductById(id);
            if(product == null)
            {
                return NotFound();
            }
            return product;
        }
        [HttpPost]
        public ActionResult PostProduct(ProductWriteDTO product)
        {
            var productDTO = _productManager.AddProduct(product);
            return CreatedAtAction("GetProduct", new { id = productDTO.ProductId }, productDTO);
        }

        [HttpPut]
        public ActionResult PutProduct(ProductWriteDTO productDTO)
        {
            var result = _productManager.UpdateProduct(productDTO);
            if (result)
            {
                return NoContent();
            }
            return BadRequest();


        }

    }
}
