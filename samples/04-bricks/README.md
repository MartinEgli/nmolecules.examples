# Block 04: Bricks

This block demonstrates custom role and rule modeling via `NMolecules.Bricks`.

## Why This Block Exists

Some teams need architecture roles that are specific to their domain language.
Bricks lets you define those roles and constraints without creating a custom analyzer for every naming pattern.

## What You Learn

- role assignment via `[Role]`
- custom marker aliases via `[RoleAlias]`
- generic dependency policies via `[Rule]`
- specialization via derived role attributes (`Billing*RoleAttribute`)
- centralized role/rule constants (`BillingRoles`, `BillingRules`)
- rule-message customization and filtering fields

## Code Walkthrough

- `BricksSample.cs` defines a small billing role model
- the assembly-level rule forbids domain-to-infrastructure dependencies
- custom marker attributes map to brick roles
- role and rule keys are centralized in dedicated constants classes
- an application service depends on a repository contract, not infrastructure implementation

## Exercises

1. Add a second rule (`RequireDependency`) between application and domain roles.
2. Add a new custom alias attribute for a reporting role and annotate one type.
3. Intentionally add a domain-to-infrastructure dependency and inspect the diagnostics.
