# Decision Log

## 2026-05-15 - Tách code rules khỏi agent behavior

### Quyết định
TSC Unity Kit dùng hai lớp quy tắc riêng:
- `coding-standard.md` cho cách viết code Unity
- `agent-principles.md` cho cách AI agent suy nghĩ và thao tác

### Lý do
Hai loại quy tắc này phục vụ hai mục đích khác nhau. Khi trộn chung, bộ kit dễ trở nên dài dòng và khó mở rộng.

### Hệ quả
- Các entry point như `CLAUDE.md` và `AGENTS.md` phải tham chiếu cả hai lớp.
- Khi review bộ kit, cần kiểm tra cả chất lượng code lẫn chất lượng hành vi của agent.

## 2026-05-15 - `Awaitable` là chuẩn async chính thức

### Quyết định
TSC Unity Kit dùng `Awaitable` làm chuẩn async chính thức cho Unity 6.

### Lý do
Đây là hướng native của Unity 6 và giúp giữ một tiêu chuẩn rõ ràng trong toàn bộ kit.

### Hệ quả
- Checklist audit không được tiếp tục cho phép `UniTask` như một lựa chọn ngang hàng.
- Ví dụ code và tài liệu phải đồng bộ với quyết định này.

## 2026-05-15 - Một lõi chung, nhiều adapter

### Quyết định
Claude và Codex cùng dùng một lõi tri thức chung; các folder theo nền tảng chỉ giữ adapter mỏng.

### Lý do
Việc nhân đôi toàn bộ skill làm tăng nguy cơ drift và chi phí bảo trì.

### Hệ quả
- Nội dung chuẩn được đưa về `.shared/skills/`.
- Các skill trong `.claude/skills/` và `.agents/skills/` chỉ trỏ về nguồn dùng chung khi có thể.
