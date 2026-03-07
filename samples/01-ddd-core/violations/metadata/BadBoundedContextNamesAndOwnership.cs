using NMolecules.DDD;

// Violates because the same bounded-context Id is declared with different names,
// and the module points to a bounded context that is not the owning one here.
[assembly: BoundedContext(Id = "Billing", Name = "Billing Core")]
[module: BoundedContext(Id = "Billing", Name = "Billing Payments")]
[assembly: Module(Id = "Accounts", Name = "Accounts", BoundedContextId = "Sales")]

namespace Samples.Block06.AnalyzerWorkbench.BoundedContextNamesAndOwnership;

public static class Marker
{
}
