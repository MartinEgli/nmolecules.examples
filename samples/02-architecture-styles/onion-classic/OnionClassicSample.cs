using NMolecules.Architecture.Onion.Classic;

namespace Samples.Architecture.OnionClassic;

[DomainModelRing]
public sealed class BillingModel
{
}

[DomainServiceRing]
public sealed class BillingPolicyService
{
}

[ApplicationServiceRing]
public sealed class BillingApplicationService
{
}

[InfrastructureRing]
public sealed class BillingInfrastructure
{
}
