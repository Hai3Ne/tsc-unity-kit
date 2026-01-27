# TSC Command Palette

## Core Commands
- **$init**:  Initialize session. Reads `active.md`, `coding-standard.md`, and `docs/`.
- **$code**:  Generate a new MonoBehaviour. *Usage: $code [FeatureName]*
- **$ui**:    Generate a UI Controller. *Usage: $ui [PanelName]*
- **$fix**:   Analyze and repair selected code. *Usage: $fix*
- **$check**: Verify code against "Iron Rules". *Usage: $check*

## Navigation Commands
- **$plan**:  Read/Update current tasks (`plans/active.md`).
- **$docs**:  Read project context (`docs/`).
- **$rules**: Review coding standards (`rules/coding-standard.md`).
- **$help**:  Show this command menu.

## Context Shortcuts
- **Workspace**: `.tsc_workspace/`
- **Templates**: `.tsc_workspace/templates/`
