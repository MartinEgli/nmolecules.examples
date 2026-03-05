using NMolecules.Architecture.Microservices;

[assembly: Microservice(Name = "BillingService", Description = "Billing microservice boundary.")]
[module: IntegrationEvent(Name = "InvoicePaid", Description = "Invoice has been paid.")]

namespace Samples.Architecture.Microservices;

[Microservice(Name = "OrdersService", Description = "Order management service boundary.")]
public sealed class OrdersServiceBoundary
{
}

[ApiGateway(Name = "EdgeGateway", Description = "Ingress API gateway.")]
public sealed class EdgeGateway
{
}

[BackendForFrontend(Name = "CustomerPortalBff", Description = "BFF for web portal.")]
public interface ICustomerPortalBff
{
}

[ServiceContract(Name = "Orders.Contract.V1", Description = "Cross-service contract.")]
public interface IOrdersContract
{
}

[IntegrationEvent(Name = "OrderPaid", Description = "Published after successful payment.")]
public sealed class OrderPaid
{
}

[SagaOrchestrator(Name = "FulfillmentSaga", Description = "Coordinates fulfillment workflow.")]
public sealed class FulfillmentSaga
{
}

[SagaParticipant(Name = "InventoryService", Description = "Reserves stock in saga workflow.")]
public readonly struct InventoryParticipant
{
}
