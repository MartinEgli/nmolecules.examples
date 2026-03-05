using NMolecules.DDD;

[assembly: BoundedContext(
    "Billing",
    Id = "BC-BILLING",
    Description = "Handles customer accounts and invoicing lifecycle.")]
[assembly: Module(
    "CustomerAccounts",
    Id = "MOD-CUSTOMER-ACCOUNTS",
    BoundedContextId = "BC-BILLING",
    Description = "Customer account opening and identity handling.")]

namespace Samples.Block01.DddCore;

[ValueObject]
public readonly record struct CustomerId(string Value);

[AggregateRoot]
public sealed class Customer
{
    public Customer(CustomerId id, string displayName)
    {
        Id = id;
        DisplayName = displayName;
    }

    [Identity]
    public CustomerId Id { get; }

    public string DisplayName { get; private set; }

    public void Rename(string newName)
    {
        DisplayName = newName;
    }
}

[Factory]
public interface ICustomerFactory
{
    Customer Create(CustomerId id, string displayName);
}

[Repository]
public interface ICustomerRepository
{
    Customer? FindById(CustomerId id);
    void Add(Customer customer);
}

[DomainService]
public sealed class CustomerCreditPolicy
{
    public bool CanOpenAccount(Customer customer)
    {
        return customer.DisplayName.Length >= 3;
    }
}

[ApplicationService]
public sealed class OpenCustomerAccountUseCase
{
    private readonly ICustomerFactory _factory;
    private readonly ICustomerRepository _repository;
    private readonly CustomerCreditPolicy _creditPolicy;

    public OpenCustomerAccountUseCase(
        ICustomerFactory factory,
        ICustomerRepository repository,
        CustomerCreditPolicy creditPolicy)
    {
        _factory = factory;
        _repository = repository;
        _creditPolicy = creditPolicy;
    }

    public bool Open(CustomerId id, string displayName)
    {
        var customer = _factory.Create(id, displayName);

        if (!_creditPolicy.CanOpenAccount(customer))
        {
            return false;
        }

        _repository.Add(customer);
        return true;
    }
}
