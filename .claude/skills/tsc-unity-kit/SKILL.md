---
name: tsc-unity-kit
description: Efficient Unity 6 context loader. Loads only strict rules and current active tasks to minimize token usage.
---

# TSC Unity Architect (Modular)

## Architecture
This skill uses a modular structure. Each subdirectory is self-documenting:
- **prompts/**: Detailed instructions (`AuditChecklist.md`).
- **examples/**: Code patterns (`MonoBehaviourStyle.cs`).
- **scripts/**: Automation tools → `.tsc_workspace/agents/`
- **references/**: Project docs → `.tsc_workspace/docs/`
- **assets/**: Code templates → `.tsc_workspace/templates/`

## When to use this skill
- **Start:** `$init` (Low token cost).
- **Work:** `$code`, `$plan`, `$fix`.
- **Query:** `$docs` (On-demand reading).

## How to Initialize ($init)
> **Goal:** Minimized Context Loading
1.  **Read ONLY:**
    -   `.tsc_workspace/plans/active.md` (Current Task)
    -   `.tsc_workspace/rules/coding-standard.md` (Iron Rules)
    -   `.tsc_workspace/docs/tech-stack.md` (Core Tech)
2.  **Report:**
    ```text
    > [TSC] System Online
    > [LOAD] Active Plan + Rules + Tech Stack
    > [CMD] Ready
    ```

## How to Generate Code ($code [Feature])
1.  **Consult:** `examples/SKILL.md` for pattern reference.
2.  **Read:** `examples/MonoBehaviourStyle.cs` for structure.
3.  **Generate:** Follow Iron Rules (private fields, Awaitable, Regions).

## How to Audit Code ($check)
1.  **Consult:** `prompts/SKILL.md` for audit logic.
2.  **Load:** `prompts/AuditChecklist.md`.
3.  **Report:** List violations or confirm "PASSED".

## How to Research ($docs [Topic])
1.  **Consult:** `references/SKILL.md` for documentation map.
2.  **Search:** `.tsc_workspace/docs/` for relevant file.
3.  **Read:** Only the requested file (token optimization).
