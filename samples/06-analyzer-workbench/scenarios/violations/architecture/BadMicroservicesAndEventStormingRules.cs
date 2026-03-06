using NMolecules.Architecture.EventStorming;
using NMolecules.Architecture.Microservices;

namespace Samples.Block06.AnalyzerWorkbench.BadMicroservicesAndStorming;

[Microservice(Name = "BillingService")]
public sealed class BillingMicroservice
{
}

// XMoleculesMicroservices0001
// Violates because the API gateway is declared without a matching microservice collaboration.
[ApiGateway(Name = "BrokenGateway")]
public sealed class BrokenApiGateway
{
}

// XMoleculesMicroservices0002
// Violates because the BFF is modeled as an interface instead of a concrete component.
[BackendForFrontend(Name = "BrokenPortalBff")]
public interface IBrokenPortalBff
{
}

// XMoleculesMicroservices0003
// Violates because the service contract leaks a concrete microservice implementation.
[ServiceContract(Name = "Billing.Contracts.V1")]
public interface IBillingServiceContract
{
    BillingMicroservice GetImplementation();
}

// XMoleculesMicroservices0004
// Violates because the integration event exposes a concrete microservice.
[IntegrationEvent(Name = "InvoiceCaptured")]
public sealed class InvoiceCaptured
{
    public BillingMicroservice Microservice { get; } = new();
}

// XMoleculesMicroservices0005
// Violates because the saga orchestrator has no valid orchestration model around it.
[SagaOrchestrator(Name = "BrokenFulfillmentSaga")]
public sealed class BrokenFulfillmentSaga
{
}

// XMoleculesMicroservices0006
// Violates because the saga participant depends on the API gateway.
[SagaParticipant(Name = "BrokenInventoryParticipant")]
public sealed class BrokenInventoryParticipant
{
    private readonly BrokenApiGateway _gateway = default!;
}

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
