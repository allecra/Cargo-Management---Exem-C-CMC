BÀI KIỂM TRA C# 60 phút 

Câu 1 (1đ). Sử dụng một trong các hệ quản trị Cơ sở dữ liệu (CSDL) quan hệ SQL 
Server/MySQL, tạo 1 CSDL tên là “Hanghoa” để quản lý Hàng hóa của 1 của hàng (nhập tay 
hoặc viết script hoặc viết lệnh C# với Entity), trong đó có 1 bảng tblHanghoa gồm:

+ ID: String, độ dài cố định, lưu chuỗi 5 chữ số, là khóa chính.
+ MaVach: String, độ dài cố định, lưu chuỗi 13 chữ số, không là null (có thể đặt là khóa ngoài).
+ Ten: String (200), GiaNhap: Float, GiaBan: Float, GhiChu: String
Các trường String có thể lưu dữ liệu unicode Tiếng Việt

Câu 2 (2đ). Viết 1 hàm static nhập vào số nguyên dương n trong khoảng từ 2 đến 10. Nếu nhập 
sai thì nhập lại. Gọi hàm trong lớp chứa hàm Main() để kiểm tra.

Câu 3 (3đ). 
Khai báo 1 class CHanhoa gồm các biến public: id, mavach, ten,gianhap,giaban,ghichu dữ liệu 
phù hợp trong 1 file .cs riêng.

3a. Viết hàm static nhập vào từ bàn phím n đối tượng Hàng hóa vào 1 biến kiểu dữ liệu mảng
với khóa là id. Khi nhập có xử lý Exception. Hàm trả lại giá trị biến kiểu mảng lưu các giá trị
được nhập. Gọi hàm trong hàm Main() để lấy n đối tượng Hàng hóa lưu vào biến hanghoa1.

3b. Viết câu lệnh duyệt hanghoa1 để chỉ hiển thị các hàng hóa có giá nhập >= 100000.

3c. Viết hàm static LuuDB, hàm kết nối với CSDL Hanghoa, ghi hanghoa1 vào bảng 
tblHanghoa, khi ghi không thành công hàm trả lại giá trị null. Gọi hàm trong hàm Main() để
kiểm tra.

3d. Đặt hàm LuuDB vào thực hiện trong 1 thread. Kích hoạt thread trong hàm Main(). Khi thread đã 
hoàn thành thì hiện thông báo đã thực hiện xong.

Câu 4 (3đ)
4a. Thiết kế UI (Chọn Controls, đặt Tab Order, chỉnh size và căn vị trí Controls):
Thiết kế form gồm 1 điều khiển gồm các điều khiển Label, 1 điều khiển edit mã vạch 
(txtmavach), 1 button Tìm kiếm (cmdtim), 1 button Thoát(cmdthoat) (chương trình được 
đóng khi nhấn nút Thoát), 1 DataGridView control để hiển thị bảng tblHanghoa.
Yêu cầu về UI (user interface) của form như sau:

4b. Lập trình xử lý các sự kiện:
+ Khi form được Load thì bảng tblHanghoa được hiển thị trên DataGridView.
+ Khi click chuột trên DataGridView, txtmavach được hiển thị dữ liệu tương ứng từ
DataGridView.
+ Khi nhập dữ liệu ở txtmavach chỉ cho phép nhập chữ số
+ 
4c. Khi nhập dữ liệu ở txtmavach nhấn phím Enter hoặc nhấn chuột ở nút Tìm kiếm thì:
+ Nếu độ dài text ở txtmavach là 13 thì duyệt DataGridView để tìm kiếm Mavach của dòng của
DataGridView trùng với nội dung textbox txtmavach. Nếu tìm thấy thì dịch chuyển dòng hiện 
thời của DataGridView tới vị trí được tìm thấy và hiển thị hộp thoại với thông báo “Tìm thấy số
hàng hóa…”. Ngược lại, thông báo không tìm thấy. Sau đó lại focus về điều khiển nhập 
txtmavach.
+ Nếu độ dài ở txtmavach là khác 13 thì hiển thị hộp thoại với thông báo “mã vạch không hợp 
lệ”. Sau đó lại focus về điều khiển nhập txtmavach.
