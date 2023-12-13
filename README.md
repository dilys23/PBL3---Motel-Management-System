
                                    ĐỒ ÁN CÔNG NGHỆ PHẦN MỀM
                             ĐỀ TÀI: Quản lý kinh doanh phòng trọ
                                    PBL3 - Motel Management System
•	Hệ thống quản lý kinh doanh phòng trọ được xây dựng bằng ngôn ngữ C# và sử dụng phương pháp DB First. Dự án áp dụng từ các môn học liên quan bao gồm:
-	Công nghệ phần mềm
-	Phân tích và thiết kế hướng đối tượng
-	Lập trình .Net.
•	Dự án đã áp dụng các quá trình  để tạo nên một sản phẩm phần mềm hoàn chỉnh bao gồm:
-	Phân tích yêu cầu 
-	Thiết kế phần mềm
-	Lập trình, kiểm thử phần mềm
-	Triển khai, duy trì.
•	Phân tích và thiết kế hướng đối tượng được sử dụng để hiểu rõ hơn về cách tương tác giữa các thành phần và xây dựng một kiến trúc phần mềm đáng tin cậy và linh hoạt. Quá trình này bao gồm vẽ sơ đồ:
-	Use-case,
-	Class diagram, 
-	Sơ đồ thực thể ERD.
•	Hệ thống quản lý kinh doanh phòng trọ được xây dựng theo cấu trúc mô hình 3 Layer:
-	GUI Layer (View Layer): Lớp này là lớp hiển thị giao diện và các chức năng để người dùng sử dụng (Giao diện: Trang chủ, Thêm dãy, Thêm phòng, …). 
-	BLL (Business Logic Layer): Nhận các yêu cầu từ GUI và truy xuất đến lớp Data để lấy thông tin và trả về GUI.
-	DAL (Data Access Layer): Truy xuất đến CSDL, chỉ duy nhất lớp này làm việc với database.
  
4.	PHÂN TÍCH THIẾT KẾ HỆ THỐNG
   
4.1.	Mô hình hóa yêu cầu

4.1.1.	Xác định các Actor:
Dựa vào yêu cầu đề bài, ta có thể xác định được tác nhân chính của hệ thống như sau: 
	Chủ Trọ: Quản lý tài khoản của khách hàng và quản lý, Cập nhật thông tin dãy trọ và phòng trọ tương ứng, quản lý doanh thu ... 
	Khách Thuê: Tương tác qua tài khoản cố định của phòng đang thuê và được xem các thông tin chi tiết của phòng đang thuê

4.1.2.	Xây dựng hệ thống: 
          Từ các Actor đã được xác định, hệ thống sẽ phân ra các phần chính sau:
	Chủ trọ:
•	Chủ trọ là người có nhu cầu quản lý các dãy trọ của mình. Mỗi chủ trọ đều được phân quyền và cấp tài khoản sử dụng hệ thống gồm username và password.  
•	Trên tài khoản chủ trọ sẽ chứa các thông tin cá nhân (họ tên, ngày sinh, địa chỉ, số điện thoại,... ) 
•	Chủ trọ sẽ tiến hành cập nhật các thông tin ban đầu của các dãy trọ (địa chỉ trọ, tên dãy trọ, số lượng phòng, chi tiết phòng...) 
•	Chủ trọ có quyền truy cập chỉnh sửa thông tin của trọ mình và thực hiện các chức năng tương ứng 
•	Chủ trọ có thể thống kê doanh thu theo tháng, năm.

	Khách thuê: 
•	Khách thuê sẽ được Chủ trọ cấp tài khoản phòng cố định mà mình đang ở. 
•	Trên tài khoản đó, khách sẽ chỉ được xem và theo dõi đầy đủ các thông tin liên quan đến trọ của mình.
•	Ngoài ra khách vẫn có thể thay đổi mật khẩu cho tài khoản phòng đó. Việc thay đổi này sẽ được cập nhật lại thông tin trong dữ liệu mà chủ trọ quản lý.

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/009e9120-a053-47d8-9198-2cd842eb0715)

Chạy Demo 

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/087a8d3a-1372-4368-a33c-ccc043bf15ba)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/8d97d33d-4971-4055-ad9c-54920903e9ca)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/30ee68c9-2cb3-48e5-b997-4930a2f6ce20)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/151a6027-712a-4e95-9a14-a2dc479da68e)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/87173365-a1ea-46c1-a3ec-5dd9e830a4bc)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/ab55c8cf-415a-40a7-8480-3cb1cdb47cea)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/552d2235-d8cb-42bf-80fc-9eafacba7736)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/e8e73871-bc78-4ed9-93d4-79a4f9962a8c)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/008f36b1-77b5-4579-b241-0c621f16272c)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/3c2596ae-a6f0-4abf-ae86-cce13acdfe48)
Chức năng Tìm kiếm phòng trọ
![image](https://github.com/dilys23/PBL3_Main/assets/91045422/d4482ae4-dedb-4f1d-ad36-28e45541e664)
	
![image](https://github.com/dilys23/PBL3_Main/assets/91045422/01fc83af-d840-4db4-9ce4-17e74e74901a)

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/c4f1d734-921a-4778-952f-ea6b69e49090)
Chức năng Hoàn trả phòng
![image](https://github.com/dilys23/PBL3_Main/assets/91045422/9557dff7-066e-4d10-b5bb-bde9de587252)

Chức năng Thuê phòng
![image](https://github.com/dilys23/PBL3_Main/assets/91045422/be7f6d3b-e981-4ff8-b1db-b8be0f4e6049)


![image](https://github.com/dilys23/PBL3_Main/assets/91045422/5556a32c-1c62-4877-8aae-23856aaa00f9)


![image](https://github.com/dilys23/PBL3_Main/assets/91045422/c3152995-3091-4d1d-ad7c-45fa9e4d52c4)


![image](https://github.com/dilys23/PBL3_Main/assets/91045422/d86b0a80-6b9b-439b-9ca3-3be5a845c579)


![image](https://github.com/dilys23/PBL3_Main/assets/91045422/27d112d6-7a40-4440-910e-7b9ae4f16266)




![image](https://github.com/dilys23/PBL3_Main/assets/91045422/d7cbe355-71ca-4b2c-a2e8-169b9a579430)

	Xem với Tài khoản “Chủ Trọ”


![image](https://github.com/dilys23/PBL3_Main/assets/91045422/6c09efc8-dacc-49e6-a535-f4c691a27b36)
	Xem với Tải khoản “Phòng”

![image](https://github.com/dilys23/PBL3_Main/assets/91045422/b26cbd45-5ef3-4d23-ba27-c3f7149e32a7)


