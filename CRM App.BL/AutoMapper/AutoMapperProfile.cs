
using AutoMapper;
using CRM_App.DAL;


namespace CRM_App.BL;

public class AutoMapperProfile:Profile
{
	public AutoMapperProfile()
	{
		CreateMap<Customer, CustomerReadDTO>();
		CreateMap<CustomerWriteDTO, Customer>();
		CreateMap<Product, ProductReadDTO>();
		CreateMap<ProductWriteDTO, Product>();
		CreateMap<CustomerAddress, CustomerAddressReadDTO>();
		CreateMap<CustomerAddressWriteDTO, CustomerAddress>();
	}
}
