using NMolecules.Architecture.Onion.Classic;
using NMolecules.Architecture.Onion.Simplified;
using NMolecules.DDD;

[assembly: BoundedContext(Id = "BC-ONION", Name = "OnionMix")]

namespace Samples.Architecture.OnionSimplified.Violations;

// XMoleculesCrossStyle0003
// Violates because the same compilation mixes classic onion and simplified onion markers.
[DomainModelRing]
public sealed class ClassicOnionDomain
{
}

[ApplicationServiceRing]
public sealed class ClassicOnionApplicationRing
{
}

// XMoleculesOnion0005
// Violates because the simplified onion marker now appears inside a compilation
// that already models classic onion.
[DomainRing]
public sealed class SimplifiedOnionDomain
{
}
