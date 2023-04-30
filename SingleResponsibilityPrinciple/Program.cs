using SingleResponsibilityPrinciple.Models;
using SingleResponsibilityPrinciple.Services;

var customerService = new CustomerService();

customerService.Add(new Customer
{
    Id = Guid.NewGuid(),
    CreatedDate = DateTime.Now,
    IdentityNumber = 12345678901,
    FirstName = "Test",
    LastName = "Customer 1"
});
customerService.Add(new Customer
{
    Id = Guid.NewGuid(),
    CreatedDate = DateTime.Now,
    IdentityNumber = 12345678902,
    FirstName = "Test",
    LastName = "Customer 2"
});
customerService.Add(new Customer
{
    Id = Guid.NewGuid(),
    CreatedDate = DateTime.Now,
    IdentityNumber = 12345678903,
    FirstName = "Test",
    LastName = "Customer 3"
});

foreach (var customer in customerService.GetAll())
{
    Console.WriteLine($"Registered: {customer.CreatedDate}");
    Console.WriteLine($"Record Id: {customer.Id}");
    Console.WriteLine($"Identity Number: {customer.IdentityNumber}");
    Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}");
    Console.WriteLine("===============================================");
}