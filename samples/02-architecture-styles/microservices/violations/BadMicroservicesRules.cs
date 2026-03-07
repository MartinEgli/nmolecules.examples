using NMolecules.Architecture.Microservices;

namespace Samples.Architecture.Microservices.Violations;

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
