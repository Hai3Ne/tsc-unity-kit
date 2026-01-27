---
name: tsc-unity-kit
description: Core Orchestrator for Two Sleepy Cats Studio. Manages session initialization and delegates to specialized skills.
---

# TSC Unity Architect (Orchestrator)

## Architecture
This skill acts as the **Central Command**. It delegates tasks to specialized sibling skills:
- **Audit:** `tsc-audit` ($check)
- **Examples:** `tsc-examples` ($code)
- **Docs:** `tsc-docs` ($docs)
- **Automation:** `tsc-automation`
- **Templates:** `tsc-templates`

## When to use this skill
- **Start:** `$init` (Initialize Session).
- **Plan:** `$plan` (Manage Tasks).
- **Route:** When user asks generic questions, route to specific skill.

## How to Initialize ($init)
> **Goal:** Minimized Context Loading
1.  **Read ONLY:**
    -   `.tsc_workspace/plans/active.md` (Current Task)
    -   `.tsc_workspace/rules/coding-standard.md` (Iron Rules)
    -   `.tsc_workspace/docs/tech-stack.md` (Core Tech)
2.  **Report:**
    ```text
    > [TSC] System Online (Modular Mode)
    > [LOAD] Active Plan + Rules + Tech Stack
    > [CMD] Ready. Available Modules: Audit, Examples, Docs.
    ```

## How to Delegate
- **Code Gen:** "For code generation, refer to `tsc-examples` skill patterns."
- **Auditing:** "For code checking, refer to `tsc-audit` skill checklists."
- **Docs:** "For documentation, refer to `tsc-docs` skill mapping."
