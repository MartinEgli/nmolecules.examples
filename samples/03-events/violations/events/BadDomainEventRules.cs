using NMolecules.DDD;
using NMolecules.Events;

namespace Samples.Block03.Events.Violations;

[Entity]
public sealed class EventEntity
{
    [Identity]
    public string Id { get; } = "entity";
}

[AggregateRoot]
public sealed class EventAggregateRoot
{
    [Identity]
    public string Id { get; } = "aggregate";
}

[Repository]
public interface IEventRepository
{
}

[Service]
public sealed class EventLegacyService
{
}

[Factory]
public interface IEventFactory
{
}

// XMoleculesDomainEvent0001
// Violates because a domain event payload references an entity.
[DomainEvent]
public sealed class EventReferencingEntity
{
    public EventEntity Entity { get; } = new();
}

// XMoleculesDomainEvent0002
// Violates because a domain event payload references an aggregate root.
[DomainEvent]
public sealed class EventReferencingAggregateRoot
{
    public EventAggregateRoot AggregateRoot { get; } = new();
}

// XMoleculesDomainEvent0003
// Violates because a domain event payload references a repository.
[DomainEvent]
public sealed class EventReferencingRepository
{
    public IEventRepository Repository { get; } = default!;
}

// XMoleculesDomainEvent0004
// Violates because a domain event payload references a legacy service.
[DomainEvent]
public sealed class EventReferencingLegacyService
{
    public EventLegacyService Service { get; } = new();
}

// XMoleculesDomainEvent0005
// Violates because a domain service is marked as a domain-event publisher.
[DomainService]
[DomainEventPublisher]
public sealed class DomainServicePublisher
{
    [DomainEventPublisher]
    public void Publish(EventReferencingEntity domainEvent)
    {
    }
}

// XMoleculesDomainEvent0006
// Violates because a repository is marked as a domain-event publisher.
[Repository]
[DomainEventPublisher]
public sealed class RepositoryPublisher
{
    [DomainEventPublisher]
    public void Publish(EventReferencingAggregateRoot domainEvent)
    {
    }
}

[Factory]
[DomainEventPublisher]
public sealed class FactoryPublisher
{
    [DomainEventPublisher]
    public void Publish(EventReferencingEntity domainEvent)
    {
    }
}

// XMoleculesDomainEvent0007
// Violates because the event handler consumes a plain string instead of a domain event.
[DomainEventHandler]
public sealed class HandlerWithoutDomainEventPayload
{
    [DomainEventHandler]
    public void Handle(string payload)
    {
    }
}

// XMoleculesDomainEvent0008
// Violates because the publisher method emits a plain string instead of a domain event.
[ApplicationService]
[DomainEventPublisher]
public sealed class PublisherWithoutDomainEventPayload
{
    [DomainEventPublisher]
    public void Publish(string id)
    {
    }
}

// XMoleculesDomainEvent0009
// Violates because the handler consumes multiple domain-event payloads at once.
[DomainEventHandler]
public sealed class HandlerWithMultipleDomainEventPayloads
{
    [DomainEventHandler]
    public void Handle(EventReferencingEntity one, EventReferencingAggregateRoot two)
    {
    }
}
