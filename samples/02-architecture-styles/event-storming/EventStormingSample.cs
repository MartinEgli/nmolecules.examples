using NMolecules.Architecture.EventStorming;

[assembly: Actor(Name = "Customer", Description = "Primary business actor.")]
[module: DomainEvent(Name = "OrderPlaced", Description = "Order has been submitted.")]

namespace Samples.Architecture.EventStorming;

[Actor(Name = "SupportAgent", Description = "Handles escalated support flows.")]
public interface ISupportActor
{
}

[Command(Name = "PlaceOrder", Description = "Initiates order placement.")]
public sealed class PlaceOrder
{
}

[Aggregate(Name = "Order", Description = "Aggregate boundary for order lifecycle.")]
public sealed class OrderBoundary
{
}

[Policy(Name = "ReserveInventory", Description = "Reserves stock after order placement.")]
public sealed class ReserveInventoryPolicy
{
}

[ReadModel(Name = "OrderSummary", Description = "Read-side order overview model.")]
public sealed class OrderSummary
{
}

[ExternalSystem(Name = "PaymentGateway", Description = "External payment provider.")]
public interface IPaymentGateway
{
}

[DomainEvent(Name = "PaymentCaptured", Description = "Payment was captured successfully.")]
public sealed class PaymentCaptured
{
}
