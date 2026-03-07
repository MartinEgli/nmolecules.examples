using NMolecules.Architecture.Cqrs;

namespace Samples.Architecture.Cqrs.Violations;

// XMoleculesCrossStyle0002
// Violates because CQRS markers are used without Layered, Onion, or Hexagonal
// as the enclosing structural style for the compilation.
[QueryModel]
public sealed class DetachedProjection
{
}
