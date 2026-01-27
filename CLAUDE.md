# TSC Command Palette

## Core Commands
- **$Init**:  Initialize session. Reads `active.md`, `coding-standard.md`, and `docs/`.
- **$Code**:  Generate a new MonoBehaviour. *Usage: $Code [FeatureName]*
- **$UI**:    Generate a UI Controller. *Usage: $UI [PanelName]*
- **$Fix**:   Analyze and repair selected code. *Usage: $Fix*
- **$Check**: Verify code against "Iron Rules". *Usage: $Check*

## Navigation Commands
- **$Plan**:  Read/Update current tasks (`plans/active.md`).
- **$Docs**:  Read project context (`docs/`).
- **$Rules**: Review coding standards (`rules/coding-standard.md`).
- **$Help**:  Show this command menu.

## Context Shortcuts
- **Workspace**: `.tsc_workspace/`
- **Templates**: `.tsc_workspace/templates/`
