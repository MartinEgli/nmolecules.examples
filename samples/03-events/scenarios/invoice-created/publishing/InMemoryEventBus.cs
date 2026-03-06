using NMolecules.Events;

namespace Samples.Block03.Events;

[DomainEventPublisher]
public sealed class InMemoryEventBus : IDomainEventBus
{
    private readonly List<object> _events = new();

    public void Publish<TEvent>(TEvent domainEvent)
    {
        _events.Add(domainEvent!);
    }
}
