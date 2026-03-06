using System;
using NMolecules.Bricks;
using NMolecules.DDD;

[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.MissingMetadataBoundedContext]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.SharedSalesBoundedContext]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.RenamedSharedBoundedContext]
[module: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.BillingBoundedContext]

[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.MissingIdModule]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.NamelessModule]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.MissingContextModule]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.UnknownContextModule]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.MismatchedContextModule]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.DuplicateModuleNameFirst]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.DuplicateModuleNameSecond]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.DuplicateModuleContextFirst]
[module: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.DuplicateModuleContextSecond]
[assembly: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.SharedModuleNameFirst]
[module: Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks.SharedModuleNameSecond]

// BRK-BAD-CONFIG is intentionally malformed because the source role is empty.
[assembly: Rule("BRK-BAD-CONFIG", "", "Infrastructure")]
// BRK-BAD-VIOLATION is valid as metadata but is violated by BrickRuleSource below.
[assembly: Rule("BRK-BAD-VIOLATION", "Domain", "Infrastructure")]

namespace Samples.Block06.AnalyzerWorkbench.BadMetadataAndBricks;

// XMoleculesBricks0001
// Violates because a type in role "Domain" depends on a type in role "Infrastructure".
[Role("Domain")]
public sealed class BrickRuleSource
{
    private readonly BrickRuleTarget _target = default!;
}

[Role("Infrastructure")]
public sealed class BrickRuleTarget
{
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class MissingMetadataBoundedContextAttribute : BoundedContextAttribute
{
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class SharedSalesBoundedContextAttribute : BoundedContextAttribute
{
    public SharedSalesBoundedContextAttribute()
    {
        Id = "BC-SHARED";
        Name = "Sales";
        Value = "Sales";
        DependsOnContextIds = new[] { "BC-UNKNOWN", "BC-SHARED", "BC-BILLING", "BC-BILLING" };
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class RenamedSharedBoundedContextAttribute : BoundedContextAttribute
{
    public RenamedSharedBoundedContextAttribute()
    {
        Id = "BC-SHARED";
        Name = "Sales-Renamed";
        Value = "Sales-Renamed";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class BillingBoundedContextAttribute : BoundedContextAttribute
{
    public BillingBoundedContextAttribute()
    {
        Id = "BC-BILLING";
        Name = "Billing";
        Value = "Billing";
        DependsOnContextIds = new[] { "BC-SHARED" };
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class MissingIdModuleAttribute : ModuleAttribute
{
    public MissingIdModuleAttribute()
    {
        Name = "NoIdModule";
        Value = "NoIdModule";
        BoundedContextId = "BC-SHARED";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class NamelessModuleAttribute : ModuleAttribute
{
    public NamelessModuleAttribute()
    {
        Id = "MOD-NAMELESS";
        BoundedContextId = "BC-SHARED";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class MissingContextModuleAttribute : ModuleAttribute
{
    public MissingContextModuleAttribute()
    {
        Id = "MOD-NOCONTEXT";
        Name = "MissingContext";
        Value = "MissingContext";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class UnknownContextModuleAttribute : ModuleAttribute
{
    public UnknownContextModuleAttribute()
    {
        Id = "MOD-UNKNOWN";
        Name = "UnknownContext";
        Value = "UnknownContext";
        BoundedContextId = "BC-UNKNOWN";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class MismatchedContextModuleAttribute : ModuleAttribute
{
    public MismatchedContextModuleAttribute()
    {
        Id = "MOD-MISMATCH";
        Name = "MismatchedContext";
        Value = "MismatchedContext";
        BoundedContextId = "BC-BILLING";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class DuplicateModuleNameFirstAttribute : ModuleAttribute
{
    public DuplicateModuleNameFirstAttribute()
    {
        Id = "MOD-DUPNAME";
        Name = "Orders";
        Value = "Orders";
        BoundedContextId = "BC-SHARED";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class DuplicateModuleNameSecondAttribute : ModuleAttribute
{
    public DuplicateModuleNameSecondAttribute()
    {
        Id = "MOD-DUPNAME";
        Name = "Invoices";
        Value = "Invoices";
        BoundedContextId = "BC-SHARED";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class DuplicateModuleContextFirstAttribute : ModuleAttribute
{
    public DuplicateModuleContextFirstAttribute()
    {
        Id = "MOD-DUPCTX";
        Name = "Ledger";
        Value = "Ledger";
        BoundedContextId = "BC-SHARED";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class DuplicateModuleContextSecondAttribute : ModuleAttribute
{
    public DuplicateModuleContextSecondAttribute()
    {
        Id = "MOD-DUPCTX";
        Name = "Ledger";
        Value = "Ledger";
        BoundedContextId = "BC-BILLING";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class SharedModuleNameFirstAttribute : ModuleAttribute
{
    public SharedModuleNameFirstAttribute()
    {
        Id = "MOD-A";
        Name = "SharedName";
        Value = "SharedName";
        BoundedContextId = "BC-SHARED";
    }
}

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
public sealed class SharedModuleNameSecondAttribute : ModuleAttribute
{
    public SharedModuleNameSecondAttribute()
    {
        Id = "MOD-B";
        Name = "SharedName";
        Value = "SharedName";
        BoundedContextId = "BC-SHARED";
    }
}
