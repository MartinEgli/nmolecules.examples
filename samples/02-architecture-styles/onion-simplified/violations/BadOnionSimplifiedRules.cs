using NMolecules.Architecture.Onion.Simplified;

namespace Samples.Architecture.OnionSimplified.Violations;

[ApplicationRing]
public sealed class SimplifiedApplicationRing
{
}

[InfrastructureRing]
public sealed class SimplifiedInfrastructureRing
{
}

// XMoleculesOnion0005
// Violates because the simplified domain ring depends on infrastructure.
[DomainRing]
public sealed class SimplifiedDomainUsingInfrastructure
{
    private readonly SimplifiedInfrastructureRing _infrastructure = default!;
}
