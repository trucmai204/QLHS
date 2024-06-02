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
        public float MidtermGradeI { get; set; }                                             
        public float FinalGradeI { get; set; }
        public float AverageGradeI { get; set; }
        public float MidtermGradeII { get; set; }
        public float FinalGradeII { get; set; }
        public float AverageGradeII { get; set; }
        public float FinalAverageGrade { get; set; }
        public string GradeType { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
    }
}
