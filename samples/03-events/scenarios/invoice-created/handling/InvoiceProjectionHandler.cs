using NMolecules.Events;

namespace Samples.Block03.Events;

[DomainEventHandler]
public sealed class InvoiceProjectionHandler
{
    [DomainEventHandler]
    public void Handle(InvoiceCreated domainEvent)
    {
        _ = domainEvent.InvoiceId;
    }
}
