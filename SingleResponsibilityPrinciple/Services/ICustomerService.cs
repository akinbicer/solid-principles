using SingleResponsibilityPrinciple.Models;

namespace SingleResponsibilityPrinciple.Services;

public interface ICustomerService
{
    List<Customer?> GetAll();
    Customer? Get(Guid id);
    void Add(Customer customer);
}