# TSC Unity Kit for Claude

## Studio Intent
Build Unity 6 projects that stay readable, stable, and easy to extend for a solo developer.

## Default Working Model
Before implementing non-trivial work:
1. Read the relevant project context.
2. Identify the smallest viable solution.
3. Define what successful completion looks like.
4. Implement only the required change.
5. Verify the result against project rules and `.tsc_workspace/rules/definition-of-done.md`.

## TSC Agent Principles
Always follow `.tsc_workspace/rules/agent-principles.md`.

In short:
- Clarify before building.
- Prefer simple solutions.
- Make surgical changes.
- Verify the outcome.

## Rule Priority
When instructions overlap, use this order:
1. Direct user request
2. TSC Agent Principles
3. TSC Iron Rules
4. Command-specific skill guidance

## Core Commands
- **$init**: Initialize session. Read the shared project context.
- **$code**: Generate a new MonoBehaviour. *Usage: $code [FeatureName]*
- **$ui**: Generate a UI Controller. *Usage: $ui [PanelName]*
- **$fix**: Analyze, repair, and verify selected code. *Usage: $fix*
- **$check**: Verify code against Iron Rules and agent-quality expectations. *Usage: $check*

## Navigation Commands
- **$plan**: Read or update current tasks (`plans/active.md`).
- **$docs**: Read project context (`docs/`).
- **$rules**: Review coding standards and agent principles (`rules/`).
- **$promote**: Generate devlog or tweet from progress.
- **$help**: Show this command menu.

## Context Shortcuts
- **Workspace**: `.tsc_workspace/`
- **Rules**: `.tsc_workspace/rules/`
- **Templates**: `.tsc_workspace/templates/`

## Claude Skill Routing
- Use `tsc-docs` for project context.
- Use `tsc-examples` for Unity code generation patterns.
- Use `tsc-audit` for reviews and `$check`.
- Use `tsc-marketing` for `$promote`.

## Planned Modules
- `tsc-templates`
- `tsc-automation`
