using CRM_App.BL;
using Microsoft.AspNetCore.Mvc;

namespace CRM_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
       
        private readonly ICustomerManager _customerManager;
        public CustomerController(ICustomerManager customerManager)
        {
       
            _customerManager = customerManager;

        }

        [HttpGet]
        public ActionResult <IEnumerable<CustomerReadDTO>> GetCustomers()
        {
            return _customerManager.GetAllCustomer();
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<CustomerReadDTO> GetCustomer(Guid id)
        {
            var customer= _customerManager.GetCustomerById(id);
            if(customer==null)
            {
                return NotFound();
            }
            return customer;
        }
        [HttpPost]
        public ActionResult<CustomerReadDTO> PostCustomer(CustomerWriteDTO customer)
        {
            var customerReadDTO = _customerManager.AddCustomer(customer);
            return CreatedAtAction("GetCustomer", new { id = customerReadDTO.CustomerId},customerReadDTO);
        }

        [HttpPut]
        public ActionResult PutCustomer(CustomerWriteDTO customerDTO)
        {
            var result = _customerManager.UpdateCustomer(customerDTO);
            if (result)
            {
                return NoContent();
            }
            return BadRequest();


        }
    }
}
