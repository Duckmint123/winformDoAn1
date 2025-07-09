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
(N'Ai là người lãnh đạo cuộc khởi nghĩa Lam Sơn chống quân Minh?', N'Trần Hưng Đạo', N'Nguyễn Trãi', N'Lê Lợi',N'Quang Trung', N'C', N'Lịch sử'),--1
(N'Ai là người lập ra nhà Lý, mở đầu thời kỳ thịnh trị kéo dài gần 200 năm?', N'Lê Đại Hành', N'Lý Thái Tổ', N'Đinh Tiên Hoàng', N'Trần Thái Tông', N'B', N'Lịch sử'),--2
(N'Nhà nước phong kiến đầu tiên trong lịch sử Việt Nam là triều đại nào?', N'Nhà Trần', N'Nhà Lý', N'Nhà Ngô', N'Nhà Đinh', 'D', N'Lịch sử'),--3
(N'Ai là người sáng lập triều đại nhà Trần?', N'Trần Quốc Tuấn', N'Trần Nhân Tông', N'Trần Thủ Độ', N'Trần Cảnh', 'D', N'Lịch sử'),--4
(N'Bình Ngô đại cáo – bản tuyên ngôn độc lập thứ hai của Việt Nam – do ai viết?', N'Nguyễn Trãi', N'Lê Lợi', N'Ngô Sĩ Liên', N'Phan Bội Châu', 'A', N'Lịch sử'),--5
(N'Trong C#, kiểu dữ liệu nào để lưu số nguyên?', N'string', N'int', N'float', N'bool', 'B', N'Tin học'),--6
(N'Trong cơ sở dữ liệu, lệnh nào dùng để lấy dữ liệu?', N'INSERT', N'DELETE', N'SELECT', N'UPDATE', 'C', N'Tin học'),--7
(N'Mạng máy tính hoạt động dựa trên mô hình nào phổ biến nhất hiện nay?', N'Mô hình OSI', N'Mô hình Client-Server', N'Mô hình Peer-to-Peer', N'Mô hình tập trung', 'B', N'Tin học'),--8
(N'Phím tắt nào dùng để sao chép (copy) nội dung trên Windows?', N'Ctrl + V', N'Ctrl + X', N'Ctrl + C', N'Ctrl + Z', 'C', N'Tin học'),--9
(N'HTML là viết tắt của cụm từ nào sau đây?', N'Hyper Text Marking Language', N'High Text Machine Language', N'Hyperlink and Text Markup Language', N'Hyper Text Markup Language', 'D', N'Tin học');--10
IF OBJECT_ID('TraLoi', 'U') IS NOT NULL
    DROP TABLE TraLoi;

CREATE TABLE TraLoi (
    ID INT,              -- ID của câu hỏi
    DapAnChon CHAR(1)
);
INSERT INTO TraLoi (ID, DapAnChon)
VALUES 
(1, 'C'),
(2, 'B'),
(3, 'D'),
(4, 'D'),
(5, 'A'),
(6, 'B'),
(7, 'C'),
(8, 'B'),
(9, 'C'),
(10, 'D');
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

