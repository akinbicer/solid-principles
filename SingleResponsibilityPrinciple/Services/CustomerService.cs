using SingleResponsibilityPrinciple.Models;

namespace SingleResponsibilityPrinciple.Services;

public class CustomerService : ICustomerService
{
    private readonly List<Customer?> _customers;

    public CustomerService()
    {
        _customers = new List<Customer?>();
    }

    public List<Customer?> GetAll()
    {
        // Get all the customer information from the database
        return _customers;
    }

    public Customer? Get(Guid id)
    {
        // Get the customer information from the database
        return _customers.FirstOrDefault(x => x != null && x.Id == id);
    }

    public void Add(Customer customer)
    {
        // Save the customer information to the database
        if (customer == null)
            throw new ArgumentNullException(nameof(customer));

        _customers.Add(customer);
    }
}