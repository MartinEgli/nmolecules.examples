using NMolecules.DDD;

namespace Samples.Block01.DddCore.Violations.Examples;

// Intentional violation example:
// Aggregate roots should not depend on application services.
[AggregateRoot]
public sealed class BadCartAggregate
{
    private readonly BadCheckoutApplicationService _appService;

    public BadCartAggregate(BadCheckoutApplicationService appService)
    {
        _appService = appService;
    }

    [Identity]
    public string Id { get; } = "cart-1";
}

[ApplicationService]
public sealed class BadCheckoutApplicationService
{
}

// Intentional violation example:
// Domain services should not depend on application services.
[DomainService]
public sealed class BadPricingDomainService
{
    private readonly BadCheckoutApplicationService _appService;

    public BadPricingDomainService(BadCheckoutApplicationService appService)
    {
        _appService = appService;
    }

    public decimal Calculate(decimal grossAmount)
    {
        _ = _appService;
        return grossAmount * 0.9m;
    }
}

// Intentional violation example:
// Legacy [Service] markers should be replaced by explicit role markers.
[Service]
public sealed class LegacyPricingService
{
}

// Intentional violation example:
// Repositories should not depend directly on other repositories unless composition is approved.
[Repository]
public interface IAccountsRepository
{
}

[Repository]
public interface IPaymentsRepository
{
    void Store(IAccountsRepository accounts);
}

// Intentional violation example:
// Approved repository composition should still use repository contracts, not concrete implementations.
[Repository]
public class ConcreteAccountsRepository
{
}

[Repository]
[AllowRepositoryComposition]
public interface IApprovedButInvalidPaymentsRepository
{
    void Store(ConcreteAccountsRepository accounts);
}
