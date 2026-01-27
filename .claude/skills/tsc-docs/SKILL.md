---
name: tsc-docs
description: Documentation Access Skill. Maps natural language queries to .tsc_workspace/docs/ ($docs).
---

# TSC Docs Skill

## When to use this skill
- **Query:** When user runs `$docs [Topic]`.
- **Search:** When asking about game design (GDD) or tech choices.

## How to Search ($docs)
1.  **Target:** Search `.tsc_workspace/docs/` recursively.
2.  **Match:** Find file matching the topic (e.g., `GDD.md`).
3.  **Read:** Return content of that file only.
