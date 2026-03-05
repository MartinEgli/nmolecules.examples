using NMolecules.Architecture.Hexagonal;

namespace Samples.Architecture.Hexagonal;

[Application]
public sealed class BillingCore
{
}

[PrimaryPort]
public interface ICreateInvoicePort
{
    void Execute(decimal amount);
}

[SecondaryPort]
public interface IInvoiceStorePort
{
    decimal? LoadAmount(string invoiceId);
}

[PrimaryAdapter]
public sealed class HttpCreateInvoiceAdapter : ICreateInvoicePort
{
    public void Execute(decimal amount)
    {
    }
}

[SecondaryAdapter]
public sealed class SqlInvoiceStoreAdapter : IInvoiceStorePort
{
    public decimal? LoadAmount(string invoiceId)
    {
        return 42m;
    }
}
