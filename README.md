# TSC Unity Kit

**Two Sleepy Cats Studio**

![Unity 6](https://img.shields.io/badge/Unity-6_LTS-000000?style=for-the-badge&logo=unity)
![Claude Code](https://img.shields.io/badge/Claude_Code-supported-d97757?style=for-the-badge&logo=anthropic)
![Codex](https://img.shields.io/badge/Codex-supported-111111?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Active-success?style=for-the-badge)

## Tổng quan
**TSC Unity Kit** là bộ khung phát triển Unity 6 dành cho quy trình solo development có AI hỗ trợ. Mục tiêu của kit là giúp dự án đi nhanh nhưng vẫn giữ được code sạch, kiến trúc rõ, và thói quen làm việc nhất quán.

Kit hiện hỗ trợ hai môi trường chính:
- **Claude** qua `CLAUDE.md` và `.claude/skills/`
- **Codex** qua `AGENTS.md` và `.agents/skills/`

## Triết lý
- Một lõi chung cho toàn bộ quy tắc và tri thức dự án
- Nhiều adapter mỏng cho từng công cụ AI
- Ưu tiên giải pháp đơn giản, kiểm chứng được, và phù hợp với Unity 6

## Khởi động nhanh
1. Clone repository.
2. Mở project bằng Unity 6 Hub.
3. Chạy `$init` trong môi trường AI đang dùng để nạp ngữ cảnh lõi.

## Cấu trúc chính
- `.tsc_workspace/rules/`: chuẩn code và nguyên tắc làm việc
- `.tsc_workspace/docs/`: tài liệu kỹ thuật, review, và quyết định
- `.shared/skills/`: nguồn skill dùng chung
- `.claude/skills/`: adapter cho Claude
- `.agents/skills/`: adapter cho Codex

## Lệnh chính
- `$init`: khởi tạo phiên làm việc
- `$code [Feature]`: sinh MonoBehaviour theo chuẩn TSC
- `$ui [Panel]`: sinh UI Controller
- `$fix`: phân tích, sửa, và xác minh lỗi
- `$check`: audit code theo Iron Rules và chất lượng thay đổi
- `$docs [Topic]`: đọc tài liệu dự án

## Nguồn tham chiếu quan trọng
- `CLAUDE.md`
- `AGENTS.md`
- `.tsc_workspace/rules/coding-standard.md`
- `.tsc_workspace/rules/agent-principles.md`
- `.tsc_workspace/rules/definition-of-done.md`

## License
Project này dùng giấy phép MIT. Xem `LICENSE` để biết chi tiết.

Thông tin attribution cho bên thứ ba nằm trong `THIRD_PARTY_NOTICES.md`.
