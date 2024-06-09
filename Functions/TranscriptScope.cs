using Database_Connector;
using Entities;
using Functions.DTO;
using Microsoft.EntityFrameworkCore.Storage;

namespace Functions
{
    public static class TranscriptScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();
        public static List<TranscriptDTO> FindByStudentName(string name = "")
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
        public static TranscriptDTO FindById(int id)
        {
            var transcript = Db.Transcript.FirstOrDefault(transcript => transcript.Id == id);

            return new TranscriptDTO
            {
                Id = transcript.Id,
                StudentName = Db.Student.FirstOrDefault(student => student.Id == transcript.StudentId).Name,
                SubjectName = Db.Subject.FirstOrDefault(subject => subject.Id == transcript.SubjectId).Name,
                MidtermGradeI = transcript.MidtermGradeI,
                MidtermGradeII = transcript.MidtermGradeII,
                FinalGradeI = transcript.FinalGradeI,
                FinalGradeII = transcript.FinalGradeII,
                AverageGradeI = transcript.AverageGradeI,
                AverageGradeII = transcript.AverageGradeII,
                FinalAverageGrade = transcript.FinalAverageGrade,
                GradeType = transcript.GradeType
            };
        }

        public static void Create(string studentName, string subjectName, double mid1Grade, double final1Grade, double mid2Grade, double final2Grade)
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
        public static void Update(int currentTranscriptId, double mid1Grade, double final1Grade, double mid2Grade, double final2Grade)
        {
            var transcript = Db.Transcript.FirstOrDefault(transcript => transcript.Id == currentTranscriptId);
            transcript.MidtermGradeI = mid1Grade;
            transcript.MidtermGradeII = mid2Grade;
            transcript.FinalGradeI = final1Grade;
            transcript.FinalGradeII = final2Grade;

            transcript.AverageGradeI = (mid1Grade + final1Grade) / 2;
            transcript.AverageGradeII = (mid2Grade + final2Grade) / 2;
            transcript.FinalAverageGrade = (transcript.AverageGradeII + transcript.AverageGradeI);
            string gradeType;

            if (transcript.FinalAverageGrade >= 0 && transcript.FinalAverageGrade < 5)
            {
                gradeType = "Kém";
            }
            else if (transcript.FinalAverageGrade >= 5 && transcript.FinalAverageGrade < 6.5)
            {
                gradeType = "Trung bình";
            }
            else if (transcript.FinalAverageGrade >= 6.5 && transcript.FinalAverageGrade < 8)
            {
                gradeType = "Khá";
            }
            else if (transcript.FinalAverageGrade >= 8 && transcript.FinalAverageGrade < 9)
            {
                gradeType = "Giỏi";
            }
            else
            {
                gradeType = "Xuất sắc";
            }
            transcript.GradeType = gradeType;

            Db.Transcript.Update(transcript);
            Db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var transcript = Db.Transcript.FirstOrDefault(x => x.Id == id);
            Db.Transcript.Remove(transcript);
            Db.SaveChanges();
        }
    }
}
