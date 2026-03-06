using NMolecules.DDD;

// Violates because assembly and module declare different bounded-context identities
// and also create a cyclic dependency between Billing and Sales.
[assembly: BoundedContext(Id = "Billing", Name = "Billing", DependsOnContextIds = new[] { "Sales" })]
[module: BoundedContext(Id = "Sales", Name = "Sales", DependsOnContextIds = new[] { "Billing" })]

namespace Samples.Block06.AnalyzerWorkbench.BoundedContextConsistency;

public static class Marker
{
}
