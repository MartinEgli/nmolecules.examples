using NMolecules.DDD;

namespace Samples.Block06.AnalyzerWorkbench;

[ValueObject]
public readonly record struct CartId(string Value);

[AggregateRoot]
public sealed class GoodCartAggregate
{
    public GoodCartAggregate(CartId id)
    {
        Id = id;
    }

    [Identity]
    public CartId Id { get; }
}

[Repository]
public interface IGoodCartRepository
{
    GoodCartAggregate? FindById(CartId id);
}

[DomainService]
public sealed class GoodPricingDomainService
{
    public decimal ApplyDomainDiscount(decimal grossAmount)
    {
        return grossAmount * 0.95m;
    }
}

[ApplicationService]
public sealed class GoodCheckoutApplicationService
{
    private readonly IGoodCartRepository _repository;
    private readonly GoodPricingDomainService _pricingDomainService;

    public GoodCheckoutApplicationService(
        IGoodCartRepository repository,
        GoodPricingDomainService pricingDomainService)
    {
        _repository = repository;
        _pricingDomainService = pricingDomainService;
    }

    public decimal Checkout(CartId id, decimal amount)
    {
        _ = _repository.FindById(id);
        return _pricingDomainService.ApplyDomainDiscount(amount);
    }
}
