IF OBJECT_ID('CauHoi', 'U') IS NOT NULL
    DROP TABLE CauHoi;
CREATE TABLE CauHoi (
    ID INT PRIMARY KEY IDENTITY(1,1),  -- ID tự tăng
    NoiDung NVARCHAR(MAX),             -- Nội dung câu hỏi
    A NVARCHAR(255),                   -- Phương án A
    B NVARCHAR(255),                   -- Phương án B
    C NVARCHAR(255),                   -- Phương án C
    D NVARCHAR(255),                   -- Phương án D
    DapAn CHAR(1),                     -- Đáp án đúng (A, B, C hoặc D)
    ChuDe NVARCHAR(255)                -- Chủ đề câu hỏi 
);
INSERT INTO CauHoi (NoiDung, A, B, C, D, DapAn, ChuDe)
VALUES
--Lịch Sử 
(N'Ai là người lãnh đạo cuộc khởi nghĩa Lam Sơn chống quân Minh?', N'Trần Hưng Đạo', N'Nguyễn Trãi', N'Lê Lợi',N'Quang Trung', N'C', N'Lịch sử'),--1
(N'Ai là người lập ra nhà Lý, mở đầu thời kỳ thịnh trị kéo dài gần 200 năm?', N'Lê Đại Hành', N'Lý Thái Tổ', N'Đinh Tiên Hoàng', N'Trần Thái Tông', N'B', N'Lịch sử'),--2
(N'Nhà nước phong kiến đầu tiên trong lịch sử Việt Nam là triều đại nào?', N'Nhà Trần', N'Nhà Lý', N'Nhà Ngô', N'Nhà Đinh', 'D', N'Lịch sử'),--3
(N'Ai là người sáng lập triều đại nhà Trần?', N'Trần Quốc Tuấn', N'Trần Nhân Tông', N'Trần Thủ Độ', N'Trần Cảnh', 'D', N'Lịch sử'),--4
(N'Bình Ngô đại cáo – bản tuyên ngôn độc lập thứ hai của Việt Nam – do ai viết?', N'Nguyễn Trãi', N'Lê Lợi', N'Ngô Sĩ Liên', N'Phan Bội Châu', 'A', N'Lịch sử'),--5
(N'Ai là người đánh bại quân Nam Hán trên sông Bạch Đằng năm 938, giành độc lập cho nước Việt?', N'Lý Thường Kiệt', N'Ngô Quyền', N'Lê Hoàn', N'Đinh Bộ Lĩnh', 'B', N'Lịch sử'),--6
(N'Ai là vị vua đầu tiên của nước Việt Nam thống nhất sau thời kỳ Bắc thuộc?', N'Ngô Quyền', N'Lý Thái Tổ', N'Đinh Bộ Lĩnh', N'Lê Hoàn', 'C', N'Lịch sử'),--7
(N'Chiến thắng nào dưới thời nhà Trần đã đánh bại quân Nguyên – Mông lần thứ ba?', N'Chiến thắng Bạch Đằng năm 938', N'Chiến thắng Chi Lăng 1427', N'Chiến thắng Rạch Gầm - Xoài Mút', N'Chiến thắng Bạch Đằng năm 1288', 'D', N'Lịch sử'),--8
(N'Ai là người được mệnh danh là “Bà Triệu” trong lịch sử Việt Nam?', N'Trưng Trắc', N'Trưng Nhị', N'Triệu Thị Trinh', N'Lê Chân', 'C', N'Lịch sử'),--9
(N'Trận Bạch Đằng năm 938, đánh dấu sự kiện gì quan trọng trong lịch sử Việt Nam?', N'Sự chấm dứt ách đô hộ của nhà Đường', N'Bắt đầu thời kỳ độc lập lâu dài của dân tộc', N'Kết thúc triều đại nhà Trần', N'Lập ra nhà Hậu Lê', 'B', N'Lịch sử'),--10
--Tin Học
(N'Trong C#, kiểu dữ liệu nào để lưu số nguyên?', N'string', N'int', N'float', N'bool', 'B', N'Tin học'),--1
(N'Trong cơ sở dữ liệu, lệnh nào dùng để lấy dữ liệu?', N'INSERT', N'DELETE', N'SELECT', N'UPDATE', 'C', N'Tin học'),--2
(N'Mạng máy tính hoạt động dựa trên mô hình nào phổ biến nhất hiện nay?', N'Mô hình OSI', N'Mô hình Client-Server', N'Mô hình Peer-to-Peer', N'Mô hình tập trung', 'B', N'Tin học'),--3
(N'Phím tắt nào dùng để sao chép (copy) nội dung trên Windows?', N'Ctrl + V', N'Ctrl + X', N'Ctrl + C', N'Ctrl + Z', 'C', N'Tin học'),--4
(N'HTML là viết tắt của cụm từ nào sau đây?', N'Hyper Text Marking Language', N'High Text Machine Language', N'Hyperlink and Text Markup Language', N'Hyper Text Markup Language', 'D', N'Tin học'),--5
(N'Câu lệnh nào trong SQL dùng để thêm dữ liệu vào bảng?', N'INSERT INTO', N'SELECT FROM', N'UPDATE SET', N'DELETE FROM', 'A', N'Tin học'),--6
(N'Đâu là phần mềm hệ điều hành?', N'Microsoft Word', N'Windows 10', N'Adobe Photoshop', N'Google Chrome', 'B', N'Tin học'),--7
(N'Trong lập trình, vòng lặp nào sau đây sẽ thực hiện ít nhất một lần dù điều kiện sai?', N'for', N'while', N'do...while', N'foreach', 'C', N'Tin học'),--8
(N'Bộ ba màu cơ bản trong mô hình màu RGB là gì?', N'Đỏ - Vàng - Xanh lá', N'Đỏ - Xanh dương - Xanh lá', N'Đỏ - Cam - Tím', N'Xanh lam - Vàng - Đen', 'B', N'Tin học'),--9
(N'Mạng Internet toàn cầu được hình thành và phát triển từ mạng nào?', N'LAN', N'WAN', N'ARPANET', N'VPN', 'C', N'Tin học'),--10
--Địa Lý 
(N'Việt Nam có bao nhiêu tỉnh và thành phố trực thuộc trung ương (tính đến năm 2024)?', N'61', N'63', N'64', N'60', 'B', N'Địa lý'),--1
(N'Thủ đô của Việt Nam là thành phố nào?', N'Hải Phòng', N'Đà Nẵng', N'Hà Nội', N'Hồ Chí Minh', 'C', N'Địa lý'),--2
(N'Đỉnh núi nào cao nhất Việt Nam?', N'Núi Bà Đen', N'Núi Langbiang', N'Fansipan', N'Núi Tam Đảo', 'C', N'Địa lý'),--3
(N'Việt Nam nằm ở khu vực nào của châu Á?', N'Đông Bắc Á', N'Nam Á', N'Trung Á', N'Đông Nam Á', 'D', N'Địa lý'),--4
(N'Biển nào bao quanh phía Đông của Việt Nam?', N'Biển Đông', N'Biển Nhật Bản', N'Biển Andaman', N'Biển Đỏ', 'A', N'Địa lý'),--5
(N'Đồng bằng lớn nhất Việt Nam là đồng bằng nào?', N'Đồng bằng Bắc Bộ', N'Đồng bằng Nam Bộ', N'Đồng bằng duyên hải miền Trung', N'Đồng bằng Tây Nguyên', 'B', N'Địa lý'),--6
(N'Thành phố nào sau đây không giáp biển?', N'Đà Nẵng', N'Hải Phòng', N'Cần Thơ', N'Nha Trang', 'C', N'Địa lý'),--7
(N'Sông nào dài nhất chảy qua lãnh thổ Việt Nam?', N'Sông Mê Kông', N'Sông Đà', N'Sông Hồng', N'Sông Đồng Nai', 'A', N'Địa lý'),--8
(N'Vùng kinh tế trọng điểm phía Nam gồm thành phố Hồ Chí Minh và mấy tỉnh lân cận?', N'3', N'4', N'5', N'7', 'D', N'Địa lý'),--9
(N'Tỉnh nào nằm ở cực Bắc của Việt Nam?', N'Cao Bằng', N'Hà Giang', N'Lào Cai', N'Lạng Sơn', 'B', N'Địa lý');--10
IF OBJECT_ID('TraLoi', 'U') IS NOT NULL
    DROP TABLE TraLoi;

CREATE TABLE TraLoi (
    ID INT,              -- ID của câu hỏi
    DapAnChon CHAR(1)
);
INSERT INTO TraLoi (ID, DapAnChon)
VALUES 
--lich su
(1, 'C'),
(2, 'B'),
(3, 'D'),
(4, 'D'),
(5, 'A'),
(6, 'B'),
(7, 'C'),
(8, 'D'),
(9, 'C'),
(10, 'B'),
--tin hoc
(1, 'B'),
(2, 'C'),
(3, 'B'),
(4, 'C'),
(5, 'D'),
(6, 'A'),
(7, 'B'),
(8, 'C'),
(9, 'B'),
(10, 'C'),
--dia ly
(1, 'B'),
(2, 'C'),
(3, 'C'),
(4, 'D'),
(5, 'A'),
(6, 'B'),
(7, 'C'),
(8, 'A'),
(9, 'D'),
(10, 'B');
SELECT * FROM CauHoi;
UPDATE CauHoi
SET NoiDung = N'Ai là người lãnh đạo cuộc khởi nghĩa Lam Sơn chống quân Minh?', A= N'Trần Hưng Đạo', B= N'Nguyễn Trãi', C= N'Lê Lợi', D= N'Quang Trung', DapAn = 'C'
WHERE ID = 1;
SELECT * FROM CauHoi
WHERE ChuDe = N'Lịch sử';
SELECT 
    C.ID,
    C.NoiDung,
    TL.DapAnChon,
    C.DapAn AS DapAnDung,
    CASE 
        WHEN C.DapAn = TL.DapAnChon THEN N'Đúng'
        ELSE N'Sai'
    END AS KetQua
FROM CauHoi C
JOIN TraLoi TL ON C.ID = TL.ID;
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='XepHang' AND xtype='U')
BEGIN
    CREATE TABLE XepHang (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        TenNguoiChoi NVARCHAR(100) UNIQUE,
        Diem INT,
        NgayGio DATETIME DEFAULT GETDATE()
    )
END

-- Tạo view bảng xếp hạng nếu chưa có
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='V_XepHang' AND xtype='V')
BEGIN
    EXEC('
        CREATE VIEW V_XepHang AS
        SELECT TOP 10 TenNguoiChoi, Diem, NgayGio
        FROM XepHang
        ORDER BY Diem DESC, NgayGio ASC
    ')
END

-- Xem dữ liệu
SELECT * FROM V_XepHang


