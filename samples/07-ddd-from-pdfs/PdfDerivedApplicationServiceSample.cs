using NMolecules.DDD;

namespace Samples.Block07.DddFromPdfs.ApplicationServicePerUseCase;

[AggregateRoot]
public sealed class Customer
{
    public Customer(CustomerId id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    [Identity]
    public CustomerId Id { get; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public void ChangePersonalName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

[ValueObject]
public readonly record struct CustomerId(string Value);

[Repository]
public interface ICustomerRepository
{
    Customer? CustomerOfId(CustomerId id);
}

[ApplicationService]
public sealed class CustomerApplicationService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerApplicationService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    // Derived from IDDD p.67: one method should handle one explicit use case.
    public void ChangeCustomerPersonalName(CustomerId customerId, string firstName, string lastName)
    {
        var customer = _customerRepository.CustomerOfId(customerId);

        if (customer is null)
        {
            throw new InvalidOperationException("Customer does not exist.");
        }

        customer.ChangePersonalName(firstName, lastName);
    }
}
