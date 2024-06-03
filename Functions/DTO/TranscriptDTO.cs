namespace Functions.DTO
{
    public class TranscriptDTO
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public double MidtermGradeI { get; set; }
        public double FinalGradeI { get; set; }
        public double AverageGradeI { get; set; }
        public double MidtermGradeII { get; set; }
        public double FinalGradeII { get; set; }
        public double AverageGradeII { get; set; }
        public double FinalAverageGrade { get; set; }
        public string GradeType { get; set; }
    }
}
