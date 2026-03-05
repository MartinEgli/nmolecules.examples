using NMolecules.Architecture.Cqrs;

namespace Samples.Architecture.Cqrs;

[Command(Name = "CreateInvoice", Namespace = "Billing.Commands")]
public readonly record struct CreateInvoice(decimal Amount);

[Query(Name = "FindInvoice", Namespace = "Billing.Queries")]
public readonly record struct FindInvoice(string Id);

[QueryModel]
public sealed class InvoiceReadModel
{
    public InvoiceReadModel(string id, decimal amount)
    {
        Id = id;
        Amount = amount;
    }

    public string Id { get; }
    public decimal Amount { get; }
}

[Projection]
public sealed class InvoiceProjection
{
}

public sealed class InvoiceHandlers
{
    [CommandHandler]
    public void Handle(CreateInvoice command)
    {
    }

    [QueryHandler]
    public InvoiceReadModel Handle(FindInvoice query)
    {
        return new InvoiceReadModel(query.Id, 42m);
    }

    [CommandDispatcher(Dispatches = "Billing.Commands.CreateInvoice")]
    public void Dispatch(CreateInvoice command)
    {
    }
}
