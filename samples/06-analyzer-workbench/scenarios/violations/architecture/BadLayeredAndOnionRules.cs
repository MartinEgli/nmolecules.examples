using NMolecules.Architecture.Layered;
using NMolecules.Architecture.Onion.Classic;
using NMolecules.Architecture.Onion.Simplified;

namespace Samples.Block06.AnalyzerWorkbench.BadArchitecture;

[ApplicationLayer]
public sealed class BillingApplicationLayer
{
}

[InfrastructureLayer]
public sealed class BillingInfrastructureLayer
{
}

[UserInterfaceLayer]
public sealed class BillingUiLayer
{
}

// XMoleculesLayered0001
// Violates because the domain layer depends on the application layer.
[DomainLayer]
public sealed class DomainLayerUsingApplicationLayer
{
    private readonly BillingApplicationLayer _application = default!;
}

// XMoleculesLayered0002
// Violates because the domain layer depends on infrastructure.
[DomainLayer]
public sealed class DomainLayerUsingInfrastructureLayer
{
    private readonly BillingInfrastructureLayer _infrastructure = default!;
}

// XMoleculesLayered0003
// Violates because the domain layer depends on the UI layer.
[DomainLayer]
public sealed class DomainLayerUsingUserInterfaceLayer
{
    private readonly BillingUiLayer _ui = default!;
}

// XMoleculesLayered0004
// Violates because the interface layer depends inward on the domain layer.
[InterfaceLayer]
public sealed class InterfaceLayerUsingDomainLayer
{
    private readonly DomainLayerUsingApplicationLayer _domain = default!;
}

// XMoleculesLayered0005
// Violates because the application layer depends on infrastructure.
[ApplicationLayer]
public sealed class ApplicationLayerUsingInfrastructureLayer
{
    private readonly BillingInfrastructureLayer _infrastructure = default!;
}

// XMoleculesLayered0006
// Violates because infrastructure depends back on the application layer.
[InfrastructureLayer]
public sealed class InfrastructureLayerUsingApplicationLayer
{
    private readonly BillingApplicationLayer _application = default!;
}

[NMolecules.Architecture.Onion.Classic.InfrastructureRing]
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

[DomainRing]
public sealed class SimplifiedDomainRing
{
}

[ApplicationRing]
public sealed class SimplifiedApplicationRing
{
}

[NMolecules.Architecture.Onion.Simplified.InfrastructureRing]
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
