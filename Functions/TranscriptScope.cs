using Database_Connector;
using Entities;
using Functions.DTO;

namespace Functions
{
    public static class TranscriptScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();
        public static List<TranscriptDTO> GetTranscripts()
        {
            return Db.Transcript.Select(transcript => new TranscriptDTO
            {
                Id = transcript.Id,
                StudentName = transcript.Student.Name,
                SubjectName = transcript.Subject.Name,
                MidtermGradeI = transcript.MidtermGradeI,
                MidtermGradeII = transcript.MidtermGradeII,
                FinalGradeI = transcript.FinalGradeI,
                FinalGradeII = transcript.FinalGradeII,
                AverageGradeI = transcript.AverageGradeI,
                AverageGradeII = transcript.AverageGradeII,
                FinalAverageGrade = transcript.FinalAverageGrade,
                GradeType = transcript.GradeType
            }).ToList();
        }

        public static void AddTranscript(string studentName, string subjectName, double mid1Grade, double final1Grade, double mid2Grade, double final2Grade)
        {
            var studentId = Db.Student.FirstOrDefault(student => student.Name == studentName).Id;
            var subjectId = Db.Subject.First(subject => subject.Name == subjectName).Id;
            var averGradeI = (mid1Grade + final1Grade) / 2;
            var averGradeII = (mid2Grade + final2Grade) / 2;
            var finalAverageGrade = (averGradeI + averGradeII) / 2;
            string gradeType;

            if (finalAverageGrade >= 0 && finalAverageGrade < 5)
            {
                gradeType = "Kém";
            }
            else if (finalAverageGrade >= 5 && finalAverageGrade < 6.5)
            {
                gradeType = "Trung bình";
            }
            else if (finalAverageGrade >= 6.5 && finalAverageGrade < 8)
            {
                gradeType = "Khá";
            }
            else if (finalAverageGrade >= 8 && finalAverageGrade < 9)
            {
                gradeType = "Giỏi";
            }
            else
            {
                gradeType = "Xuất sắc";
            }

            var transcript = new Transcript
            {
                StudentId = studentId,
                SubjectId = subjectId,
                MidtermGradeI = mid1Grade,
                FinalGradeI = final1Grade,
                MidtermGradeII = mid2Grade,
                FinalGradeII = final2Grade,
                AverageGradeI = averGradeI,
                AverageGradeII = averGradeII,
                FinalAverageGrade = finalAverageGrade,
                GradeType = gradeType,
            };

            Db.Transcript.Add(transcript);
            Db.SaveChanges();
        }

        public static void UpdateTranscript(int currentTranscriptId, Transcript updatedTranscript)
        {
            // Code để cập nhật 1 bảng điểm trong cơ sở dữ liệu nếu nó tồn tại
        }

        public static List<TranscriptDTO> GetTranscriptByStudentName(string name)
        {
            return Db.Transcript.Where(search => search.Student.Name.Contains(name)).Select(transcript => new TranscriptDTO
            {
                Id = transcript.Id,
                StudentName = transcript.Student.Name,
                SubjectName = transcript.Subject.Name,
                MidtermGradeI = transcript.MidtermGradeI,
                MidtermGradeII = transcript.MidtermGradeII,
                FinalGradeI = transcript.FinalGradeI,
                FinalGradeII = transcript.FinalGradeII,
                AverageGradeI = transcript.AverageGradeI,
                AverageGradeII = transcript.AverageGradeII,
                FinalAverageGrade = transcript.FinalAverageGrade,
                GradeType = transcript.GradeType
            }).ToList();
        }
        public static TranscriptDTO GetTranscriptById(int id)
        {
            return null; // Code tìm bảng điểm theo ID
        }
    }
}
