using NMolecules.DDD;

// Violates because the module references bounded context "Sales",
// but only "Billing" is declared in this compilation.
[assembly: BoundedContext(Id = "Billing", Name = "Billing")]
[module: Module(Id = "Accounts", Name = "Accounts", BoundedContextId = "Sales")]

namespace Samples.Block06.AnalyzerWorkbench.ModuleUnknownContext;

public static class Marker
{
}
