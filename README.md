# TSC Unity Kit

**Two Sleepy Cats Studio**

![Unity 6](https://img.shields.io/badge/Unity-6_LTS-000000?style=for-the-badge&logo=unity)
![Claude Code](https://img.shields.io/badge/Claude_Code-supported-d97757?style=for-the-badge&logo=anthropic)
![Codex](https://img.shields.io/badge/Codex-supported-111111?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Active-success?style=for-the-badge)

## Overview
**TSC Unity Kit** is a Unity 6 development framework for AI-assisted solo development. Its goal is to help projects move quickly while preserving clean code, clear architecture, and consistent working habits.

The kit currently supports two primary environments:
- **Claude** through `CLAUDE.md` and `.claude/skills/`
- **Codex** through `AGENTS.md` and `.agents/skills/`

## Philosophy
- One shared core for project rules and knowledge
- Thin adapters for each AI tool
- Simple, verifiable solutions that fit Unity 6

## Quick Start
1. Clone the repository.
2. Open the project in Unity 6 Hub.
3. Run `$init` in your AI environment to load the shared core context.

## Main Structure
- `.tsc_workspace/rules/`: coding standards and working principles
- `.tsc_workspace/docs/`: technical docs, reviews, and decisions
- `.shared/skills/`: shared skill sources
- `.claude/skills/`: Claude adapters
- `.agents/skills/`: Codex adapters

## Core Commands
- `$init`: initialize the working session
- `$code [Feature]`: generate a TSC-style MonoBehaviour
- `$ui [Panel]`: generate a UI Controller
- `$fix`: analyze, repair, and verify a problem
- `$check`: audit code against Iron Rules and change quality
- `$docs [Topic]`: read project documentation

## Key References
- `CLAUDE.md`
- `AGENTS.md`
- `.tsc_workspace/rules/coding-standard.md`
- `.tsc_workspace/rules/agent-principles.md`
- `.tsc_workspace/rules/definition-of-done.md`

## License
This project is licensed under the MIT License. See `LICENSE` for details.

Third-party attribution is documented in `THIRD_PARTY_NOTICES.md`.
