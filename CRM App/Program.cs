using CRM_App.BL;
using CRM_App.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Cors
string allowAllCorsPolicy = "allowAll";
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(allowAllCorsPolicy, p =>
    p.AllowAnyOrigin()
     .AllowAnyHeader()
     .AllowAnyMethod()
    );
});

#endregion

#region services

#region Default

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region Database

var ConnectionString = builder.Configuration.GetConnectionString("CRMDb");
builder.Services.AddDbContext<CRM_Context>(options => options.UseSqlServer(ConnectionString));

#endregion

#region Rebo

builder.Services.AddScoped<ICustomerRebo, CustomerRebo>();
builder.Services.AddScoped<IProductRebo, ProductRebo>();
builder.Services.AddScoped<ICustomerAddressRebo, CustomerAddressRebo>();

#endregion


#region AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
#endregion


#region Managers

builder.Services.AddScoped<ICustomerManager, CustomerManager>();
builder.Services.AddScoped<IProductManager, ProductManager>();
builder.Services.AddScoped<ICustomerAddressManager, CustomerAddressManager>();
#endregion


#endregion
var app = builder.Build();

#region Middleware

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(allowAllCorsPolicy);

app.MapControllers();

app.Run();

#endregion
