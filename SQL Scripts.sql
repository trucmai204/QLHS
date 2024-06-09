IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'QLHS')
BEGIN
    CREATE DATABASE QLHS;
END

USE QLHS;
DROP TABLE IF EXISTS [User];
DROP TABLE IF EXISTS Transcript;
DROP TABLE IF EXISTS Subject;
DROP TABLE IF EXISTS Student;
DROP TABLE IF EXISTS Class;

-- Người dùng
CREATE TABLE [User] (
    Id INT IDENTITY PRIMARY KEY,
    Username VARCHAR(255),
    Password VARCHAR(255)
);

-- Lớp
CREATE TABLE Class (
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(255),
    Grade INT,
	SchoolYear VARCHAR(100)
);

-- Học sinh
CREATE TABLE Student (
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(200),
    Birthdate DATETIME,
    Gender BIT,
    ClassId INT,
    FOREIGN KEY (ClassId) REFERENCES Class(Id)
);

-- Môn học
CREATE TABLE Subject (
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(255),
    MidtermWeight FLOAT,
    FinalWeight FLOAT,
    Semester SMALLINT
);

-- Bảng điểm
CREATE TABLE Transcript (
    Id INT IDENTITY PRIMARY KEY,
    StudentId INT,
    SubjectId INT,
    MidtermGradeI FLOAT,
    FinalGradeI FLOAT,
    AverageGradeI FLOAT,
    MidtermGradeII FLOAT,
    FinalGradeII FLOAT,
    AverageGradeII FLOAT,
    FinalAverageGrade FLOAT,
    GradeType NVARCHAR(150),
    FOREIGN KEY (StudentId) REFERENCES Student(Id),
    FOREIGN KEY (SubjectId) REFERENCES Subject(Id)
);

------------ FAKE DATA ------------

INSERT INTO [User] (Username, Password) VALUES
	('admin', 'maidethuong'),
	('quang', 'maidethuong'),
	('mai', 'maidethuong'),
	('user3', 'maidethuong'),
	('user4', 'maidethuong'),
	('user5', 'maidethuong'),
	('user6', 'maidethuong'),
	('user7', 'maidethuong'),
	('user8', 'maidethuong'),
	('user9', 'maidethuong'),
	('user10', 'maidethuong'),
	('user11', 'maidethuong'),
	('user12', 'maidethuong'),
	('user13', 'maidethuong'),
	('user14', 'maidethuong'),
	('user15', 'maidethuong');

-- Chèn 25 dòng cho niên khóa 2023-2024
INSERT INTO Class (Name, Grade, SchoolYear) VALUES
('10A1', 10, '2023-2024'),
('10A2', 10, '2023-2024'),
('10A3', 10, '2023-2024'),
('10A4', 10, '2023-2024'),
('10A5', 10, '2023-2024'),
('10B1', 10, '2023-2024'),
('10B2', 10, '2023-2024'),
('10B3', 10, '2023-2024'),
('10B4', 10, '2023-2024'),
('10B5', 10, '2023-2024'),
('10C1', 10, '2023-2024'),
('10C2', 10, '2023-2024'),
('10C3', 10, '2023-2024'),
('10C4', 10, '2023-2024'),
('10C5', 10, '2023-2024'),
('10D1', 10, '2023-2024'),
('10D2', 10, '2023-2024'),
('10D3', 10, '2023-2024'),
('10D4', 10, '2023-2024'),
('10D5', 10, '2023-2024'),
('10E1', 10, '2023-2024'),
('10E2', 10, '2023-2024'),
('10E3', 10, '2023-2024'),
('10E4', 10, '2023-2024'),
('10E5', 10, '2023-2024');

-- Chèn 25 dòng cho niên khóa 2022-2023
INSERT INTO Class (Name, Grade, SchoolYear) VALUES
('11A1', 11, '2022-2023'),
('11A2', 11, '2022-2023'),
('11A3', 11, '2022-2023'),
('11A4', 11, '2022-2023'),
('11A5', 11, '2022-2023'),
('11B1', 11, '2022-2023'),
('11B2', 11, '2022-2023'),
('11B3', 11, '2022-2023'),
('11B4', 11, '2022-2023'),
('11B5', 11, '2022-2023'),
('11C1', 11, '2022-2023'),
('11C2', 11, '2022-2023'),
('11C3', 11, '2022-2023'),
('11C4', 11, '2022-2023'),
('11C5', 11, '2022-2023'),
('11D1', 11, '2022-2023'),
('11D2', 11, '2022-2023'),
('11D3', 11, '2022-2023'),
('11D4', 11, '2022-2023'),
('11D5', 11, '2022-2023'),
('11E1', 11, '2022-2023'),
('11E2', 11, '2022-2023'),
('11E3', 11, '2022-2023'),
('11E4', 11, '2022-2023'),
('11E5', 11, '2022-2023');

-- Chèn 25 dòng cho niên khóa 2021-2022
INSERT INTO Class (Name, Grade, SchoolYear) VALUES
('12A1', 12, '2021-2022'),
('12A2', 12, '2021-2022'),
('12A3', 12, '2021-2022'),
('12A4', 12, '2021-2022'),
('12A5', 12, '2021-2022'),
('12B1', 12, '2021-2022'),
('12B2', 12, '2021-2022'),
('12B3', 12, '2021-2022'),
('12B4', 12, '2021-2022'),
('12B5', 12, '2021-2022'),
('12C1', 12, '2021-2022'),
('12C2', 12, '2021-2022'),
('12C3', 12, '2021-2022'),
('12C4', 12, '2021-2022'),
('12C5', 12, '2021-2022'),
('12D1', 12, '2021-2022'),
('12D2', 12, '2021-2022'),
('12D3', 12, '2021-2022'),
('12D4', 12, '2021-2022'),
('12D5', 12, '2021-2022'),
('12E1', 12, '2021-2022'),
('12E2', 12, '2021-2022'),
('12E3', 12, '2021-2022'),
('12E4', 12, '2021-2022'),
('12E5', 12, '2021-2022');

-- Danh sách tên tiếng Việt
DECLARE @names NVARCHAR(MAX) = N'Nguyễn Văn An, Trần Thị Bích, Lê Văn Cường, Phạm Thị Dung, Hoàng Văn Em, Võ Thị Phương, Đỗ Văn Hiếu, Ngô Thị Hồng, Dương Văn Khánh, Bùi Thị Lan, Nguyễn Thị Minh, Trần Văn Nam, Lê Thị Oanh, Phạm Văn Phát, Hoàng Thị Quỳnh, Võ Văn Sơn, Đỗ Thị Trang, Ngô Văn Tài, Dương Thị Vân, Bùi Văn Đức, Nguyễn Văn Hùng, Trần Thị Yến, Lê Văn Tùng, Phạm Thị Ngọc, Hoàng Văn Tâm, Võ Thị Mai, Đỗ Văn Dũng, Ngô Thị Thảo, Dương Văn Tiến, Bùi Thị Huệ, Nguyễn Thị Anh, Trần Văn Đạt, Lê Thị Hạnh, Phạm Văn Quân, Hoàng Thị Tuyết, Võ Văn Kiên, Đỗ Thị Lý, Ngô Văn Minh, Dương Thị Nhi, Bùi Văn Phương, Nguyễn Văn Bình, Trần Thị Nhung, Lê Văn Trọng, Phạm Thị Hoa, Hoàng Văn Lâm, Võ Thị Thu, Đỗ Văn Hòa, Ngô Thị Lưu, Dương Văn Tùng, Bùi Thị Hồng, Nguyễn Thị Thu, Trần Văn Hải, Lê Thị Thanh, Phạm Văn Thành, Hoàng Thị Lệ, Võ Văn Tuấn, Đỗ Thị Hằng, Ngô Văn Quý, Dương Thị Mỹ, Bùi Văn Khang, Nguyễn Thị Phương, Trần Văn Toàn, Lê Thị Ngọc, Phạm Văn Vũ, Hoàng Thị Xuân, Võ Thị Kim, Đỗ Văn Hiệp, Ngô Thị Tuyết, Dương Văn Việt, Bùi Thị Tuyền, Nguyễn Thị Lan, Trần Văn Thắng, Lê Thị Hiền, Phạm Văn Đạt, Hoàng Thị Tâm, Võ Văn Hùng, Đỗ Thị Hoài, Ngô Văn Bình, Dương Thị Như, Bùi Văn Thái, Nguyễn Thị Hòa, Trần Văn Lộc, Lê Thị Mai, Phạm Văn Hoàng, Hoàng Thị Thủy, Võ Văn Khoa, Đỗ Thị Quỳnh, Ngô Văn Thịnh, Dương Thị Kim, Bùi Văn Nam, Nguyễn Thị Linh, Trần Văn Thành, Lê Thị Bảo, Phạm Văn Hưng, Hoàng Thị Thảo, Võ Văn Phong, Đỗ Thị Nga, Ngô Văn Sỹ, Dương Thị Đào, Bùi Văn Quân';

-- Tách các tên ra thành bảng tạm
DECLARE @StudentNames TABLE (Name NVARCHAR(200));
INSERT INTO @StudentNames (Name)
SELECT value FROM STRING_SPLIT(@names, ',');

-- Chèn học sinh cho mỗi niên khóa
DECLARE @ClassId INT;
DECLARE @Name NVARCHAR(200);
DECLARE @Birthdate DATETIME;
DECLARE @Gender BIT;
DECLARE @Counter INT;

SET @Counter = 1;

DECLARE student_cursor CURSOR FOR
SELECT Id FROM Class ORDER BY Id;

OPEN student_cursor;

FETCH NEXT FROM student_cursor INTO @ClassId;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Chèn 20 học sinh cho mỗi lớp
    WHILE @Counter <= 30
    BEGIN
        -- Lấy tên từ bảng tạm
        SELECT @Name = Name FROM @StudentNames ORDER BY NEWID();
        
        -- Chọn ngày sinh ngẫu nhiên
        SET @Birthdate = DATEADD(DAY, ABS(CHECKSUM(NEWID())) % 365, '2005-01-01');
        
        -- Chọn giới tính ngẫu nhiên
        SET @Gender = CAST(ROUND(RAND(), 0) AS BIT);

        -- Chèn học sinh vào bảng Student
        INSERT INTO Student (Name, Birthdate, Gender, ClassId) VALUES
        (@Name, @Birthdate, @Gender, @ClassId);

        -- Xóa tên đã sử dụng để không bị trùng lặp
        DELETE FROM @StudentNames WHERE Name = @Name;
        
        -- Tăng bộ đếm
        SET @Counter = @Counter + 1;
    END

    -- Đặt lại bộ đếm và tên học sinh cho lớp tiếp theo
    SET @Counter = 1;

    -- Nạp lại danh sách tên
    INSERT INTO @StudentNames (Name)
    SELECT value FROM STRING_SPLIT(@names, ',');

    FETCH NEXT FROM student_cursor INTO @ClassId;
END
CLOSE student_cursor;
DEALLOCATE student_cursor;

INSERT INTO Subject (Name, MidtermWeight, FinalWeight, Semester) VALUES
	(N'Toán', 0.4, 0.6, 1),
	(N'Vật lý', 0.3, 0.7, 1),
	(N'Hóa học', 0.3, 0.7, 1),
	(N'Ngữ văn', 0.4, 0.6, 1),
	(N'Tiếng Anh', 0.4, 0.6, 1),
	(N'Sinh học', 0.3, 0.7, 1),
	(N'Lịch sử', 0.4, 0.6, 1),
	(N'Địa lý', 0.4, 0.6, 1),
	(N'Giáo dục công dân', 0.3, 0.7, 1),
	(N'Công nghệ', 0.2, 0.8, 1),
	(N'Tin học', 0.2, 0.8, 1),
	(N'Giáo dục quốc phòng', 0.3, 0.7, 1),
	(N'Thể dục', 0.1, 0.9, 1);

DECLARE @transcriptCounter INT
SET @transcriptCounter = 0
WHILE @transcriptCounter < 400
BEGIN
    INSERT INTO Transcript (StudentId, SubjectId, MidtermGradeI, FinalGradeI, AverageGradeI, MidtermGradeII, FinalGradeII, AverageGradeII, FinalAverageGrade, GradeType)
    SELECT TOP 1
        FLOOR(RAND()*(2250-1+1)+1) AS StudentId,
        FLOOR(RAND()*(13-1+1)+1) AS SubjectId,
        ROUND(RAND()*(10-1+1)+1, 2) AS MidtermGradeI,
        ROUND(RAND()*(10-1+1)+1, 2) AS FinalGradeI,
        ROUND((ROUND(RAND()*(10-1+1)+1, 2) + ROUND(RAND()*(10-1+1)+1, 2)) / 2, 2) AS AverageGradeI,
        ROUND(RAND()*(10-1+1)+1, 2) AS MidtermGradeII,
        ROUND(RAND()*(10-1+1)+1, 2) AS FinalGradeII,
        ROUND((ROUND(RAND()*(10-1+1)+1, 2) + ROUND(RAND()*(10-1+1)+1, 2)) / 2, 2) AS AverageGradeII,
        ROUND((((ROUND(RAND()*(10-1+1)+1, 2) + ROUND(RAND()*(10-1+1)+1, 2)) / 2) + ((ROUND(RAND()*(10-1+1)+1, 2) + ROUND(RAND()*(10-1+1)+1, 2)) / 2)) / 2, 2) AS FinalAverageGrade,
        CASE 
            WHEN RAND() < 0.1 THEN N'Xuất sắc'
            WHEN RAND() < 0.3 THEN N'Giỏi'
            WHEN RAND() < 0.6 THEN N'Khá'
            ELSE N'Trung bình'
        END AS GradeType
    FROM INFORMATION_SCHEMA.COLUMNS a, INFORMATION_SCHEMA.COLUMNS b;

    SET @transcriptCounter = @transcriptCounter + 1
END