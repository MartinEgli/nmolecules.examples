using NMolecules.Events;

namespace Samples.Block03.Events;

[DomainEventPublisher]
public interface IDomainEventBus
{
    [DomainEventPublisher]
    void Publish<TEvent>(TEvent domainEvent);
}
