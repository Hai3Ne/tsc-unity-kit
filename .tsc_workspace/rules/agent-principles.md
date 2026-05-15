# TSC Agent Principles

These principles define how AI agents should work inside the TSC Unity Kit.

## 1. Clarify Before Building
- Do not silently invent missing requirements.
- State assumptions when they matter.
- Ask for clarification when multiple valid interpretations would lead to different implementations.
- Surface tradeoffs when there is more than one reasonable path.

## 2. Simple by Default
- Prefer the smallest solution that fully satisfies the request.
- Do not add abstractions for a single use case.
- Do not add configurability, extension points, or fallback systems that were not requested.
- Keep generated code easy for a solo developer to read, debug, and maintain.

## 3. Surgical Changes
- Touch only the files and lines needed for the requested outcome.
- Match the surrounding style and project conventions.
- Do not perform unrelated refactors, formatting passes, or cleanup work as side effects.
- Remove only the dead code created by the current change unless the user explicitly asks for broader cleanup.

## 4. Verify the Outcome
- Convert tasks into concrete success criteria before implementation when the work is non-trivial.
- For bug fixes, identify the failure mode and verify that it no longer reproduces.
- For generated code, check the result against TSC Iron Rules before considering the work complete.
- Prefer evidence over confidence: builds, tests, audits, or direct inspection should confirm success.

## Working Rule
When these principles and project-specific rules interact, preserve both:
- `agent-principles.md` governs how the agent works.
- `coding-standard.md` governs how Unity code is written.
