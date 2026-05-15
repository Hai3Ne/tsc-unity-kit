---
name: tsc-unity-kit
description: Core orchestrator for Two Sleepy Cats Studio. Initializes shared context and delegates to specialized skills.
---

# TSC Unity Kit Orchestrator for Codex

## When to Use
- `$init`
- `$plan`
- When a general request needs routing to the appropriate skill

## Initialization
When `$init` runs, load only:
1. `.tsc_workspace/plans/active.md`
2. `.tsc_workspace/rules/coding-standard.md`
3. `.tsc_workspace/rules/agent-principles.md`
4. `.tsc_workspace/rules/definition-of-done.md`
5. `.tsc_workspace/docs/tech-stack.md`

Then report:

```text
> [TSC] System Online (Unified Core Mode)
> [LOAD] Active Plan + Coding Standard + Agent Principles + Definition of Done + Tech Stack
> [CMD] Ready. Core Modules: Audit, Docs, Examples, Marketing.
```

## Delegation
- `$code` -> `tsc-examples`
- `$check` -> `tsc-audit`
- `$docs` -> `tsc-docs`
- `$promote` -> `tsc-marketing`

## Incubating Modules
- `tsc-templates`
- `tsc-automation`

These modules remain available for future development, but they should not yet be treated as mature kit capabilities.
