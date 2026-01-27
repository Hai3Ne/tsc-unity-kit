# References Module

## Purpose
Points to project documentation and design specs.

## Data Source Mapping
**External:** `.tsc_workspace/docs/`
- **tech-stack.md**: Technology choices (Unity 6, Awaitable, UIToolkit).
- **GDD.md**: Game Design Document.
- Future: Architecture diagrams, API specs.

## When to Load
- `$docs [Topic]`: Agent searches `.tsc_workspace/docs/` for related file.
- `$init`: Loads `tech-stack.md` by default for context.

## Current Status
Active. Primary documentation source.
