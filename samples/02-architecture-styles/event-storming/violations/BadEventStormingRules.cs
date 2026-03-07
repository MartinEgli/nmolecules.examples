using NMolecules.Architecture.EventStorming;

namespace Samples.Architecture.EventStorming.Violations;

[Aggregate(Name = "BrokenOrderAggregate")]
public sealed class BrokenOrderAggregate
{
}

// XMoleculesEventStorming0001
// Violates because the actor directly operates on the aggregate instance.
[Actor(Name = "BrokenActor")]
public interface IBrokenActor
{
    void OperateOn(BrokenOrderAggregate aggregate);
}

// XMoleculesEventStorming0002
// Violates because the command is not part of a valid event-storming flow.
[Command(Name = "BrokenCommand")]
public sealed class BrokenCommand
{
}

// XMoleculesEventStorming0003
// Violates because the policy is not wired to valid event-storming message flow.
[Policy(Name = "BrokenPolicy")]
public sealed class BrokenPolicy
{
}

// XMoleculesEventStorming0004
// Violates because the read model depends on the aggregate.
[ReadModel(Name = "BrokenReadModel")]
public sealed class BrokenReadModel
{
    private readonly BrokenOrderAggregate _aggregate = default!;
}

// XMoleculesEventStorming0005
// Violates because the external system directly calls the aggregate.
[ExternalSystem(Name = "BrokenExternalSystem")]
public interface IBrokenExternalSystem
{
    void Call(BrokenOrderAggregate aggregate);
}

[DomainEvent(Name = "BrokenDomainEvent")]
public sealed class BrokenStormEvent
{
}
