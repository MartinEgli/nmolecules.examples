using NMolecules.DDD;

namespace Samples.Block01.DddCore;

[Entity]
public sealed class LegacyInvoiceEntity
{
    public LegacyInvoiceEntity(string id)
    {
        Id = id;
    }

    [Identity]
    public string Id { get; }
}

[Service]
public sealed class LegacyCurrencyService
{
    public decimal Convert(decimal amount, decimal rate)
    {
        return amount * rate;
    }
}

[Repository]
public interface ICustomerReadRepository
{
    LegacyInvoiceEntity? FindById(string id);
}

[Repository]
[AllowRepositoryComposition]
public interface IAccountingRepository
{
    LegacyInvoiceEntity? FindInvoice(string id);

    [AllowRepositoryComposition]
    LegacyInvoiceEntity? FindFrom(ICustomerReadRepository repository, string id);
}
