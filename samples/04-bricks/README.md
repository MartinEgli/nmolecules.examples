# Block 04: Bricks

This block demonstrates custom role and rule modeling via `NMolecules.Bricks`.
It now also contains the Bricks-specific analyzer violations that used to be mixed into the analyzer workbench.

## Why This Block Exists

Some teams need architecture roles that are specific to their domain language.
Bricks lets you define those roles and constraints without creating a custom analyzer for every naming pattern.

## What You Learn

- role assignment via `[Role]`
- custom marker aliases via `[RoleAlias]`
- generic dependency policies via `[Rule]`
- expressive alias markers such as `Billing*RoleAttribute`
- centralized role/rule constants (`BillingRoles`, `BillingRules`)
- typed role-id and rule-id access via `RoleId` and `RuleId` alongside attribute-safe string constants
- rule-message customization and dedicated rule-filter attributes
- sample rule declarations for every optional `Rule` field
- conceptual member-cardinality patterns for custom brick ecosystems:
  exactly one marker, required X+Y markers, fixed-count markers, and XOR markers

## Code Walkthrough

- `BricksSample.cs` is now only the small entry/index file for the sample block
- `Samples.Block04.Bricks.Violations.csproj` contains the intentionally broken custom-role rule declarations
- `scenarios/billing-contracts/catalog/` contains the centralized role and rule catalogs
- `scenarios/billing-contracts/roles/` contains the alias-style custom role markers
- `scenarios/billing-contracts/rules/` contains the assembly-level dependency rules, including one example for every optional `Rule` filter attribute
- `scenarios/billing-contracts/rules/BillingAttributeContractPatterns.cs` shows custom attribute-contract patterns that teams can layer on top of Bricks
- `scenarios/billing-contracts/domain/` contains the domain policy and repository contract
- `scenarios/billing-contracts/application/` contains the orchestration use case
- `scenarios/billing-contracts/infrastructure/` contains the infrastructure implementation
- `scenarios/billing-contracts/filter-scenarios/` contains concrete class and member names for `Message`, `Excluded*`, and `Required*` filter scenarios

## Exercises

1. Add a second rule (`RequireDependency`) between application and domain roles.
2. Extend the attribute-contract sample with a fifth pattern, for example "at least one of three markers".
3. Add a new custom alias attribute for a reporting role and annotate one type.
4. Build `Samples.Block04.Bricks.Violations.csproj` and inspect the invalid rule configuration plus the forbidden domain-to-infrastructure dependency.
