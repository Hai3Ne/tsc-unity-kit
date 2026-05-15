# Definition of Done

Một tác vụ chỉ được xem là hoàn tất khi thỏa các điều kiện phù hợp dưới đây.

## Với mọi thay đổi
- Mục tiêu của thay đổi đã được đáp ứng rõ ràng.
- Phạm vi chỉnh sửa không vượt quá nhu cầu thực tế.
- Không để lại mâu thuẫn với `coding-standard.md` hoặc `agent-principles.md`.
- Kết quả đã được kiểm tra bằng bằng chứng phù hợp: build, test, audit, hoặc đọc lại trực tiếp.

## Với code mới
- Tuân thủ TSC Iron Rules.
- Dùng `Awaitable` cho async flow khi cần.
- Dependency được khai báo rõ và xử lý an toàn.
- Không đưa thêm abstraction nếu chưa có nhu cầu thật.

## Với bug fix
- Xác định được failure mode hoặc nguyên nhân có khả năng cao nhất.
- Có cách xác minh lỗi đã hết.
- Không vá thêm các hành vi không liên quan.

## Với tài liệu và workflow
- Nội dung mới không làm lệch các tài liệu nguồn chuẩn khác.
- Entry point cho Claude và Codex vẫn thống nhất với nhau.
- Nếu thay đổi một quy tắc chung, các bề mặt liên quan phải được rà lại cùng lượt.
