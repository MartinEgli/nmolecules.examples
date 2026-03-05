using NMolecules.DDD;
using NMolecules.Events;

namespace Samples.Block07.DddFromPdfs.AggregateConsistency;

[AggregateRoot]
public sealed class Product
{
    public Product(ProductId id)
    {
        Id = id;
    }

    [Identity]
    public ProductId Id { get; }
}

[AggregateRoot]
public sealed class BacklogItem
{
    public BacklogItem(BacklogItemId id, ProductId productId)
    {
        Id = id;
        ProductId = productId;
    }

    [Identity]
    public BacklogItemId Id { get; }

    // Derived from DDD Distilled p.79: reference other aggregates by identity only.
    public ProductId ProductId { get; }

    public SprintId? SprintId { get; private set; }

    public BacklogItemCommitted? CommitToSprint(SprintId sprintId)
    {
        SprintId = sprintId;
        return new BacklogItemCommitted(Id, sprintId);
    }
}

[AggregateRoot]
public sealed class Sprint
{
    private readonly List<BacklogItemId> _committedItems = new();

    public Sprint(SprintId id)
    {
        Id = id;
    }

    [Identity]
    public SprintId Id { get; }

    public IReadOnlyCollection<BacklogItemId> CommittedItems => _committedItems;

    public void AddCommittedBacklogItem(BacklogItemId backlogItemId)
    {
        _committedItems.Add(backlogItemId);
    }
}

[ValueObject]
public readonly record struct ProductId(string Value);

[ValueObject]
public readonly record struct BacklogItemId(string Value);

[ValueObject]
public readonly record struct SprintId(string Value);

// Derived from DDD Distilled p.81-82: eventual consistency via domain events.
[DomainEvent]
public readonly record struct BacklogItemCommitted(BacklogItemId BacklogItemId, SprintId SprintId);

[DomainEventHandler]
public sealed class SprintProjectionUpdater
{
    private readonly ISprintRepository _sprintRepository;

    public SprintProjectionUpdater(ISprintRepository sprintRepository)
    {
        _sprintRepository = sprintRepository;
    }

    [DomainEventHandler]
    public void Handle(BacklogItemCommitted domainEvent)
    {
        var sprint = _sprintRepository.GetById(domainEvent.SprintId);

        if (sprint is not null)
        {
            sprint.AddCommittedBacklogItem(domainEvent.BacklogItemId);
        }
    }
}

[Repository]
public interface ISprintRepository
{
    Sprint? GetById(SprintId id);
}
