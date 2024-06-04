using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double MidtermWeight { get; set; }
        public double FinalWeight { get; set; }
        public short Semester { get; set; }
    }
}
