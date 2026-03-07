using NMolecules.Architecture.Layered;

namespace Samples.Architecture.Layered.Violations;

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
