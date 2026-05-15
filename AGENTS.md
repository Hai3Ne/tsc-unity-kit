# TSC Unity Kit for Codex

## Working Principles
Follow `.tsc_workspace/rules/agent-principles.md` while working in this repository:
- Clarify before building.
- Prefer simple solutions.
- Make surgical changes.
- Verify the outcome.

## Rule Priority
1. Direct user request
2. TSC Agent Principles
3. TSC Iron Rules
4. Command-specific skill guidance

## Core Commands
- **$init**: Initialize session. Read `plans/active.md`, `rules/coding-standard.md`, `rules/agent-principles.md`, and relevant docs.
- **$code**: Generate a new MonoBehaviour. *Usage: $code [FeatureName]*
- **$ui**: Generate a UI Controller. *Usage: $ui [PanelName]*
- **$fix**: Analyze, repair, and verify selected code. *Usage: $fix*
- **$check**: Verify code against Iron Rules and agent-quality expectations. *Usage: $check*

## Navigation Commands
- **$plan**: Read or update current tasks (`plans/active.md`).
- **$docs**: Read project context (`docs/`).
- **$rules**: Review standards and principles (`rules/`).
- **$promote**: Generate devlog or tweet from progress.
- **$help**: Show this command menu.

## Context Shortcuts
- **Workspace**: `.tsc_workspace/`
- **Rules**: `.tsc_workspace/rules/`
- **Templates**: `.tsc_workspace/templates/`
