using NMolecules.Architecture.Onion.Simplified;

namespace Samples.Architecture.OnionSimplified;

[DomainRing]
public sealed class BillingDomain
{
}

[ApplicationRing]
public sealed class BillingApplication
{
}

[InfrastructureRing]
public sealed class BillingInfrastructure
{
}
