
using AutoMapper;
using CRM_App.DAL;

namespace CRM_App.BL;

public class CustomerManager : ICustomerManager
{
    private readonly ICustomerRebo _customerRebo;
    private readonly IMapper _mapper;
    public CustomerManager(ICustomerRebo customerRebo,IMapper mapper)
    {
        _customerRebo = customerRebo;
        _mapper = mapper;
    }

    public List<CustomerReadDTO> GetAllCustomer()
    {
        var dbCustomer = _customerRebo.GetAll();
        var DTOList=_mapper.Map<List<CustomerReadDTO>>(dbCustomer);
        return DTOList;
    }

    public CustomerReadDTO? GetCustomerById(Guid id)
    {
        var dbCustomer = _customerRebo.GetById(id);
        if (dbCustomer is null)
            return null;
        return _mapper.Map<CustomerReadDTO>(dbCustomer);

    }

    public CustomerReadDTO AddCustomer(CustomerWriteDTO customerDTO)
    {
        var dbCustomer=_mapper.Map<Customer>(customerDTO);
        dbCustomer.CustomerId = Guid.NewGuid();
        _customerRebo.Add(dbCustomer);
        _customerRebo.SaveChanges();
        return _mapper.Map<CustomerReadDTO>(dbCustomer);
    }





    public bool UpdateCustomer(CustomerWriteDTO customerDTO)
    {
        var dbCustomer=_customerRebo.GetById(customerDTO.CustomerId);
        if (dbCustomer is null)
            return false;

        _mapper.Map(customerDTO, dbCustomer);
        _customerRebo.Update(dbCustomer);
        _customerRebo.SaveChanges();

        return true;
    }
}
