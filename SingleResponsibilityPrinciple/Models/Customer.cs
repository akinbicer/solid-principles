namespace SingleResponsibilityPrinciple.Models;

public class Customer : Base
{
    public long? IdentityNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}