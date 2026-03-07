using NMolecules.Architecture.Onion.Classic;

namespace Samples.Architecture.OnionClassic.Violations;

[InfrastructureRing]
public sealed class ClassicInfrastructureRing
{
}

[ApplicationServiceRing]
public sealed class ClassicApplicationServiceRing
{
}

// XMoleculesOnion0001 and XMoleculesOnion0002
// Violates because the classic domain model ring depends on the outer infrastructure ring.
[DomainModelRing]
public sealed class DomainModelRingUsingInfrastructure
{
    private readonly ClassicInfrastructureRing _infrastructure = default!;
}

// XMoleculesOnion0003
// Violates because the classic domain service ring depends on the outer application-service ring.
[DomainServiceRing]
public sealed class DomainServiceRingUsingOuterApplication
{
    private readonly ClassicApplicationServiceRing _application = default!;
}

// XMoleculesOnion0004
// Violates because the application-service ring depends on infrastructure.
[ApplicationServiceRing]
public sealed class ApplicationServiceRingUsingInfrastructure
{
    private readonly ClassicInfrastructureRing _infrastructure = default!;
}
