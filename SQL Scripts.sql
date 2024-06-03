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
    Grade INT
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

INSERT INTO Class (Name, Grade) VALUES
	('10A1', 10),
	('10A2', 10),
	('10A3', 10),
	('10A4', 10),
	('10A5', 10),
	('10A6', 10),
	('10A7', 10),
	('10A8', 10),
	('11B1', 11),
	('11B2', 11),
	('11B3', 11),
	('11B4', 11),
	('11B5', 11),
	('11B6', 11),
	('11B7', 11),
	('11B8', 11),
	('12C1', 12),
	('12C2', 12),
	('12C3', 12),
	('12C4', 12),
	('12C5', 12),
	('12C6', 12),
	('12C7', 12),
	('12C8', 12);

INSERT INTO Student (Name, Birthdate, Gender, ClassId) VALUES
	('Nguyễn Thị Lan Anh', '2006-05-10', 0, 1),
	('Trần Văn Tuấn Anh', '2006-06-15', 1, 1),
	('Lê Thị Thu Hà', '2006-07-20', 0, 1),
	('Phạm Văn Minh', '2006-08-25', 1, 2),
	('Hoàng Thị Ngọc Ánh', '2006-09-30', 0, 2),
	('Nguyễn Văn Đức', '2006-10-05', 1, 2),
	('Trần Thị Hương Giang', '2006-11-10', 0, 3),
	('Lê Văn Nam', '2006-12-15', 1, 3),
	('Phạm Thị Mai', '2007-01-20', 0, 3),
	('Hoàng Văn Hoàng', '2007-02-25', 1, 4),
	('Nguyễn Thị Hồng', '2007-03-30', 0, 4),
	('Trần Văn Dương', '2007-04-05', 1, 4),
	('Lê Thị Thu', '2007-05-10', 0, 5),
	('Phạm Văn Hùng', '2007-06-15', 1, 5),
	('Hoàng Thị Kim Ngân', '2007-07-20', 0, 5),
	('Nguyễn Văn Hải', '2007-08-25', 1, 6),
	('Trần Thị Hà', '2007-09-30', 0, 6),
	('Lê Văn Trí', '2007-10-05', 1, 6),
	('Phạm Thị Thu', '2007-11-10', 0, 7),
	('Hoàng Văn Hưng', '2007-12-15', 1, 7),
	('Nguyễn Thị Thanh', '2008-01-20', 0, 7),
	('Trần Văn Dũng', '2008-02-25', 1, 8),
	('Lê Thị Loan', '2008-03-30', 0, 8),
	('Phạm Văn Tú', '2008-04-05', 1, 8),
	('Hoàng Thị Ngọc', '2008-05-10', 0, 9),
	('Nguyễn Văn Thành', '2008-06-15', 1, 9),
	('Trần Thị Thúy', '2008-07-20', 0, 9),
	('Lê Văn Quốc', '2008-08-25', 1, 10),
	('Phạm Thị Hương', '2008-09-30', 0, 10),
	('Hoàng Văn Hà', '2008-10-05', 1, 10),
	('Nguyễn Thị Hiền', '2008-11-10', 0, 11),
	('Trần Văn Tiến', '2008-12-15', 1, 11),
	('Lê Thị Linh', '2009-01-20', 0, 11),
	('Phạm Văn Quang', '2009-02-25', 1, 12),
	('Hoàng Thị Thùy Dương', '2009-03-30', 0, 12),
	('Nguyễn Văn Thắng', '2009-04-05', 1, 12),
	('Trần Thị Phương Anh', '2009-05-10', 0, 13),
	('Lê Văn Huy', '2009-06-15', 1, 13),
	('Phạm Thị Ngọc Mai', '2009-07-20', 0, 13),
	('Hoàng Văn Nam', '2009-08-25', 1, 14),
	('Nguyễn Thị Hà', '2009-09-30', 0, 14),
	('Trần Văn Khánh', '2009-10-05', 1, 14),
	('Lê Thị Lan', '2009-11-10', 0, 15),
	('Phạm Văn Hòa', '2009-12-15', 1, 15),
	('Hoàng Thị Bích', '2010-01-20', 0, 15),
	('Nguyễn Văn Hậu', '2010-02-25', 1, 16),
	('Trần Thị Phương', '2010-03-30', 0, 16),
	('Lê Văn Tâm', '2010-04-05', 1, 16),
	('Nguyễn Thị Hương Giang', '2006-05-10', 0, 1),
	('Trần Văn Tuấn Anh', '2006-06-15', 1, 1),
	('Lê Thị Thanh Hà', '2006-07-20', 0, 1),
	('Phạm Văn Minh', '2006-08-25', 1, 2),
	('Hoàng Thị Ngọc Ánh', '2006-09-30', 0, 2),
	('Nguyễn Văn Đức', '2006-10-05', 1, 2),
	('Trần Thị Hương Giang', '2006-11-10', 0, 3),
	('Lê Văn Nam', '2006-12-15', 1, 3),
	('Phạm Thị Mai', '2007-01-20', 0, 3),
	('Hoàng Văn Hoàng', '2007-02-25', 1, 4),
	('Nguyễn Thị Hồng', '2007-03-30', 0, 4),
	('Trần Văn Dương', '2007-04-05', 1, 4),
	('Lê Thị Thu', '2007-05-10', 0, 5),
	('Phạm Văn Hùng', '2007-06-15', 1, 5),
	('Hoàng Thị Kim Ngân', '2007-07-20', 0, 5),
	('Nguyễn Văn Hải', '2007-08-25', 1, 6),
	('Trần Thị Hà', '2007-09-30', 0, 6),
	('Lê Văn Trí', '2007-10-05', 1, 6),
	('Phạm Thị Thu', '2007-11-10', 0, 7),
	('Hoàng Văn Hưng', '2007-12-15', 1, 7),
	('Nguyễn Thị Thanh', '2008-01-20', 0, 7),
	('Trần Văn Dũng', '2008-02-25', 1, 8),
	('Lê Thị Loan', '2008-03-30', 0, 8),
	('Phạm Văn Tú', '2008-04-05', 1, 8),
	('Hoàng Thị Ngọc', '2008-05-10', 0, 9),
	('Nguyễn Văn Thành', '2008-06-15', 1, 9),
	('Trần Thị Thúy', '2008-07-20', 0, 9),
	('Lê Văn Quốc', '2008-08-25', 1, 10),
	('Phạm Thị Hương', '2008-09-30', 0, 10),
	('Hoàng Văn Hà', '2008-10-05', 1, 10),
	('Nguyễn Thị Hiền', '2008-11-10', 0, 11),
	('Trần Văn Tiến', '2008-12-15', 1, 11),
	('Lê Thị Linh', '2009-01-20', 0, 11),
	('Phạm Văn Quang', '2009-02-25', 1, 12),
	('Hoàng Thị Thùy Dương', '2009-03-30', 0, 12),
	('Nguyễn Văn Thắng', '2009-04-05', 1, 12),
	('Trần Thị Phương Anh', '2009-05-10', 0, 13),
	('Lê Văn Huy', '2009-06-15', 1, 13),
	('Phạm Thị Ngọc Mai', '2009-07-20', 0, 13),
	('Hoàng Văn Nam', '2009-08-25', 1, 14),
	('Nguyễn Thị Hà', '2009-09-30', 0, 14),
	('Trần Văn Khánh', '2009-10-05', 1, 14),
	('Lê Thị Lan', '2009-11-10', 0, 15),
	('Phạm Văn Hòa', '2009-12-15', 1, 15),
	('Hoàng Thị Bích', '2010-01-20', 0, 15),
	('Nguyễn Văn Hậu', '2010-02-25', 1, 16),
	('Trần Thị Phương', '2010-03-30', 0, 16),
	('Lê Văn Tâm', '2010-04-05', 1, 16),
	('Trần Thị Mỹ Linh', '2006-05-10', 0, 1),
	('Nguyễn Văn Tuấn Anh', '2006-06-15', 1, 1),
	('Lê Thị Thịnh Hà', '2006-07-20', 0, 1),
	('Phạm Văn Minh', '2006-08-25', 1, 2),
	('Hoàng Thị Minh Ánh', '2006-09-30', 0, 2),
	('Nguyễn Văn Thành Đạt', '2006-10-05', 1, 2),
	('Trần Thị Thùy Dung', '2006-11-10', 0, 3),
	('Lê Văn Hữu Nam', '2006-12-15', 1, 3),
	('Phạm Thị Mỹ Mai', '2007-01-20', 0, 3),
	('Hoàng Văn Quân', '2007-02-25', 1, 4);

INSERT INTO Subject (Name, MidtermWeight, FinalWeight, Semester) VALUES
	('Toán', 0.4, 0.6, 1),
	('Vật lý', 0.3, 0.7, 1),
	('Hóa học', 0.3, 0.7, 1),
	('Ngữ văn', 0.4, 0.6, 1),
	('Tiếng Anh', 0.4, 0.6, 1),
	('Sinh học', 0.3, 0.7, 1),
	('Lịch sử', 0.4, 0.6, 1),
	('Địa lý', 0.4, 0.6, 1),
	('Giáo dục công dân', 0.3, 0.7, 1),
	('Công nghệ', 0.2, 0.8, 1),
	('Tin học', 0.2, 0.8, 1),
	('Giáo dục quốc phòng', 0.3, 0.7, 1),
	('Thể dục', 0.1, 0.9, 1);

DECLARE @counter INT
SET @counter = 0
WHILE @counter < 200
BEGIN
    INSERT INTO Transcript (StudentId, SubjectId, MidtermGradeI, FinalGradeI, AverageGradeI, MidtermGradeII, FinalGradeII, AverageGradeII, FinalAverageGrade, GradeType)
    SELECT TOP 1
        FLOOR(RAND()*(106-1+1)+1) AS StudentId,
        FLOOR(RAND()*(13-1+1)+1) AS SubjectId,
        ROUND(RAND()*(10-1+1)+1, 2) AS MidtermGradeI,
        ROUND(RAND()*(10-1+1)+1, 2) AS FinalGradeI,
        ROUND((ROUND(RAND()*(10-1+1)+1, 2) + ROUND(RAND()*(10-1+1)+1, 2)) / 2, 2) AS AverageGradeI,
        ROUND(RAND()*(10-1+1)+1, 2) AS MidtermGradeII,
        ROUND(RAND()*(10-1+1)+1, 2) AS FinalGradeII,
        ROUND((ROUND(RAND()*(10-1+1)+1, 2) + ROUND(RAND()*(10-1+1)+1, 2)) / 2, 2) AS AverageGradeII,
        ROUND((((ROUND(RAND()*(10-1+1)+1, 2) + ROUND(RAND()*(10-1+1)+1, 2)) / 2) + ((ROUND(RAND()*(10-1+1)+1, 2) + ROUND(RAND()*(10-1+1)+1, 2)) / 2)) / 2, 2) AS FinalAverageGrade,
        CASE 
            WHEN RAND() < 0.1 THEN 'Xuất sắc'
            WHEN RAND() < 0.3 THEN 'Giỏi'
            WHEN RAND() < 0.6 THEN 'Khá'
            ELSE 'Trung bình'
        END AS GradeType
    FROM INFORMATION_SCHEMA.COLUMNS a, INFORMATION_SCHEMA.COLUMNS b;

    SET @counter = @counter + 1
END