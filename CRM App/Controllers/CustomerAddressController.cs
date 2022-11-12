using CRM_App.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAddressController : ControllerBase
    {
        private readonly ICustomerAddressManager _customerAddressManager;
        public CustomerAddressController(ICustomerAddressManager customerAddressManager)
        {
            _customerAddressManager = customerAddressManager;
        }
        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<IEnumerable<CustomerAddressReadDTO>> GetCustomerAddresses(Guid id)
        {
           return Ok(_customerAddressManager.GetCustomerAddressByCustomerId(id).ToList());
        }

        [HttpPost]
        public ActionResult<CustomerAddressReadDTO> PostCustomer(CustomerAddressWriteDTO customerAddress)
        {
            var customerAddressReadDTO = _customerAddressManager.AddAddressToCustomer(customerAddress);
            return CreatedAtAction("GetCustomerAddresses", 
                new { id = customerAddressReadDTO.CustomerAddressId }, customerAddressReadDTO);
        }

    }
}
