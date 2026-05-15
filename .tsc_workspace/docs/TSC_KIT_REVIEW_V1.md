# TSC Kit Review v1

## Mục đích
Tài liệu này tổng kết hiện trạng của TSC Unity Kit và xác định hướng đi cho vòng nâng cấp tiếp theo.

Mục tiêu lúc này không phải là thêm thật nhiều tính năng mới. Mục tiêu là làm bộ kit sắc hơn:
- ít rule bị trùng lặp hơn
- ít chỉ dẫn mâu thuẫn hơn
- tách bạch rõ hơn giữa lõi dùng chung và phần adapter riêng cho từng công cụ
- hỗ trợ tốt hơn cho cả Claude lẫn Codex

## Tóm tắt điều hành
TSC Unity Kit hiện đã có một phần lõi khá tốt:
- quan điểm kỹ thuật rõ ràng cho Unity 6
- cấu trúc theo skill khá mô-đun
- phong cách code dễ nhận diện
- nền tảng tốt cho quy trình phát triển solo có AI hỗ trợ

Vấn đề chính hiện tại không phải là thiếu năng lực. Vấn đề chính là **độ lệch dần theo thời gian**:
- rule cũ vẫn đang tồn tại song song với rule mới
- Claude và Codex đang giữ lại cùng một lượng tri thức ở hai nơi khác nhau
- một số tài liệu vẫn mô tả bộ kit theo hình dạng cũ, chưa phản ánh đúng hướng hiện tại

Giai đoạn tiếp theo nên tập trung vào **hợp nhất trước, mở rộng sau**.

## Những điểm đang làm tốt

### 1. Bản sắc Unity rất rõ
Bộ kit này không chung chung. Nó có quan điểm kỹ thuật cụ thể:
- Unity 6 LTS
- ưu tiên `Awaitable` thay vì coroutine
- field serialize là `private`
- cache component
- dọn event trong `OnDestroy`

Điều này giúp kit có cá tính riêng, không biến thành một bộ prompt rời rạc.

### 2. Phân chia nhóm skill hợp lý
Cách chia skill hiện tại khá đúng hướng:
- `tsc-audit`
- `tsc-docs`
- `tsc-examples`
- `tsc-templates`
- `tsc-automation`
- `tsc-marketing`

Các nhóm này dễ hiểu và tạo ra một bản đồ tốt để phát triển về sau.

### 3. Phù hợp với quy trình solo development
Bộ kit đang ưu tiên:
- code dễ đọc
- kiến trúc vừa đủ
- thói quen lặp lại được
- mặc định thực dụng

Đây là những thứ hợp với một solo developer hơn nhiều so với một framework nặng kiểu enterprise.

### 4. Lớp `agent-principles` mới là bước đi đúng
Việc tách:
- `coding-standard.md` cho luật viết code
- `agent-principles.md` cho cách agent làm việc

là một quyết định kiến trúc tốt.

Nó cho phép bộ kit định nghĩa cùng lúc:
- code nên trông như thế nào
- AI nên suy nghĩ ra sao khi tạo ra code đó

## Những điểm chưa tốt

### 1. Đang có hiện tượng lệch rule
Ví dụ rõ nhất:
- `coding-standard.md` yêu cầu dùng `Awaitable`
- `AuditChecklist.md` vẫn cho phép `Awaitable` hoặc `UniTask`

Điều này khiến các phần khác nhau của bộ kit có thể chấp nhận những kết quả khác nhau.

### 2. Claude và Codex đang bị nhân đôi quá nhiều nội dung
Cùng một nhóm file skill hiện đang tồn tại ở cả:
- `.claude/skills/`
- `.agents/skills/`

Nhiều file trong số đó giống hệt nhau.

Điều này làm tăng rủi ro bảo trì:
- một bên được cập nhật, bên còn lại bị quên
- hành vi của hai môi trường có thể lệch nhau mà không hề có chủ ý
- mỗi thay đổi đều tốn gấp đôi sự chú ý

### 3. Claude orchestrator vẫn còn phản ánh mô hình cũ
Orchestrator hiện tại của Claude đang load:
- active plan
- coding standard
- tech stack

nhưng chưa load:
- agent principles

Nghĩa là phần entrypoint nhìn thấy được của Claude đã đi sang phiên bản mới, nhưng skill điều phối bên dưới vẫn còn ở mô hình cũ.

### 4. Một số module hiện mới có tên nhiều hơn là có năng lực thật
`tsc-automation` và `tsc-templates` đã có chỗ đứng trong cấu trúc, nhưng hiện vẫn chủ yếu là placeholder.

Điều này không phải lỗi nghiêm trọng, nhưng nó tạo ra khoảng cách giữa:
- số lượng capability được quảng bá
- số lượng capability thực sự đã trưởng thành

### 5. Tài liệu công khai vẫn còn mang khung kể chuyện cũ
README hiện vẫn nhấn mạnh:
- Claude
- Antigravity

trong khi workflow thực tế mà mình muốn xây dựng bây giờ đã bao gồm:
- Claude
- Codex

Ngoài ra README còn có lỗi encoding, làm giảm cảm giác chỉn chu của bộ kit.

## Nguyên tắc thiết kế cho phiên bản tiếp theo

### Một lõi chung, nhiều adapter
Bộ kit nên có một lõi dùng chung duy nhất:
- rules
- docs
- templates
- ví dụ chuẩn
- logic audit

Claude và Codex chỉ nên khác nhau ở những điểm mà nền tảng của chúng thật sự khác:
- file entrypoint
- format đăng ký hoặc cấu hình
- một số chỉ dẫn adapter nhỏ

Chúng không nên tự giữ hai bản riêng của cùng một học thuyết.

## Nên giữ

### Giữ bộ Unity Iron Rules hiện tại
Chúng có quan điểm rõ ràng, hữu ích, và đúng với bản sắc của kit.

### Giữ cách tổ chức theo skill
Cách chia module hiện tại là hợp lý và nên tiếp tục được dùng.

### Giữ `agent-principles.md`
Đây là lớp mới đúng hướng và nên trở thành một phần mặc định trong quá trình khởi tạo.

### Giữ Claude và Codex như hai mục tiêu hạng nhất
Bộ kit nên hỗ trợ rõ ràng cho cả hai, thay vì để một bên là chính còn bên kia chỉ là phụ.

## Nên hợp nhất hoặc tái cấu trúc

### 1. Hợp nhất tri thức dùng chung của các skill
Những nội dung có thể tái sử dụng nên dần được đưa về một nguồn chuẩn duy nhất.

Ví dụ:
- audit checklist
- code examples
- behavioral rules dùng chung

Các folder theo nền tảng về lý tưởng chỉ nên còn là lớp wrapper mỏng.

### 2. Đồng bộ toàn bộ bề mặt rule
Mọi nơi mô tả hành vi của TSC đều phải thống nhất về:
- async strategy
- component access
- event lifecycle
- region order
- naming

Không rule nào nên tồn tại chỉ vì nó từng có mặt trong phiên bản cũ.

### 3. Cập nhật lại orchestrator
Cả Claude lẫn Codex nên khởi tạo với cùng một lõi ngữ cảnh:
- active plan
- coding standard
- agent principles
- tech stack

### 4. Tách module trưởng thành khỏi module đang ươm
Những capability chưa thật sự sẵn sàng nên được gắn nhãn:
- experimental
- planned
- hoặc internal

Bề mặt command công khai nên nhấn mạnh những gì bộ kit làm tốt ngay hôm nay.

## Nên loại bỏ hoặc giảm nhấn mạnh

### 1. Loại bỏ các rule cũ đang xung đột
Nếu `Awaitable` là tiêu chuẩn chính thức của TSC, thì `UniTask` không nên tiếp tục tồn tại như một lựa chọn âm thầm trong audit checklist.

### 2. Giảm nhấn mạnh các tính năng placeholder
Tránh trình bày những module còn rỗng như thể chúng đã là workflow hoàn chỉnh.

### 3. Loại bỏ tài liệu không còn khớp với workflow thật
README không nên tiếp tục mô tả hình dạng cũ của sản phẩm sau khi bộ kit đã tiến hóa.

## Kiến trúc đích

```text
.tsc_workspace/
  docs/
    tech-stack.md
    decision-log.md
    TSC_KIT_REVIEW_V1.md
  plans/
    active.md
  rules/
    coding-standard.md
    agent-principles.md
    definition-of-done.md
  templates/

.shared/
  skills/
    audit/
    docs/
    examples/
    templates/
    automation/
    marketing/

.claude/
  config.json
  skills/
    adapter mỏng trỏ về shared skills

.agents/
  skills/
    adapter mỏng trỏ về shared skills

CLAUDE.md
AGENTS.md
README.md
```

Tên folder cụ thể vẫn có thể thay đổi, nhưng nguyên tắc nên giữ nguyên:
- một học thuyết
- một nguồn chuẩn
- adapter mỏng cho từng công cụ

## Hành động đề xuất tiếp theo

### Giai đoạn 1: Hợp nhất
1. Loại bỏ độ lệch `UniTask` khỏi audit rules.
2. Cập nhật orchestrator của Claude để load `agent-principles.md`.
3. Thêm `definition-of-done.md`.
4. Viết lại README để phản ánh Claude + Codex và sửa lỗi encoding.

### Giai đoạn 2: Giảm trùng lặp
1. Xác định file nào thực sự là shared.
2. Tạo một vị trí chuẩn duy nhất cho chúng.
3. Chỉ để lại phần glue theo nền tảng trong `.claude/` và `.agents/`.

### Giai đoạn 3: Làm bộ kit trưởng thành hơn
1. Quyết định `tsc-automation` và `tsc-templates` sẽ trở thành module thật ngay bây giờ hay tạm ẩn cho đến khi sẵn sàng.
2. Thêm một decision log gọn nhẹ.
3. Mở rộng `$check` từ kiểm tra cú pháp tuân thủ sang review chất lượng tổng thể của kit.

## Kết luận cuối
Bộ kit chưa cần lớn hơn ngay lúc này. Nó cần sạch hơn trước.

Phiên bản tiếp theo tốt nhất không phải là phiên bản có nhiều command nhất. Mà là phiên bản trong đó:
- mọi rule đều thống nhất với nhau
- Claude và Codex hành xử nhất quán
- mỗi module đều xứng đáng có mặt
- toàn bộ kit tạo cảm giác như một hệ thống của studio, chứ không phải một thư mục chứa các prompt hơi chồng chéo
