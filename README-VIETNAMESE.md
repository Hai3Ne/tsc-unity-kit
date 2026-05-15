# TSC Unity Kit

**Hướng dẫn sử dụng bằng tiếng Việt**

## Tổng quan
**TSC Unity Kit** là bộ khung phát triển Unity 6 dành cho quy trình solo development có AI hỗ trợ. Mục tiêu của kit là giúp bạn:
- làm việc nhanh hơn
- giữ code sạch và dễ bảo trì
- đồng bộ cách làm việc giữa Claude và Codex
- tránh việc AI tự ý mở rộng kiến trúc vượt quá nhu cầu thật

Kit hiện hỗ trợ hai môi trường chính:
- **Claude** thông qua `CLAUDE.md` và `.claude/skills/`
- **Codex** thông qua `AGENTS.md` và `.agents/skills/`

## Cài đặt ban đầu
1. Clone repository về máy và đặt tại project hiện tại, sau đó mở project Unity 2022 trở lên.
2. Mở Claude hoặc Codex tại thư mục gốc của project.
3. Chạy lệnh `$init` để nạp ngữ cảnh cốt lõi.

Khi `$init` chạy đúng, agent sẽ nạp:
- `.tsc_workspace/plans/active.md`
- `.tsc_workspace/rules/coding-standard.md`
- `.tsc_workspace/rules/agent-principles.md`
- `.tsc_workspace/rules/definition-of-done.md`
- `.tsc_workspace/docs/tech-stack.md`

## Các nguyên tắc cốt lõi
TSC Unity Kit tách rõ hai lớp quy tắc:

### 1. Quy tắc viết code
Nằm trong:
- `.tsc_workspace/rules/coding-standard.md`

Nó quy định những điều như:
- dùng `Awaitable`
- field serialize phải là `private`
- cache component trong `Awake`
- không `GetComponent` trong `Update`
- unsubscribe event trong `OnDestroy`

### 2. Quy tắc làm việc của AI agent
Nằm trong:
- `.tsc_workspace/rules/agent-principles.md`

Nó quy định agent nên:
- làm rõ yêu cầu trước khi code nếu cần
- ưu tiên giải pháp đơn giản
- chỉ sửa đúng phạm vi cần thiết
- kiểm chứng kết quả trước khi xem là hoàn tất

## Các lệnh chính

### `$init`
Khởi tạo phiên làm việc và nạp ngữ cảnh cốt lõi.

### `$code [FeatureName]`
Sinh MonoBehaviour mới theo phong cách TSC.

Ví dụ:
```text
$code PlayerMover
```

### `$ui [PanelName]`
Sinh UI Controller mới cho panel tương ứng.

Ví dụ:
```text
$ui InventoryPanel
```

### `$fix`
Phân tích, sửa lỗi, và xác minh lại kết quả.

### `$check`
Audit code theo:
- TSC Iron Rules
- chất lượng thay đổi
- độ đơn giản
- độ đúng phạm vi

### `$docs [Topic]`
Tìm và đọc tài liệu trong `.tsc_workspace/docs/`.

Ví dụ:
```text
$docs tech-stack
```

### `$plan`
Đọc hoặc cập nhật kế hoạch đang hoạt động trong:
- `.tsc_workspace/plans/active.md`

### `$promote`
Hỗ trợ viết devlog hoặc nội dung mạng xã hội dựa trên tiến độ hiện tại.

## Cấu trúc thư mục

```text
.tsc_workspace/
  docs/        tài liệu kỹ thuật, review, decision log
  plans/       kế hoạch đang hoạt động
  rules/       coding standard, agent principles, definition of done
  templates/   nơi để mở rộng template về sau

.shared/
  skills/      nguồn skill dùng chung

.claude/
  skills/      adapter riêng cho Claude

.agents/
  skills/      adapter riêng cho Codex

CLAUDE.md      entrypoint cho Claude
AGENTS.md      entrypoint cho Codex
README.md      tài liệu chính bằng tiếng Anh
```

## Cách sử dụng hiệu quả
- Trước khi bắt đầu một việc lớn, chạy `$init`.
- Khi cần code mới, ưu tiên `$code` thay vì viết tay từ đầu.
- Trước khi commit hoặc sau một thay đổi lớn, chạy `$check`.
- Khi sửa bug, nên mô tả lỗi rõ ràng để agent có thể xác định failure mode.
- Khi thay đổi quy tắc chung, cần rà soát cả Claude và Codex adapter trong cùng một lượt.

## Module hiện tại

### Đã trưởng thành
- `tsc-audit`
- `tsc-docs`
- `tsc-examples`
- `tsc-marketing`

### Đang ươm
- `tsc-templates`
- `tsc-automation`

Hai module đang ươm vẫn được giữ lại cho hướng phát triển sau này, nhưng hiện tại chưa nên xem là năng lực chính đã hoàn thiện của kit.

## Tài liệu nên đọc tiếp
- `README.md`
- `CLAUDE.md`
- `AGENTS.md`
- `.tsc_workspace/rules/coding-standard.md`
- `.tsc_workspace/rules/agent-principles.md`
- `.tsc_workspace/rules/definition-of-done.md`
- `.tsc_workspace/docs/TSC_KIT_REVIEW_V1.md`
- `.tsc_workspace/docs/decision-log.md`

## Gợi ý workflow mẫu

```text
$init
$docs tech-stack
$code PlayerMover
$check
$plan
```

Workflow trên phù hợp khi bạn bắt đầu một feature mới và muốn đảm bảo code sinh ra vẫn đúng phong cách TSC.
