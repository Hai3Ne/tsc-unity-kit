# Decision Log

## 2026-05-15 - Separate Code Rules from Agent Behavior

### Decision
TSC Unity Kit uses two distinct rule layers:
- `coding-standard.md` for Unity code conventions
- `agent-principles.md` for how AI agents should think and operate

### Rationale
These rule types serve different purposes. Mixing them makes the kit longer, less precise, and harder to evolve.

### Consequences
- Entry points such as `CLAUDE.md` and `AGENTS.md` must reference both layers.
- Reviews of the kit should consider both code quality and agent behavior quality.

## 2026-05-15 - `Awaitable` Is the Official Async Standard

### Decision
TSC Unity Kit uses `Awaitable` as the official async standard for Unity 6.

### Rationale
It is the native Unity 6 direction and keeps the kit aligned around one clear async convention.

### Consequences
- Audit checklists must not continue to allow `UniTask` as an equal alternative.
- Code examples and documentation must stay aligned with this decision.

## 2026-05-15 - One Shared Core, Multiple Adapters

### Decision
Claude and Codex use the same shared knowledge core; platform folders keep only thin adapters.

### Rationale
Duplicating the full skill set increases drift risk and maintenance cost.

### Consequences
- Canonical content lives under `.shared/skills/`.
- Skills in `.claude/skills/` and `.agents/skills/` should point back to shared sources whenever practical.

## 2026-05-15 - Split Workspace Docs into Design and Development

### Decision
TSC Unity Kit uses two primary documentation branches under `.tsc_workspace/docs/`:
- `game-design/`
- `development/`

### Rationale
Game design documents and engineering documents serve different audiences and evolve at different speeds. Keeping them separate makes the workspace easier to navigate and scale.

### Consequences
- Player-facing design material belongs under `game-design/`.
- Technical architecture, implementation notes, QA, pipelines, and release notes belong under `development/`.
