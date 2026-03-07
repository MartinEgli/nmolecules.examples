using NMolecules.Architecture.Layered;
using NMolecules.Architecture.Onion.Classic;

namespace Samples.Architecture.Layered.Violations;

[InfrastructureRing]
public sealed class MixedOnionInfrastructureRing
{
}

// XMoleculesCrossStyle0001
// Violates because layered and onion markers are mixed in one compilation.
[DomainLayer]
public sealed class DomainLayerUsingOnionInfrastructureRing
{
    private readonly MixedOnionInfrastructureRing _infrastructure = default!;
}
