---
name: tsc-unity-kit
description: Core orchestrator for Two Sleepy Cats Studio. Initializes shared context and delegates to specialized skills.
---

# TSC Unity Kit Orchestrator for Codex

## Khi nào dùng
- `$init`
- `$plan`
- Khi cần route yêu cầu chung sang skill phù hợp

## Cách khởi tạo
Khi chạy `$init`, chỉ load phần lõi sau:
1. `.tsc_workspace/plans/active.md`
2. `.tsc_workspace/rules/coding-standard.md`
3. `.tsc_workspace/rules/agent-principles.md`
4. `.tsc_workspace/rules/definition-of-done.md`
5. `.tsc_workspace/docs/tech-stack.md`

Sau đó báo:

```text
> [TSC] System Online (Unified Core Mode)
> [LOAD] Active Plan + Coding Standard + Agent Principles + Definition of Done + Tech Stack
> [CMD] Ready. Core Modules: Audit, Docs, Examples, Marketing.
```

## Cách điều phối
- `$code` -> `tsc-examples`
- `$check` -> `tsc-audit`
- `$docs` -> `tsc-docs`
- `$promote` -> `tsc-marketing`

## Module đang ươm
- `tsc-templates`
- `tsc-automation`

Hai module này vẫn tồn tại để phát triển tiếp, nhưng chưa nên được xem là capability trưởng thành của kit.
