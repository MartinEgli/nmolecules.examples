using NMolecules.Bricks;

namespace Samples.Block04.Bricks;

// These sample-only meta attributes describe richer member-cardinality contracts
// that a team could layer on top of Bricks. The current Bricks package does not
// enforce them automatically; they serve as concrete patterns for future custom
// analyzers or runtime validators in a domain-specific attribute ecosystem.

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class RequireExactlyOneMemberAttribute : Attribute
{
    public RequireExactlyOneMemberAttribute(Type memberAttributeType)
    {
        MemberAttributeType = memberAttributeType;
    }

    public Type MemberAttributeType { get; }
}

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class RequireAllMembersAttribute : Attribute
{
    public RequireAllMembersAttribute(params Type[] memberAttributeTypes)
    {
        MemberAttributeTypes = memberAttributeTypes ?? Array.Empty<Type>();
    }

    public Type[] MemberAttributeTypes { get; }
}

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class RequireMemberCountAttribute : Attribute
{
    public RequireMemberCountAttribute(Type memberAttributeType, int count)
    {
        MemberAttributeType = memberAttributeType;
        Count = count;
    }

    public Type MemberAttributeType { get; }

    public int Count { get; }
}

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class RequireExclusiveChoiceAttribute : Attribute
{
    public RequireExclusiveChoiceAttribute(Type leftMemberAttributeType, Type rightMemberAttributeType)
    {
        LeftMemberAttributeType = leftMemberAttributeType;
        RightMemberAttributeType = rightMemberAttributeType;
    }

    public Type LeftMemberAttributeType { get; }

    public Type RightMemberAttributeType { get; }
}

[AttributeUsage(AttributeTargets.Property)]
public sealed class BillingContractIdAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property)]
public sealed class SourceSystemAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property)]
public sealed class TargetSystemAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property)]
public sealed class ApprovalSignerAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property)]
public sealed class EmailChannelAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property)]
public sealed class PaperMailChannelAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Class)]
[BillingDomainRole]
[RequireExactlyOneMember(typeof(BillingContractIdAttribute))]
public sealed class BillingDocumentAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Class)]
[BillingDomainRole]
[RequireAllMembers(typeof(SourceSystemAttribute), typeof(TargetSystemAttribute))]
public sealed class TransferMappingAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Class)]
[BillingDomainRole]
[RequireMemberCount(typeof(ApprovalSignerAttribute), 2)]
public sealed class DualApprovalPolicyAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Class)]
[BillingDomainRole]
[RequireExclusiveChoice(typeof(EmailChannelAttribute), typeof(PaperMailChannelAttribute))]
public sealed class SingleDeliveryChannelAttribute : Attribute
{
}

public static class BillingAttributeContractPatterns
{
}

[BillingDocument]
public sealed class CustomerContractRecord
{
    [BillingContractId]
    public string ContractId { get; } = "C-2026-001";

    public string CustomerName { get; } = "Contoso";
}

[BillingDocument]
public sealed class CustomerContractRecordMissingId
{
    public string CustomerName { get; } = "Northwind";
}

[BillingDocument]
public sealed class CustomerContractRecordWithTwoIds
{
    [BillingContractId]
    public string ContractId { get; } = "C-2026-002";

    [BillingContractId]
    public string LegacyContractId { get; } = "LEG-9002";
}

[TransferMapping]
public sealed class SettlementTransferRoute
{
    [SourceSystem]
    public string Source { get; } = "CRM";

    [TargetSystem]
    public string Target { get; } = "Ledger";
}

[TransferMapping]
public sealed class SettlementTransferRouteMissingTarget
{
    [SourceSystem]
    public string Source { get; } = "CRM";
}

[DualApprovalPolicy]
public sealed class ManualDiscountApprovalPolicy
{
    [ApprovalSigner]
    public string RiskReviewer { get; } = "risk-team";

    [ApprovalSigner]
    public string FinanceReviewer { get; } = "finance-team";
}

[DualApprovalPolicy]
public sealed class ManualDiscountApprovalPolicyWithOneSigner
{
    [ApprovalSigner]
    public string RiskReviewer { get; } = "risk-team";
}

[SingleDeliveryChannel]
public sealed class InvoiceDispatchByEmail
{
    [EmailChannel]
    public string EmailAddress { get; } = "billing@contoso.example";
}

[SingleDeliveryChannel]
public sealed class InvoiceDispatchByPaperMail
{
    [PaperMailChannel]
    public string PostalAddress { get; } = "Main Street 1";
}

[SingleDeliveryChannel]
public sealed class InvoiceDispatchWithBothChannels
{
    [EmailChannel]
    public string EmailAddress { get; } = "billing@contoso.example";

    [PaperMailChannel]
    public string PostalAddress { get; } = "Main Street 1";
}
