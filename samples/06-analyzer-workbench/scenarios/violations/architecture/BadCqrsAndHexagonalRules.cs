using NMolecules.Architecture.Cqrs;
using NMolecules.Architecture.Hexagonal;
using NMolecules.DDD;

namespace Samples.Block06.AnalyzerWorkbench.BadCqrsAndHexagonal;

// XMoleculesCQRS0001
// Violates because the compilation contains a query without any matching query handler.
[Query(Name = "FindBrokenInvoice", Namespace = "Samples.Bad.Queries")]
public readonly record struct FindBrokenInvoice(string Id);

// XMoleculesCQRS0004
// Violates because query models are expected to stay immutable.
[QueryModel]
public sealed class MutableInvoiceReadModel
{
    public string Id { get; set; } = string.Empty;
}

[AggregateRoot]
public sealed class WriteSideInvoiceAggregate
{
    [Identity]
    public string Id { get; } = "write-side";
}

[DomainService]
public sealed class DispatchPricingPolicy
{
}

// XMoleculesCQRS0005
// Violates because a projection depends on the write-side aggregate root.
[Projection]
public sealed class ProjectionUsingAggregateRoot
{
    private readonly WriteSideInvoiceAggregate _aggregate = default!;
}

public sealed class BrokenInvoiceHandlers
{
    // XMoleculesCQRS0002
    // Violates because a command handler accepts a query model instead of a command.
    [CommandHandler]
    public void Handle(MutableInvoiceReadModel model)
    {
    }

    // XMoleculesCQRS0003
    // Violates because a query handler returns a write-side aggregate root.
    [QueryHandler]
    public WriteSideInvoiceAggregate Handle(FindBrokenInvoice query)
    {
        return new WriteSideInvoiceAggregate();
    }

    // XMoleculesCQRS0006
    // Violates because a command dispatcher returns a domain service instead of
    // dispatching commands as an application concern.
    [CommandDispatcher(Dispatches = "Samples.Bad.Commands.CreateBrokenInvoice")]
    public DispatchPricingPolicy Dispatch(CreateBrokenInvoice command)
    {
        return new DispatchPricingPolicy();
    }
}

[Command(Name = "CreateBrokenInvoice", Namespace = "Samples.Bad.Commands")]
public readonly record struct CreateBrokenInvoice(decimal Amount);

// XMoleculesHexagonal0001
// Violates because the application core depends on a primary port instead of
// owning the use-case boundary itself.
[Application]
public sealed class ApplicationCoreDependingOnPort
{
    private readonly IPrimaryCommandPort _port = default!;
}

// XMoleculesHexagonal0002
// Violates because a primary port references a primary adapter.
[PrimaryPort]
public interface IPrimaryCommandPort
{
    void Execute(HttpPrimaryAdapter adapter);
}

// XMoleculesHexagonal0003
// Violates because a secondary port references a secondary adapter.
[SecondaryPort]
public interface ISecondaryStoragePort
{
    void Save(SqlSecondaryAdapter adapter);
}

// XMoleculesHexagonal0004
// Violates because the primary adapter is not wired through a matching port.
[PrimaryAdapter]
public sealed class HttpPrimaryAdapter
{
}

// XMoleculesHexagonal0005
// Violates because the secondary adapter is not wired through a matching port.
[SecondaryAdapter]
public sealed class SqlSecondaryAdapter
{
}
