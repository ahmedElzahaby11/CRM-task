

using AutoMapper;
using CRM_App.DAL;

namespace CRM_App.BL;

public class CustomerAddressManager : ICustomerAddressManager
{
    private readonly IMapper _mapper;
    private readonly ICustomerAddressRebo _customerAddressRebo;
    public CustomerAddressManager(ICustomerAddressRebo customerAddressRebo,IMapper mapper)
    {
        _customerAddressRebo = customerAddressRebo;
        _mapper = mapper;
    }
    public CustomerAddressReadDTO AddAddressToCustomer(CustomerAddressWriteDTO customerAddressDTO)
    {
        var dbCustomerAddress = _mapper.Map<CustomerAddress>(customerAddressDTO);
        dbCustomerAddress.CustomerAddressId = Guid.NewGuid();
        _customerAddressRebo.Add(dbCustomerAddress);
        _customerAddressRebo.SaveChanges();
        return _mapper.Map<CustomerAddressReadDTO>(dbCustomerAddress);
    }

    public List<CustomerAddressReadDTO> GetCustomerAddressByCustomerId(Guid id)
    {
        var dbCustomerAddress = _customerAddressRebo.GetCustomerAddressesById(id);
        var DTOList = _mapper.Map<List<CustomerAddressReadDTO>>(dbCustomerAddress);
        return DTOList;
    }
}
