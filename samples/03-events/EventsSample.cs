using NMolecules.Events;

namespace Samples.Block03.Events;

[DomainEvent]
public readonly record struct InvoiceCreated(string InvoiceId, decimal Amount);

[DomainEventPublisher]
public interface IDomainEventBus
{
    [DomainEventPublisher]
    void Publish<TEvent>(TEvent domainEvent);
}

[DomainEventPublisher]
public sealed class InMemoryEventBus : IDomainEventBus
{
    private readonly List<object> _events = new();

    public void Publish<TEvent>(TEvent domainEvent)
    {
        _events.Add(domainEvent!);
    }
}

[DomainEventHandler]
public sealed class InvoiceAuditHandler
{
    [DomainEventHandler]
    public void Handle(InvoiceCreated domainEvent)
    {
        _ = $"{domainEvent.InvoiceId}:{domainEvent.Amount}";
    }
}

[DomainEventHandler]
public sealed class InvoiceProjectionHandler
{
    [DomainEventHandler]
    public void Handle(InvoiceCreated domainEvent)
    {
        _ = domainEvent.InvoiceId;
    }
}
