using NMolecules.DDD;

// Violates because two different module ids map to the same visible module name
// inside the same bounded context.
[assembly: Module(Id = "Accounts.Core", Name = "Accounts", BoundedContextId = "Billing")]
[module: Module(Id = "Accounts.Api", Name = "Accounts", BoundedContextId = "Billing")]

namespace Samples.Block06.AnalyzerWorkbench.ModuleNameMap;

public static class Marker
{
}
