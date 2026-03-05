using NMolecules.DDD;
using NMolecules.Persistence.EntityFramework;

[assembly: BoundedContext("Billing", Id = "BC-BILLING")]
[assembly: Module("Orders", Id = "MOD-ORDERS", BoundedContextId = "BC-BILLING")]

namespace Samples.Block05.EntityFramework;

[EfDbContext(
    "BillingDbContext",
    BoundedContextId = "BC-BILLING",
    ModuleId = "MOD-ORDERS")]
public sealed class BillingDbContextMarker
{
}

[ValueObject]
public readonly record struct OrderId(string Value);

[ValueObject]
[EfOwnedValueObject(Owner = nameof(Order))]
public readonly record struct Money(decimal Amount, string Currency);

[AggregateRoot]
[EfEntityType("orders", Schema = "billing")]
public sealed class Order
{
    private Money _total;

    public Order(OrderId id, Money total)
    {
        Id = id;
        _total = total;
    }

    [Identity]
    public OrderId Id { get; }

    [EfBackingField(nameof(_total))]
    [EfValueConverter(typeof(MoneyToDecimalConverter))]
    public Money Total => _total;

    [EfConcurrencyToken(Strategy = "rowversion")]
    public byte[] Version { get; private set; } = Array.Empty<byte>();

    [EfIgnore(Reason = "Derived display field for UI only.")]
    public string Display => $"{Id.Value}: {Total.Amount:0.00} {Total.Currency}";
}

public sealed class MoneyToDecimalConverter
{
}
