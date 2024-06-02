using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Transcript
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public double MidtermGradeI { get; set; }
        public double FinalGradeI { get; set; }
        public double AverageGradeI { get; set; }
        public double MidtermGradeII { get; set; }
        public double FinalGradeII { get; set; }
        public double AverageGradeII { get; set; }
        public double FinalAverageGrade { get; set; }
        public string GradeType { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
    }
}
