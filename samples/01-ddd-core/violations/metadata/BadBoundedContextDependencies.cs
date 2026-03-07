using NMolecules.DDD;

// Violates because the bounded context depends on itself and repeats the same
// target dependency with different casing.
[assembly: BoundedContext(Id = "Billing", Name = "Billing", DependsOnContextIds = new[] { "Billing", "SharedKernel", "sharedkernel" })]

namespace Samples.Block06.AnalyzerWorkbench.BoundedContextDependencies;

public static class Marker
{
}
