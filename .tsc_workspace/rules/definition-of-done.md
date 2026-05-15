# Definition of Done

A task is complete only when the applicable conditions below are satisfied.

## For Every Change
- The requested outcome has been met clearly.
- The edit scope does not exceed the real need.
- No conflict remains with `coding-standard.md` or `agent-principles.md`.
- The result has been checked with suitable evidence: build, test, audit, or direct inspection.

## For New Code
- It follows TSC Iron Rules.
- It uses `Awaitable` for async flow when needed.
- Dependencies are declared clearly and handled safely.
- No abstraction is added before there is a real need for it.

## For Bug Fixes
- The failure mode or most likely root cause has been identified.
- There is a way to verify that the issue no longer reproduces.
- The fix does not introduce unrelated behavior changes.

## For Documentation and Workflow Changes
- New content does not drift away from the other canonical documents.
- Claude and Codex entrypoints remain aligned.
- If a shared rule changes, all affected surfaces are reviewed in the same pass.
