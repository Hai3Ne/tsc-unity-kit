# TSC Kit Review v1

## Purpose
This document reviews the current state of TSC Unity Kit and defines the direction for the next upgrade cycle.

The current goal is not to add as many new features as possible. The goal is to make the kit sharper:
- fewer duplicated rules
- fewer conflicting instructions
- clearer separation between the shared core and tool-specific adapters
- stronger support for both Claude and Codex

## Executive Summary
TSC Unity Kit already has a strong core:
- a clear Unity 6 technical point of view
- a modular skill-based structure
- a recognizable coding style
- a good foundation for AI-assisted solo development

The main issue is not missing capability. The main issue is **drift**:
- older rules still coexist with newer ones
- Claude and Codex keep the same knowledge in separate places
- some documents still describe the kit as it used to be rather than how it now wants to operate

The next phase should focus on **consolidation before expansion**.

## What Is Working Well

### 1. Strong Unity-Specific Identity
The kit is not generic. It has concrete technical opinions:
- Unity 6 LTS
- `Awaitable` over coroutines
- serialized private fields
- cached component access
- event cleanup in `OnDestroy`

This gives the kit a real point of view instead of turning it into a loose prompt collection.

### 2. Clear Skill Separation
The current skill split is sensible:
- `tsc-audit`
- `tsc-docs`
- `tsc-examples`
- `tsc-templates`
- `tsc-automation`
- `tsc-marketing`

These categories are easy to understand and provide a good map for future growth.

### 3. Good Fit for Solo Development
The kit favors:
- readable code
- restrained architecture
- repeatable habits
- practical defaults

That suits a solo developer better than a heavy enterprise-style framework would.

### 4. The New `agent-principles` Layer Is the Right Move
Separating:
- `coding-standard.md` for code rules
- `agent-principles.md` for agent behavior

is a strong architectural decision.

It lets the kit define both:
- how the code should look
- how the AI should think while producing it

## What Is Not Working Well

### 1. Rule Drift Exists
The clearest example:
- `coding-standard.md` requires `Awaitable`
- `AuditChecklist.md` still allowed `Awaitable` or `UniTask`

Different parts of the kit could therefore approve different outcomes.

### 2. Claude and Codex Duplicate Too Much Content
The same family of skill files existed in both:
- `.claude/skills/`
- `.agents/skills/`

Many of those files were identical copies.

This increases maintenance risk:
- one side may be updated while the other is forgotten
- behavior can diverge unintentionally
- each change requires twice the attention

### 3. The Claude Orchestrator Reflected the Old Model
The previous Claude orchestrator loaded:
- active plan
- coding standard
- tech stack

but not:
- agent principles

The visible Claude entrypoint had already moved forward while the underlying orchestration still reflected the previous kit model.

### 4. Some Modules Were More Named Than Real
`tsc-automation` and `tsc-templates` existed structurally, but were still mostly placeholders.

That is not inherently bad, but it creates a gap between:
- advertised capabilities
- mature capabilities that actually exist today

### 5. Public Documentation Still Carried Legacy Framing
The earlier README emphasized:
- Claude
- Antigravity

while the intended workflow now includes:
- Claude
- Codex

It also had encoding issues that weakened the presentation quality of the kit.

## Design Principle for the Next Version

### One Shared Core, Multiple Adapters
The kit should have one shared core:
- rules
- docs
- templates
- canonical examples
- audit logic

Claude and Codex should differ only where their platforms genuinely differ:
- entrypoint files
- registration or config formats
- small adapter instructions

They should not each keep independent copies of the same doctrine.

## Keep

### Keep the Current Unity Iron Rules
They are opinionated, useful, and aligned with the kit identity.

### Keep the Skill-Based Organization
The modular breakdown is sound and should remain.

### Keep `agent-principles.md`
This is the right new layer and should become part of the default initialization path.

### Keep Claude and Codex as First-Class Targets
The kit should support both explicitly instead of treating one as primary and the other as secondary.

## Merge or Refactor

### 1. Merge Shared Skill Knowledge
Reusable content should move toward one canonical source wherever practical.

Examples:
- audit checklist
- code examples
- shared behavioral rules

Platform folders should ideally become thin wrappers rather than full duplicates.

### 2. Align All Rule Surfaces
Every place that describes TSC behavior should agree on:
- async strategy
- component access
- event lifecycle
- region order
- naming

No rule should survive only because it existed in an older version.

### 3. Update the Orchestrators
Both Claude and Codex should initialize with the same shared context:
- active plan
- coding standard
- agent principles
- tech stack

### 4. Separate Mature Modules from Incubating Modules
Capabilities that are not ready yet should be marked as:
- experimental
- planned
- or internal

The public command surface should emphasize what the kit does well today.

## Remove or De-Emphasize

### 1. Remove Conflicting Legacy Rules
If `Awaitable` is the official TSC standard, `UniTask` should not remain as a silent alternative in the audit checklist.

### 2. De-Emphasize Placeholder Features
Avoid presenting empty modules as if they were already complete workflows.

### 3. Remove Documentation That No Longer Matches the Real Workflow
The README should not keep describing an older product shape after the kit has evolved.

## Target Architecture

```text
.tsc_workspace/
  docs/
    tech-stack.md
    decision-log.md
    TSC_KIT_REVIEW_V1.md
  plans/
    active.md
  rules/
    coding-standard.md
    agent-principles.md
    definition-of-done.md
  templates/

.shared/
  skills/
    audit/
    docs/
    examples/
    templates/
    automation/
    marketing/

.claude/
  config.json
  skills/
    thin adapters to shared skills

.agents/
  skills/
    thin adapters to shared skills

CLAUDE.md
AGENTS.md
README.md
```

The exact folder names can still change, but the principle should remain:
- one doctrine
- one canonical source
- thin adapters for each tool

## Recommended Next Actions

### Phase 1: Consolidate
1. Remove `UniTask` drift from audit rules.
2. Update the Claude orchestrator to load `agent-principles.md`.
3. Add `definition-of-done.md`.
4. Rewrite the README to reflect Claude + Codex support and fix encoding issues.

### Phase 2: Reduce Duplication
1. Identify which files are truly shared.
2. Create one canonical location for them.
3. Leave only platform-specific glue in `.claude/` and `.agents/`.

### Phase 3: Mature the Kit
1. Decide whether `tsc-automation` and `tsc-templates` should become real modules now or remain hidden until they are ready.
2. Add a lightweight decision log.
3. Expand `$check` from syntax compliance into broader kit-quality review.

## Final Judgment
The kit does not need to become larger yet. It needs to become cleaner first.

The best next version is not the one with the most commands. It is the one where:
- every rule agrees with every other rule
- Claude and Codex behave consistently
- each module earns its place
- the whole kit feels like a studio system rather than a folder of partially overlapping prompts
