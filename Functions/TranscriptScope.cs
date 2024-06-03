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

        public static void AddTranscript(Transcript transcript)
        {
            // Code để thêm 1 bảng điểm vào cơ sở dữ liệu
        }

        public static void UpdateTranscript(int currentTranscriptId, Transcript updatedTranscript)
        {
            // Code để cập nhật 1 bảng điểm trong cơ sở dữ liệu nếu nó tồn tại
        }
    }
}
